
using System.Numerics;
using Raylib_cs;
Raylib.InitWindow(800, 600, "Hej");
Raylib.SetTargetFPS(60);

// Spelar Texturen

Texture2D p1box = Raylib.LoadTexture("pxArt.png");


// Spelar klassen
Player p1 = new();
p1.hp = 100;
p1.damage = 5;
p1.position = 0;

// Introtexten
int textPos = 810;

// Skott klassen
Bullet shot = new();

List<Bullet> shots = [];

for (int i = 0; i < shots.Count; i++)
{
    
}


// Raylib animationen
while (!Raylib.WindowShouldClose())
{

    // För att centrera Spelar bilden på musen
    int mouseX = Raylib.GetMouseX() - 50;


    // Skott funktionering
    shot.position.Y -= 5;
    if (Raylib.IsKeyPressed(KeyboardKey.Space) && -4 > shot.position.Y && shot.position.Y >  800 )
    {
         

            
            
            shot.position = new Vector2(mouseX + 50, 450);
            shots.Add(shot);




    }

   
    // Repetion av skott
    if (shot.position.Y < -50 && Raylib.IsKeyDown(KeyboardKey.Space))
    {
        shot.position.Y = 450;

        shot.position.X = mouseX + 50;
    }

  
    // Förflyttning av Introtext
    textPos -= 1;

    if (textPos < -21)
    {
        textPos = -22;
    }

    // Ritning av alla mönster
    Raylib.BeginDrawing();

    Raylib.DrawTexture(p1box, mouseX, 450, Color.White);
   
    Raylib.DrawText("Helo :), welcome to my game.", 100, textPos, 20, Color.Black);

    Raylib.DrawCircleV(shot.position, 4, Color.Beige);

    Raylib.ClearBackground(Color.SkyBlue);

    Raylib.EndDrawing();
}



