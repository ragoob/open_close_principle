using Open_close_principle.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_close_principle.Client
{
    public class LocalConsumer
    {
        private LocalDBOperation _localDBOperation;
        public LocalConsumer(LocalDBOperation localDBOperation)
        {
            this._localDBOperation = localDBOperation;
        }

        public void Create()
        {
            _localDBOperation.Create();
        }

        public void Delete()
        {
            _localDBOperation.Delete();
        }
    }
}
