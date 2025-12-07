using UnityEngine;

public class FoodObject : CellObject
{
    public int AmountGranted = 10;
    public override void PlayerEntered()
    {
        // TODO : Détruire l'objet nourriture 

        // TODO :  Appeler GameManager instance pour incrementer le compter de nourriture du joueur

        Debug.Log("Food increased");
    }
}
