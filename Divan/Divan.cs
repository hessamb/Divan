namespace Divan
{

    partial class DivanDataContext
    {
        private static DivanDataContext instance;

        public static DivanDataContext Instance {
            get{
                if(instance==null)
                    instance=new DivanDataContext();
                return instance;
            } 
        }

    }
}
