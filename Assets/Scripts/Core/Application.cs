using Core;

namespace Project
{
    public static class Application
    {
        public static Model Model { get; private set; }

        static Application()
        {
            Model = new Model();
        }
    }
}
