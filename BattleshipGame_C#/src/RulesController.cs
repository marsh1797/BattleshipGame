﻿using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using SwinGameSDK;

static class RulesController
{
	public static void DrawRules()
	{
		SwinGame.DrawText ("Rule",Color.AliceBlue,GameResources.GameFont("Courier"),2,30);
		SwinGame.DrawText ("***********************************",Color.AliceBlue,GameResources.GameFont("Courier"),2,40);
		SwinGame.DrawText ("1. Players take turns firing shots (by making a location guess) to attack enemy ships.",Color.AliceBlue,GameResources.GameFont("Courier"),2,100);
		SwinGame.DrawText ("2. On your turn, select a grid that identifies a row and column on your target grid.",Color.AliceBlue,GameResources.GameFont("Courier"),2,130);
		SwinGame.DrawText ("Your opponent checks that space on his ocean grid and responds \"miss\" ",Color.AliceBlue,GameResources.GameFont("Courier"),2,160);
		SwinGame.DrawText ("if there is no ship there or \"hit\" if you guessed a space that contained a ship.",Color.AliceBlue,GameResources.GameFont("Courier"),2,190);
		SwinGame.DrawText ("3. When your ship is hit, the grid became red colour",Color.AliceBlue,GameResources.GameFont("Courier"),2,210);
		SwinGame.DrawText ("4. The first player to sink all opposing ships wins the game.",Color.AliceBlue,GameResources.GameFont("Courier"),2,240);

	}


}

