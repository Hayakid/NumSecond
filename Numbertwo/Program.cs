double GetLens(int x1,int y1,int z1, int x2,int y2,int z2)
{
double len = Math.Sqrt((x1-x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
return len;
}
Console.WriteLine(GetLens(3, 6, 8, 2, 1, -7));    