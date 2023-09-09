//using System.Collections;

//namespace Rev
//{
//    class FiveIntegers:IEnumerable
//    {
//        int[] values;
//        public FiveIntegers(int s,int a,int z,int y ,int x)
//        {
//         values = new[] { s,a,z,y,x};
            
//        }

//        public IEnumerator GetEnumerator() /*=> new Enumrator(this);*/
//        {
//            foreach(var item in values)
//            {
//                yield return item;/*New Version*/
//            }
//        }
//        #region Old Virgin
//        //class Enumrator: IEnumerator
//        //{
//        //    int ci = -1;
//        //    FiveIntegers vlaues;
//        //    public Enumrator(FiveIntegers integers)
//        //    {
//        //        vlaues = integers;

//        //    }

//        //    public object Current {
//        //        get
//        //        { 
//        //            if (ci == -1)
//        //                throw new InvalidOperationException($"Enumoration not started");
//        //            if(ci==vlaues.values.Length)  
//        //                throw new InvalidOperationException($"Enumoration Ending");
//        //            return vlaues.values[ci];
//        //        }
//        //    }

//        //    public bool MoveNext()
//        //    {
//        //        if (ci>=vlaues.values.Length-1)
//        //        {
//        //            return false;
//        //        }
//        //        return ++ci<vlaues.values.Length;

//        //    }

//        //    public void Reset()=>ci = -1;

//        //} 
//        #endregion
//    }

//} 