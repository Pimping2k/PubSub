namespace Events
{
    public struct DamageEvent
    {
        public int Damage;
        public string DamageResolver;

        public DamageEvent(int damage, string resolver)
        {
            Damage = damage;
            DamageResolver = resolver;
        }
    }
}