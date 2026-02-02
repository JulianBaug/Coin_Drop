using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour
{
    // declare a variable to store the speed of movement as a value.
    //   - float is the type of data that will be stored (float is short for floating-point; it can have a decimal point)
    //   - speed is the name of the variable. We get to make this up, but it should be clear and meaningful.
    //   This variable is called an instance member. Many separate game objects can use this script for a component and
    //   they will each get a separate copy, an instance, of Wander. This includes instance members, like speed, each
    //   with their own different value. This means those objects can wander at different speeds using this same
    //   script as a blueprint.

    float speed; //speed stores the amount of horizontal distance to move per split second

    public float outsideCamraX = 10f;


    // Start is called before the first frame update
    void Start()
    {
        // Set the speed to a random number between 1 and 10 inclusive. Could be 5.335, could be 9.2, etc.
        //   Random is a helpful class provided by Unity that can generate unpredictable numbers. Here, we are calling
        //   a method into action named Range. We give it a minimum number and a maximum number and it gives us a
        //   randomly picked number from within that range (1 and 10 are possibilities, along with anything between).


        speed = Random.Range(1.0f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {

        // The Transform component has methods for taking action on its own data.
        // If you want to move the position, you can call Translate() into action, like below.
        //   transform and gameObject automatically reference the object you have this script on.
        //   The period/dot after transform, below, is used to access members of the transform. Here, we call
        //   the Translate method into action, but we can also get data like the position, rotation, and localScale
        //   that is visible in the inspector.
        //   Translate has several ways it can be called. Here, we are telling it how much to change in x, y, and z.

        transform.Translate(speed * Time.deltaTime, 0, 0);

        // speed * Time.deltaTime
        //   This expression, above, calculates how much to move every split second. speed has a random number in it
        //   to represent how fast: how far it will move per split second. The * means multiply. The Time.deltaTime
        //   is a fraction of a second (like a percentage) that we multiply by. We have to do this to get smooth movement
        //   because the time between Updates is not constant.

        // When this game object wanders offscreen, we want to move it all the way over to the other side, like a reset.
        //   We need to make sure we only make that move if we moved far enough to the right. Most of the time this code
        //   is reached, the position has not gone too far to the right (the x coordinate has not gone high enough). So,
        //   we set up a "selection" that keeps the reset code from being reached. The "selection" is like a gate that can
        //   only be opened under certain specific conditions.
        //
        //   More specifically, we are using an if statement with a condition that needs to be found true in order to
        //   enter into its block and do the reset. (The block is contained within braces, also called curly brackets.)

        if (transform.position.x > outsideCamraX)
        {
            transform.Translate(outsideCamraX * -2, 0, 0);
        }

    }
}
