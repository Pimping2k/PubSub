using Examples;

namespace Events
{
    public struct PlayerStatsEvent : IEvent
    {
        public float LastDamage;
        public float Health;

        public PlayerStatsEvent(float lastDamage, float health)
        {
            LastDamage = lastDamage;
            Health = health;
        }
    }
}