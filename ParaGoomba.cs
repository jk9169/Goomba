using System;
using System.Threading;

class ParaGoomba : villain
{
    private string[] goombaSprite;
    int direction = 1;
    int position = 0;

    public ParaGoomba()
    {
        goombaSprite = new string[10];
        goombaSprite[0] = @"              ________  ";
        goombaSprite[1] = @"             /        \ ";
        goombaSprite[2] = @"            /  \    /  \ ";
        goombaSprite[3] = @"           /   |    |   \ ";
        goombaSprite[4] = @"_________ /  -^------^-  \ _________";
        goombaSprite[5] = @"\_       |________________|       _/";
        goombaSprite[6] = @"  \_           /    \           _/  ";  
        goombaSprite[7] = @"    \____ ____|      |____ ____/";
        goombaSprite[8] = @"         /____\ ==== /____\ ";
        goombaSprite[9] = @"                             ";
    }

    public void DrawSprite(int whitespaces)
    {
        string whitespace = new string(' ', whitespaces); // 공백 문자열 생성
        for (int i = 0; i < goombaSprite.Length; i++)
        {
            Console.WriteLine(whitespace + goombaSprite[i]);
        }
    }

    public void animate()
    {
        while(true)
        {
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
            Thread.Sleep(200);
            Console.Clear();
        }
    }
}