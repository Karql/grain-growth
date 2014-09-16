using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grain_growth
{
    public class SRXAlgorithm : AlgorithmBase
    {
        public void AddEnergy(double energy)
        {
            this.grid.ResetCurrentCellPosition();

            do
            {
                if (this.IsNotRecrystalizedCellOnBoundary(this.grid.CurrentCell))
                {
                    this.grid.CurrentCell.Energy = energy;
                }
            } while (this.grid.Next());
        }

        public void AddNucleations(int nucleationsNumber)
        {
            int[] notUsedIds = this.GetNotUsedIds().Take(nucleationsNumber).ToArray();
            Cell[] cellsForNucleations = this.GetNotRecystalizedCellsOnBoundary().Take(nucleationsNumber).ToArray();
            
            for (int i = 0; i < nucleationsNumber && i < notUsedIds.Length && i < cellsForNucleations.Length; ++i)
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
                Cell[] recrystalizedNeighboors = c.MoorNeighborhood.Where(i => i.ID > 1 && i.Recrystalized).ToArray();

                //double e1 = c.MoorNeighborhood.Where(i => i.ID != c.ID).Sum(i => i.Energy) + c.Energy;
                //int newId = recrystalizedNeighboors[RandomHelper.Next(recrystalizedNeighboors.Length)].ID;
                //double e2 = c.MoorNeighborhood.Where(i => i.ID != newId).Sum(i => i.Energy);

                double e1 = c.MoorNeighborhood.Count(i => i.ID != c.ID) + c.Energy;
                int newId = recrystalizedNeighboors[RandomHelper.Next(recrystalizedNeighboors.Length)].ID;
                double e2 = c.MoorNeighborhood.Count(i => i.ID != newId);

                if (e2 - e1 <= 0)
                {
                    c.ID = newId;
                    c.NewID = newId;
                    c.Recrystalized = true;
                    c.Energy = 0;
                }
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
            return cell.ID > 1 && !cell.Recrystalized && cell.MoorNeighborhood.Count(i => i.ID != cell.ID && !i.Recrystalized) > 0;
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
