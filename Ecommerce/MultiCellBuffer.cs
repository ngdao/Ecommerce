﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ecommerce
{
    public class Cell
    {
        string encodedStr;

        public Cell()
        {
            this.encodedStr = "";
        }

        public string getCell()
        {
            return this.encodedStr;
        }

        public void setCell(string message)
        {
            this.encodedStr = message;
        }
    }
    class MultiCellBuffer
    {
        Semaphore pool = new Semaphore(0,3);
        Cell[] cellArray;

        public MultiCellBuffer()
        {
            for (int i = 0; i < 3; i++)
                this.cellArray[i] = new Cell();
        }

        //Cell getOneCell() { return Cell someCell; }
        //void setOneCell() { cellArray[someCell].encodedStr = someString;}
    }

}
