﻿using OrdonnancementsEquitables.Jobs;
using OrdonnancementsEquitables.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdonnancementsEquitables.Models
{
    public class MaxHeap<TJobCo> where TJobCo : JobCo
    {
        public int Count => table.Count;
        
        private readonly List<TJobCo> table;

        public MaxHeap()
        {
            table = new List<TJobCo>();
        } 

        public void Insert(TJobCo item)
        {
            table.Add(item);
            int index = Count - 1;
            while (index > 0 && table[index / 2 - 1].Time < item.Time)
            {
                index = index / 2 - 1;
                table.Swap(index, index / 2 - 1);
            }
        }

        public TJobCo RemoveMax()
        {
            if (Count == 0) 
                return null;

            table.Swap(0, Count);
            int index = 0;
            TJobCo res = table[Count - 1];
            table.RemoveAt(Count - 1);

            while (index < Count)
            {
                int tmp = index;
                int left = 2 * index + 1; 
                int right = 2 * index + 2; 

                if (left < Count && table[left].Time > table[index].Time)
                    tmp = left;

                if (right < Count && table[right].Time > table[index].Time)
                    tmp = right;

                if (index != tmp)
                    table.Swap(index, tmp);
                else
                    break;
                
            }
            return res;
        }
    }
}
