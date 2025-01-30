using Raylib_cs;

Raylib.InitWindow(800, 600, "Hej");
Raylib.SetTargetFPS(60);

Rectangle p1box = new(30, 40, 64, 64);

Player p1 = new();
p1.hp = 100;
p1.damage = 5;
p1.position = 0;



while (!Raylib.WindowShouldClose())
{

    int mouseX = Raylib.GetMouseX();


    p1box.X = mouseX;
    p1box.Y = 516;


    Raylib.BeginDrawing();

    Raylib.DrawRectangleRec(p1box, Color.Black);
    Raylib.DrawText("Helo :), welcome to my game.", 100, 80, 20, Color.Black);

    Raylib.ClearBackground(Color.SkyBlue);
    Raylib.EndDrawing();
}



