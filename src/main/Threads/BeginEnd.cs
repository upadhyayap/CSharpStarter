using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpStarter.src.main.Threads
{
   public class BeginEnd
    {
        public void doWork(){
            Debug.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId.ToString());
            Debug.WriteLine("doing work");
        }

        delegate void DoWorkDelegate();

        public void doWorkDelegateAsyncTest()
        {
            Debug.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId.ToString());
            DoWorkDelegate doingwork = new DoWorkDelegate(doWork);

            // BeginInvoke will execute method in different thread
            AsyncCallback asyncCallback = new AsyncCallback(callback);
            IAsyncResult ar = doingwork.BeginInvoke(asyncCallback, doingwork);

            // Do work in main thread here

            //doingwork.EndInvoke(ar);
        }

        private void callback(IAsyncResult asyncResult)
        {
            var doingWork = asyncResult.AsyncState as DoWorkDelegate;

            doingWork.EndInvoke(asyncResult);
        }
    }
}
