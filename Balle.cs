using Raylib_cs;
using System.Numerics;

namespace Breakout;

static partial class Program
{
    /// <summary>Pose la balle au milieu du dessus de la raquette.</summary>
    static void CollerBalleARaquette()
    {
        positionBalle.Y = positionRaquette.Y;
        positionBalle.X = positionRaquette.X + (LARGEUR_RAQUETTE / 2);
    }

    /// <summary>Donne à la balle sa vitesse de départ.</summary>
    static void LancerBalle()
    {

        if (Raylib.IsKeyPressed(KeyboardKey.Space))
        {
            vitesseBalle = new Vector2(VITESSE_BALLE, -VITESSE_BALLE);
            etat = EtatJeu.Jeu;
        }
    }

    /// <summary>Avance la balle selon sa vitesse.</summary>
    static void DeplacerBalle(float dt)
    {
    }

    /// <summary>Fait rebondir la balle sur les murs gauche, droit et haut.</summary>
    static void RebondirSurMurs()
    {
    }

    /// <summary>Indique si la balle est entièrement sortie par le bas de la fenêtre.</summary>
    static bool BalleSortieEnBas()
    {
        return false;
    }
}
