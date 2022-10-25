
namespace CarApp.helper
{
    public static class Utilitis
    {


        public static bool Convertor(string word)
        {
            try
            {
                Convert.ToDecimal(word);
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }
    }
}