using UnityEngine;

public class Battle : MonoBehaviour
{
    void Start()
    {

        scrClass a = new scrClass();
        a.level = 74;
        a.attack = 123;

        scrClass b = new scrClass();
        b.level = 54;
        b.attack = 123;

        Move move = new Move();
        move.power = 65;

        a.moves = new Move[4];
        a.moves[0] = move;

        Damage(a, b);
    }

    void Damage(scrClass a, scrClass b)
    {
        Debug.Log(((((2 * a.level) / 5) + 2 * (a.attack / b.defense)) / 50) + 2);
    }
}
