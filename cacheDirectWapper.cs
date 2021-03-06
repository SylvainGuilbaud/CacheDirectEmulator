using System;
using InterSystems.Data.IRISClient;
using InterSystems.Data.IRISClient.ADO;

namespace cdapp
{
    public class cacheDirectWapper
    {
        public IRISConnection conn = new IRISConnection();
        public IRISObject cd;

        private string p0;
        private string p1;
        private string p2;
        private string p3;
        private string p4;
        private string p5;
        private string p6;
        private string p7;
        private string p8;
        private string p9;
        private string plist;
        private string pdelim;
        private string value;
        private string code;
        private long execflag;
        private string errorname;
        private long error;

        public string P0
        {
            set { this.p0 = value; }
            get { return this.p0; }
        }
        public string P1
        {
            set { this.p1 = value; }
            get { return this.p1; }
        }
        public string P2
        {
            set { this.p2 = value; }
            get { return this.p2; }
        }
        public string P3
        {
            set { this.p3 = value; }
            get { return this.p3; }
        }
        public string P4
        {
            set { this.p4 = value; }
            get { return this.p4; }
        }
        public string P5
        {
            set { this.p5 = value; }
            get { return this.p5; }
        }
        public string P6
        {
            set { this.p6 = value; }
            get { return this.p6; }
        }
        public string P7
        {
            set { this.p7 = value; }
            get { return this.p7; }
        }
        public string P8
        {
            set { this.p8 = value; }
            get { return this.p8; }
        }
        public string P9
        {
            set { this.p9 = value; }
            get { return this.p9; }
        }
        public string PLIST
        {
            set { this.plist = value; }
            get { return this.plist; }
        }
        public string PDELIM
        {
            set { this.pdelim = value; }
            get { return this.pdelim; }
        }
        public string Value
        {
            set { this.value = value; }
            get { return this.value; }
        }
        public string Code
        {
            set { this.code = value; }
            get { return this.code; }
        }
        public long ExecFlag
        {
            set {
                this.execflag = value;
                if (value == 1) {
                    this.Execute(this.code);
                }
            }
            get { return this.execflag; }
        }
        public string ErrorName
        {
            get { return this.errorname; }
        }
        public string Error
        {
            get { return this.error.ToString(); }
        }


        public cacheDirectWapper(string constr)
        {
            try
            {
               
                conn.ConnectionString = constr;
                conn.Open();
                IRIS iris = IRIS.CreateIRIS(conn);
                cd = (IRISObject)iris.ClassMethodObject("CacheDirect.Emulator", "%New");

            }
            finally
            {
            }
        }

        public Boolean end() {

            try
            {
                cd.Dispose();
                conn.Close();
            }
            finally
            {
            }
            return true;
        }

        public long Execute(string command)
        {
            long status;

            cd.Set("P0", p0);
            cd.Set("P1", p1);
            cd.Set("P2", p2);
            cd.Set("P3", p3);
            cd.Set("P4", p4);
            cd.Set("P5", p5);
            cd.Set("P6", p6);
            cd.Set("P7", p7);
            cd.Set("P8", p8);
            cd.Set("P9", p9);
            cd.Set("PLIST", plist);
            cd.Set("PDELIM", pdelim);

            status = (long)cd.Invoke("Execute", command);

            if (cd.Get("P0") is string)
            {
                p0 = (string)cd.Get("P0");
            }
            else {
                if (cd.Get("P0") is null)
                {
                }
                else
                {
                    p0 = cd.Get("P0").ToString();
                }
            }

            if (cd.Get("P1") is string)
            {
                p1 = (string)cd.Get("P1");
            }
            else
            {
                if (cd.Get("P1") is null)
                {
                }
                else
                {
                    p1 = cd.Get("P1").ToString();
                }
            }

            if (cd.Get("P2") is string)
            {
                p2 = (string)cd.Get("P2");
            }
            else
            {
                if (cd.Get("P2") is null)
                {
                }
                else
                {
                    p2 = cd.Get("P2").ToString();
                }
            }

            if (cd.Get("P3") is string)
            {
                p3 = (string)cd.Get("P3");
            }
            else
            {
                if (cd.Get("P3") is null)
                {
                }
                else
                {
                    p3 = cd.Get("P3").ToString();
                }
            }

            if (cd.Get("P4") is string)
            {
                p4 = (string)cd.Get("P4");
            }
            else
            {
                if (cd.Get("P4") is null)
                {
                }
                else
                {
                    p4 = cd.Get("P4").ToString();
                }
            }

            if (cd.Get("P5") is string)
            {
                p5 = (string)cd.Get("P5");
            }
            else
            {
                if (cd.Get("P5") is null)
                {
                }
                else
                {
                    p5 = cd.Get("P5").ToString();
                }
            }

            if (cd.Get("P6") is string)
            {
                p6 = (string)cd.Get("P6");
            }
            else
            {
                if (cd.Get("P6") is null)
                {
                }
                else
                {
                    p6 = cd.Get("P6").ToString();
                }
            }

            if (cd.Get("P7") is string)
            {
                p7 = (string)cd.Get("P7");
            }
            else
            {
                if (cd.Get("P7") is null)
                {
                }
                else
                {
                    p7 = cd.Get("P7").ToString();
                }
            }

            if (cd.Get("P8") is string)
            {
                p8 = (string)cd.Get("P8");
            }
            else
            {
                if (cd.Get("P8") is null)
                {
                }
                else
                {
                    p8 = cd.Get("P8").ToString();
                }
            }

            if (cd.Get("P9") is string)
            {
                p9 = (string)cd.Get("P9");
            }
            else
            {
                if (cd.Get("P9") is null)
                {
                }
                else
                {
                    p9 = cd.Get("P9").ToString();
                }
            }

            if (cd.Get("PLIST") is string)
            {
                plist = (string)cd.Get("PLIST");
            }
            else
            {
                if (cd.Get("PLIST") is null)
                {
                }
                else
                {
                    plist = cd.Get("PLIST").ToString();
                }
            }

            if (cd.Get("PDELIM") is string)
            {
                pdelim = (string)cd.Get("PDELIM");
            }
            else
            {
                if (cd.Get("PDELIM") is null)
                {
                }
                else
                {
                    pdelim = cd.Get("PDELIM").ToString();
                }
            }

            if (cd.Get("Value") is string)
            {
                value = (string)cd.Get("Value");
            }
            else
            {
                if (cd.Get("Value") is null)
                {
                }
                else
                {
                    value = cd.Get("Value").ToString();
                }
            }

            errorname =(string) cd.Get("ErrorName");
            error = (long)cd.Get("Error");


            return status;
        }

        public string getPLIST(int index) {

           string[] PLISTArray = cd.Get("PLIST").ToString().Split(cd.Get("PDELIM").ToString().ToCharArray());

           return PLISTArray[index -1];
        }

        public Boolean setPLIST(int index, string replace) {

           string[] PLISTArray = cd.Get("PLIST").ToString().Split((cd.Get("PDELIM").ToString().ToCharArray()));

           PLISTArray[index - 1] = replace;
           cd.Set("PLIST", string.Join(cd.Get("PDELIM").ToString(), PLISTArray));
           return true;
        }
   }
}
