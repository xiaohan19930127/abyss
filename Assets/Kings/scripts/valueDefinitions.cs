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
		name,//名字，暂时不需要//
		surname,//姓氏，暂时不需要//
		gender,//性别，暂时不需要//
		country,//国家，暂时不需要//
		years,//年份，可以作为周期计数，xx周//
		army,//军队，表示第一属性：生命//
		people,//人口，表示第二属性：人脉//
		religion,//宗教，表示第三属性：声望//
		money,//金钱，表示第四属性：流动金//
		authority,//权力，隐藏的阶段卡片属性//
		intelligence,//智力，隐藏的阶段卡片属性//
		charisma,//魅力，隐藏的阶段卡片属性//
		luck,//运气，隐藏的阶段卡片属性//
		creativity,//创造力，隐藏的阶段卡片属性，技术力//
		look,//外貌//
		health,//健康//
		marriage,//婚姻//
		married,//已婚//
		adready,//已就绪//
		gamesPlayed,//已玩游戏，即非新手//
		showResult,//显示结果//
        moneyCredit,//金钱积分//
        war,//战争，可表示善恶争锋//
        enemyArmy,//敌军，恶念//
        playerLevel,//玩家等级//
        admobVideo,//视频广告//
        admobBanner,//横幅广告//
		zichan,
		fenzhi,//用于临时记录分支路线
        /*mayor_year,
        mayor_people,
        mayor_party,
        mayor_police,
        mayor_money,
        mayor_level,
        mayor_avatar,
		abyss_main_line,//主线，理应一直增
		abyss_main_branch,//控制分支情况，应该在1、2、3中切换
		abyss_regular_stage //常规卡出现的阶段，例如Stage2里的卡不会出现在1中，防止错乱
		*/
	}
}
