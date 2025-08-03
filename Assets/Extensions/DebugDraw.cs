using DCFApixels;
using UnityEngine;

public class DebugDraw
{
    public static void DArrow(Vector3 start, Vector3 end, Color color = default)
    {
        if (color == default)
            color = Color.white;
        DebugX.Draw(Time.deltaTime, color).Line(start, end, DebugXLine.Default, DebugXLine.Arrow);
    }

    public static void DebugDrawLine(Vector3 start, Vector3 end, Color color = default)
    {
        if (color == default)
            color = Color.white;
        DebugX.Draw(color).Line(start, end, DebugXLine.Default, DebugXLine.Default);
    }

    public static void DebugDrawSphere(Vector3 position, float size, Color color = default)
    {
        if (color == default)
            color = Color.white;
        DebugX.Draw(color).Sphere(position, size);
    }
}
