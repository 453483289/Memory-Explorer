﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryExplorer.Details
{
    public class InformationDetailsViewModel : BindableBase
    {
        public IEnumerable<KvpResult> InfoDictionary
        {
            get
            {
                if (_dataModel == null || _dataModel.InfoDictionary == null)
                    return null;
                var r =
                    from item in _dataModel.InfoDictionary
                    select new KvpResult(item);

                return r;
            }
        }
        
    }
    
}
