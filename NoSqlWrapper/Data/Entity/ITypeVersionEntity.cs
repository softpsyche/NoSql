﻿using System;
namespace NoSqlWrapper.Data.Entity
{
    public interface ITypeVersionEntity
    {
        Guid TypeVersionId { get; set; }
        string AssemblyName { get; set; }
        string TypeName { get; set; }
        string TypeSignature { get; set; }
        Int32 Sequence { get; }
    }
}
