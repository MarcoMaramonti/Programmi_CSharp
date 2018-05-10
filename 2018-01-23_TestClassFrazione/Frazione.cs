using System;

namespace FrazioneName
{
    public class Frazione
    {
        //attributi
	    public int n,d;
        public string s;

        //costruttore della classe
	    public Frazione(int num = 0, int den = 1)
	    {
            n = num; 
            d = den;
	    }

	    //metodi pubblici
        public void set(int num, int den)
        {
            n = num;
            d = den;
        }

	    public static Frazione operator+(Frazione f, Frazione f1)
        {
            Frazione app = new Frazione();

            app.d = f.d * f1.d;
            app.n = f.n * f1.d + f.d * f1.n;
            app.MinTerm();

            return app;
        } 

        public static Frazione operator-(Frazione f, Frazione f1)
        {
            Frazione app = new Frazione();

            app.d = f.d * f1.d;
            app.n = f.n * f1.d - f.d * f1.n;
            app.MinTerm();

            return app;
        } 

        public static Frazione operator*(Frazione f, Frazione f1)
        {
            Frazione app = new Frazione();

            app.d = f.d * f1.d;
            app.n = f.n * f1.n;
            app.MinTerm();

            return app;
        }

        public static Frazione operator/(Frazione f, Frazione f1)
        {
            Frazione app = new Frazione();

            app.d = f.d * f1.n;
            app.n = f.n * f1.d;
            app.MinTerm();

            return app;
        }

        //metodi protetti
        protected string mcd()
        {
            int nc = n;
            int dc = d;

            if (nc < 0)
                nc = -nc;
            while (nc != dc)
            {
                if (nc > dc)
                    nc = nc - dc;
                else
                    dc = dc - nc;
            }
            return s;
        }
        protected void MinTerm()
        {
            int n1 = n;
            int d1 = d;

            while(n1 != d1)
            {
                if(n1 > d1)
                n1 = n1 - d1;
            else
                d1 = d1 - n1;
            }
            n = n / n1;
            d = d / d1;
        }
    }
}
