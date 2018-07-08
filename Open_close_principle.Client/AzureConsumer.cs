using Open_close_principle.Abstraction;
using Open_close_principle.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_close_principle.Client
{
  public  class AzureConsumer
    {
        private AzureConsumer _azureDbOperation;
        public AzureConsumer(AzureConsumer azureDbOperation)
        {
            this._azureDbOperation = azureDbOperation;
        }

        public void Create()
        {
            _azureDbOperation.Create();
        }

        public void Update()
        {
            _azureDbOperation.Update();
        }

        public void Delete()
        {
            _azureDbOperation.Delete();
        }
    }
}
