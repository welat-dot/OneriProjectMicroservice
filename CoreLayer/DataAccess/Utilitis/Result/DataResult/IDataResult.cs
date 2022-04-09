﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataAccess.Utilitis.Result.DataResult
{
    public  interface IDataResult<TData>:IResult
    {
        TData data { get; }    
    }
    
}
