using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicle6
{
    public delegate void Notify(); //delegate
    internal class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted; // event
        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            OnProcessCompleted();
        }
        //protected virtual method
        protected virtual void OnProcessCompleted()
        {
            //if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke();
        }
    }
}
