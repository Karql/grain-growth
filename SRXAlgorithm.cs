using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grain_growth
{
    public class SRXAlgorithm : AlgorithmBase
    {
        public void AddNucleations(int nucleationsNumber)
        {
            int[] notUsedIds = this.GetNotUsedIds().Take(nucleationsNumber).ToArray();
            Cell[] cellsForNucleations = this.GetNotRecystalizedCellsOnBoundary().Take(nucleationsNumber).ToArray();


            for (int i = 0; i < nucleationsNumber; ++i)
            {
                cellsForNucleations[i].ID = notUsedIds[i];
                cellsForNucleations[i].NewID = notUsedIds[i];
                cellsForNucleations[i].Recrystalized = true;
                cellsForNucleations[i].Energy = 0;
            }
        }

        public void Step()
        {
            foreach (Cell c in this.GetCellsToProcess())
            {
                int[] neighborsId = c.MoorNeighborhood.Where(i => i.ID > 1 && i.Recrystalized).Select(i => i.ID).ToArray();

                int newId = neighborsId[RandomHelper.Next(neighborsId.Length)];

                c.ID = newId;
                c.NewID = newId;
                c.Recrystalized = true;

                //int e1 = neighborsId.Where(i => i != c.ID).Count();
                //int newId = neighborsId[RandomHelper.Next(neighborsId.Length)];
                //int e2 = neighborsId.Where(i => i != newId).Count();

                //if (e2 - e1 <= 0)
                //{
                //    c.ID = newId;
                //}
            }
        }

        private IEnumerable<Cell> GetNotRecystalizedCellsOnBoundary()
        {
            List<Cell> cells = new List<Cell>();

            this.grid.ResetCurrentCellPosition();

            do
            {
                if (this.IsNotRecrystalizedCellOnBoundary(this.grid.CurrentCell))
                {
                    cells.Add(this.grid.CurrentCell);
                }
            } while (this.grid.Next());

            // Random order
            return cells.OrderBy(i => RandomHelper.Next());            
        }
        
        private bool IsNotRecrystalizedCellOnBoundary(Cell cell)
        {
            return cell.ID > 1 && !cell.Recrystalized && cell.MoorNeighborhood.Count(i => i.ID != cell.ID) > 0;
        }

        private IEnumerable<Cell> GetCellsToProcess()
        {
            List<Cell> cells = new List<Cell>();

            this.grid.ResetCurrentCellPosition();

            do
            {
                if (this.IsNotRecrystalizedCellWithRecrystalizedNeighboor(this.grid.CurrentCell))
                {
                    cells.Add(this.grid.CurrentCell);
                }
            } while (this.grid.Next());

            // Random order
            return cells.OrderBy(i => RandomHelper.Next());
        }

        private bool IsNotRecrystalizedCellWithRecrystalizedNeighboor(Cell cell)
        {
            return cell.ID > 1 && !cell.Recrystalized && cell.MoorNeighborhood.Count(i => i.Recrystalized) > 0;
        }
    }
}
