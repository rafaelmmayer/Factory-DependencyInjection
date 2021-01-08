namespace Factory_DependencyInjection
{
    public static class ObjetoFactory
    {
        public static IExemplo Create(){                   

            if(string.IsNullOrEmpty(" ")){
                return new RegrasDeNegocio("foo");
            }
            else {
                return new OutrasRegrasNegocio();
            }
        }
    }
}