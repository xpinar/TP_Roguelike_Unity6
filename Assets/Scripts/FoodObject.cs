using UnityEngine;

public class FoodObject : CellObject
{
    public int AmountGranted = 10;
    public override void PlayerEntered()
    {
        Destroy(gameObject);

        // TODO :Increase the player's food count

        Debug.Log("Food increased");
    }
}
