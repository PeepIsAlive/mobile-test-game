namespace Core
{
    public sealed class Npc : Person
    {
        public Npc(Person settings)
            : base(settings.Gender, settings.Age, settings.Name, settings.LastName)
        {

        }
    }
}
