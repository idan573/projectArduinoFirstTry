﻿using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.Storage.Table;

namespace projectArduinoFirstTry.Sources
{
    #region Medicine
    public struct Medicine : IComparer<Medicine>
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public long Code { get; set; }
        public string DangersDesc { get; set; }
        public string UserDesc { get; set; }
        public string ImagePath { get; set; }
        public int Price { get; set; }

        public Medicine(string name, DateTime dateTime, long code) : this()
        {
            Name = name;
            Date = dateTime;
            Code = code;
        }

        public int Compare(Medicine x, Medicine y)
        {
            return x.Code.CompareTo(y.Code);
        }

        public static implicit operator Predicate<object>(Medicine v)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region MedicineList

    public class MedicineList
    {
        public MedicineList()
        {
            MedicineVal = new List<Medicine>();
        }

        public List<Medicine> MedicineVal { get; set; }
    }

    public class MedicineEntity : TableEntity
    {
        public MedicineEntity(string code, string name)
        {
            this.PartitionKey = name;
            this.RowKey = code;
        }

        public MedicineEntity()
        {
        }

        public string Date { get; set; }

        public string DangersDesc { get; set; }

        public string UserDesc { get; set; }

        public int Price { get; set; }

        public string ImagePath { get; set; }
}

    #endregion

    public class DeltaAngle
    {
        public DeltaAngle(int deltaX, int deltaY)
        {
            DeltaX = deltaX;
            DeltaY = deltaY;
        }

        public int DeltaX;
        public int DeltaY;
    }

    public class MedicineInfo
    {
        public MedicineInfo(DeltaAngle deltaAngle)
        {
            DeltaAngle = deltaAngle;
        }

        public DeltaAngle DeltaAngle;
        public int Count;
    }
}
