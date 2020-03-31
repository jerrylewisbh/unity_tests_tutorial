public interface IPlayer
{
    float Health { get; set; }
    void ApplyDamage(float Damage, float attenuationFactor);

    void OnGameOver();
}