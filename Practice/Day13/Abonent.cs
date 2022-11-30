namespace Day13
{
    public class Abonent : Time
    {
        private int _hour, _minute, _second;
        private string _surname, _oper;
        public Abonent(string surname, string oper)
        {
            this._surname = surname;
            this._oper = oper;

        }
    }
}