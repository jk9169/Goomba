using System;
using System.Threading;

class Goomba : villain
{
    private string[] goombaSprite;
    private string[] goombaSpriteL;
    private string[] goombaSpriteR;
    private string[] starSprite;
    int direction = 1;
    int position = 0;

    public Goomba()
    {
        goombaSprite = new string[10];
        goombaSprite[0] = @"     ________  ";
        goombaSprite[1] = @"    /        \ ";
        goombaSprite[2] = @"   /  \    /  \ ";
        goombaSprite[3] = @"  /   |    |   \ ";
        goombaSprite[4] = @" /  -^------^-  \ ";
        goombaSprite[5] = @"|________________| ";
        goombaSprite[6] = @"      /    \ ";
        goombaSprite[7] = @" ____|      |____ ";
        goombaSprite[8] = @"/____\ ==== /____\ ";
        goombaSprite[9] = @"                 ";

        goombaSpriteL = new string[10];
        goombaSpriteL[0] = @"     ________  ";
        goombaSpriteL[1] = @"    /        \ ";
        goombaSpriteL[2] = @"   /  \    /  \ ";
        goombaSpriteL[3] = @"  /   |    |   \ ";
        goombaSpriteL[4] = @" /  -^------^-  \ ";
        goombaSpriteL[5] = @"|________________| ";
        goombaSpriteL[6] = @" ____ /    \ ";  
        goombaSpriteL[7] = @"/____\      |____ ";
        goombaSpriteL[8] = @"       ==== /____\ ";
        goombaSpriteL[9] = @"                     ";

        goombaSpriteR = new string[10];
        goombaSpriteR[0] = @"     ________  ";
        goombaSpriteR[1] = @"    /        \ ";
        goombaSpriteR[2] = @"   /  \    /  \ ";
        goombaSpriteR[3] = @"  /   |    |   \ ";
        goombaSpriteR[4] = @" /  -^------^-  \ ";
        goombaSpriteR[5] = @"|________________| ";
        goombaSpriteR[6] = @"      /    \ ____ ";
        goombaSpriteR[7] = @" ____|      /____\ ";
        goombaSpriteR[8] = @"/____\ ====         ";
        goombaSpriteR[9] = @"                     ";

        starSprite = new string[6];
        starSprite[0] = @"          ";
        starSprite[1] = @"  ___/\___";
        starSprite[2] = @"  \  ||  / ";
        starSprite[3] = @"  /__  __\";
        starSprite[4] = @"     \/   ";
        starSprite[5] = @"          "; 
    }

    public void DrawSprite(int whitespaces)
    {
        string whitespace = new string(' ', whitespaces); // 공백 문자열 생성
        // print_star(star);
        for (int i = 0; i < goombaSprite.Length; i++)
        {   
            
            if(whitespaces % 2 == 0)
            {
                Console.WriteLine(whitespace + goombaSpriteR[i]);
            } else if (whitespaces % 2 == 1) {
                Console.WriteLine(whitespace + goombaSpriteL[i]);
            }
            // Console.WriteLine(whitespace + goombaSprite[i]);
        }
    }

    public void animate()
    {
        // Star star = new Star();
        while(true)
        {
            for(int i = 0; i < starSprite.Length; i++)
            {
                Console.WriteLine(starSprite[i]);
            }
            position += direction;

            if (position < 0)
            {
                position = 0;
                direction = 1;
            }

            else if(position > 30)
            {
                position = 30;
                direction = -1;
            }

            DrawSprite(position);
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _  ");
            Thread.Sleep(200);
            Console.Clear();
        }
    }
}
