using MiraAPI.GameEnd;
using MiraAPI.Utilities;
using UnityEngine;

namespace VanillaPlus.GameOvers;

public class JesterGameOver : CustomGameOver
{
    public override bool VerifyCondition(PlayerControl playerControl, NetworkedPlayerInfo[] winners)
    {
        return winners is [{ Role: JesterRole }];
    }

    public override void AfterEndGameSetup(EndGameManager endGameManager)
    {
        endGameManager.WinText.text = "Jester wins!";
        endGameManager.WinText.color = Color.cyan;
        endGameManager.BackgroundBar.material.SetColor(ShaderID.Color, Color.magenta);
    }
}