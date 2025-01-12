using UnityEngine;

public interface LootBoxReward
{
    public void received();
    public Sprite getSprite();
}

public class FreeCat : LootBoxReward
{
    public PlayerMovement player;

    public void received()
    {
        Debug.Log("Yippee!");
        player.speed += 2f;
    }

    public Sprite getSprite()
    {
        return Resources.Load<Sprite>("Screenshot 2024-01-26 132455");
    }
}

public class Cat2 : LootBoxReward
{
    public void received()
    {
        Debug.Log("Yay!");

    }

    public Sprite getSprite()
    {
        return Resources.Load<Sprite>("elgato");
    }
}
