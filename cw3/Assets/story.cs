using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class story : MonoBehaviour
{



    string heroname = "hero";
    int heropower = 21;
    string villanname = "abood";
    int villanpower = 20;
    float playerspeed = 5.3f;





    void Start()

    {
        if (villanpower > heropower)

            print("who named him a hero");


        else if (villanpower == heropower)

            print("we are the same power what you are gonna do huh ?");

        else
            print("haha evry time the villan lose");


        print(playerspeed);
        setspeed(2.5f);
        print(playerspeed);



        compareSpeed(4, 2);
    }






   



    void setspeed(float speed)
    {
        playerspeed = speed;
    }

    void compareSpeed(float newspeed,float oldspeed )
    {if
      ( newspeed > oldspeed)
        {
            print(" newspeed: i am the new i am the stronger");
                }
           
                



    }
}
    

