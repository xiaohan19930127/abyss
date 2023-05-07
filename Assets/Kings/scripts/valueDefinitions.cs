using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valueDefinitions : MonoBehaviour {

	/*
	 * Define all your values of the game here.
	 * The value definitions are used in several scripts to 
	 * show easy dropdown menues e.g. for conditions or value modifications.
	 */

	public enum values{
		name,
		surname,
		gender,
		country,
		years,
		army,
		people,
		religion,
		money,
		authority,
		intelligence,
		charisma,
		luck,
		creativity,
		look,
		health,
		marriage,
		married,
		adready,
		gamesPlayed,
		showResult,
        moneyCredit,
        war,
        enemyArmy,
        playerLevel,
        admobVideo,
        admobBanner,
        mayor_year,
        mayor_people,
        mayor_party,
        mayor_police,
        mayor_money,
        mayor_level,
        mayor_avatar,
		abyss_main_line,//主线，理应一直增
		abyss_main_branch,//控制分支情况，应该在1、2、3中切换
		abyss_regular_stage //常规卡出现的阶段，例如Stage2里的卡不会出现在1中，防止错乱
	}
}
