using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;
using DevExpress.XtraTab;
using Discord;
using Discord.Webhook;
using DiscordRPC;
using GuidoCT.Properties;
using JRPC_Client;
using ToolSettings;
using XDevkit;

namespace GuidoCT
{
	// Token: 0x0200000A RID: 10
	public partial class Form1 : XtraForm
	{
		// Token: 0x060000BB RID: 187 RVA: 0x0001B538 File Offset: 0x00019738
		public Form1()
		{
			this.ini_0 = new INI("ToolSettings.ini");
			this.ini_1 = new INI("temp.ini");
			this.discordRpcClient_0 = new DiscordRpcClient("938437872606908498");
			this.timer_0 = new System.Windows.Forms.Timer();
			this.string_0 = "";
			this.string_1 = "";
			this.timer_1 = new System.Windows.Forms.Timer();
			this.list_0 = new List<string>();
			this.ini_2 = new INI("GameLauncher.ini");
			this.string_2 = new string[]
			{
				"multikill__objective_scorestreak_projectile",
				"multikill__rcbomb",
				"multikill__with_heroability",
				"multikill__with_heroweapon",
				"multikill__with_rcbomb",
				"multikill__zone_attackers",
				"multikill__attackers_ai_tank",
				"multikill__lmg_or_smg_hip_fire",
				"multikill__near_death",
				"multikill__remote_missile",
				"multikill__with_heroability",
				"multikill__with_heroweapon",
				"multikill__with_mgl",
				"multikill__attackers",
				"most_kills_least_deaths",
				"master_humiliation",
				"master_killer",
				"master_of_humiliation",
				"mastery_air_assault",
				"mastery_boot_camp",
				"mastery_career",
				"mastery_efficiency",
				"mastery_game_mode_heroics",
				"mastery_game_mode_victories",
				"mastery_ground_assault",
				"mastery_handling",
				"mastery_hero_weapon",
				"mastery_humiliation",
				"mastery_killer",
				"mastery_lethals",
				"mastery_perk_1",
				"mastery_perk_2",
				"mastery_perk_3",
				"mastery_return_fire",
				"mastery_specialist_abilitites",
				"mastery_specialist_killjoy",
				"mastery_support",
				"mastery_tactical",
				"mastery_wildcards",
				"medal_aitank_kill",
				"medal_annihilator_kill",
				"medal_annihilator_multikill",
				"medal_annihilator_multikill_2",
				"medal_armblades_kill",
				"medal_armblades_multikill",
				"medal_armblades_multikill_2",
				"medal_assisted_suicide",
				"medal_backstabber_kill",
				"medal_ball_capture_assist",
				"medal_ball_capture_carry",
				"medal_ball_capture_throw",
				"medal_ball_intercept",
				"medal_bomb_detonated",
				"medal_bounce_hatchet_kill",
				"medal_bowlauncher_kill",
				"medal_bowlauncher_multikill",
				"medal_bowlauncher_multikill_",
				"medal_c4_multikill",
				"medal_capture_enemy_crate",
				"medal_cleanse_kill",
				"medal_clear_2_attackers",
				"medal_combat_robot_kill",
				"medal_comeback_from_deathstreak",
				"medal_completed_match",
				"medal_dart_kill",
				"medal_death_machine_kill",
				"medal_defend_hq_last_alive",
				"medal_defused_bomb",
				"medal_defused_bomb_last_man_alive",
				"medal_destroyed_aitank",
				"medal_destroyed_combat_robot",
				"medal_destroyed_counteruav",
				"medal_destroyed_dart",
				"medal_destroyed_drone_strike",
				"medal_destroyed_emp",
				"medal_destroyed_heli_comlink",
				"medal_destroyed_heli_guard",
				"medal_destroyed_heli_gunner",
				"medal_destroyed_helicopter_agr_drop",
				"medal_destroyed_helicopter_giunit_drop",
				"medal_destroyed_high_altitude_vsat",
				"medal_destroyed_hover_rcxd",
				"medal_destroyed_microwave_turret",
				"medal_destroyed_plane_mortar",
				"medal_destroyed_raps_deployship",
				"medal_destroyed_raps_helicopter",
				"medal_destroyed_remote_missle",
				"medal_destroyed_rolling_thunder",
				"medal_destroyed_rolling_thunder_all_drones",
				"medal_destroyed_sentinel",
				"medal_destroyed_sentry_gun",
				"medal_destroyed_straferun",
				"medal_destroyed_supply_drop",
				"medal_destroyed_uav",
				"medal_destroyed_vtol_mothership",
				"medal_electrified",
				"medal_eliminate_oic",
				"medal_eliminate_sd",
				"medal_elimination_and_last_player_alive",
				"medal_end_enemy_armblades_attack",
				"medal_end_enemy_gravity_spike_attack",
				"medal_end_enemy_psychosis",
				"medal_end_enemy_specialist_weapon",
				"medal_escort_robot_disable",
				"medal_escort_robot_disable_near_goal",
				"medal_escort_robot_escort_goal",
				"medal_final_kill_elimination",
				"medal_first_kill",
				"medal_flag_capture",
				"medal_flag_carrier_kill_return_close",
				"medal_flamethrower_kill",
				"medal_flamethrower_multikill",
				"medal_flamethrower_multikill_2",
				"medal_flashback_kill",
				"medal_focus_earn_multiscorestreak",
				"medal_focus_earn_scorestreak",
				"medal_frag_multikill",
				"medal_gelgun_kill",
				"medal_gelgun_multikill",
				"medal_gelgun_multikill_2",
				"medal_gravityspikes_kill",
				"medal_gravityspikes_multikill",
				"medal_gravityspikes_multikill_2",
				"medal_hack__agrs_in_hack",
				"medal_hacked",
				"medal_hatchet_kill",
				"medal_headshot",
				"medal_heatwave_kill",
				"medal_heatwave_multikill_2",
				"medal_helicopter_comlink_kill",
				"medal_hover_rcxd_kill",
				"medal_hq_destroyed",
				"medal_hq_secure",
				"medal_humiliation_gun",
				"medal_kill_ball_carrier",
				"medal_kill_confirmed_multi",
				"medal_kill_enemies_one_bullet",
				"medal_kill_enemy_after_death",
				"medal_kill_enemy_grenade_throwback",
				"medal_kill_enemy_injuring_teammate",
				"medal_kill_enemy_one_bullet",
				"medal_kill_enemy_that_heatwaved_you",
				"medal_kill_enemy_that_is_in_air",
				"medal_kill_enemy_that_is_using_optic_camo",
				"medal_kill_enemy_that_is_wallrunning",
				"medal_kill_enemy_that_pulsed_you",
				"medal_kill_enemy_that_used_resurrect",
				"medal_kill_enemy_when_injured",
				"medal_kill_enemy_while_both_in_air",
				"medal_kill_enemy_while_capping",
				"medal_kill_enemy_while_capping_dom",
				"medal_kill_enemy_while_carrying_ball",
				"medal_kill_enemy_while_flashbanged",
				"medal_kill_enemy_while_in_air",
				"medal_kill_enemy_while_sliding",
				"medal_kill_enemy_while_stunned",
				"medal_kill_enemy_while_using_psychosis",
				"medal_kill_enemy_while_wallrunning",
				"medal_kill_enemy_who_has_flashbacked",
				"medal_kill_enemy_who_has_high_score",
				"medal_kill_enemy_who_has_powerarmor",
				"medal_kill_enemy_who_is_speedbursting",
				"medal_kill_enemy_who_is_using_focus",
				"medal_kill_enemy_who_killed_teammate",
				"medal_kill_enemy_with_care_package_crush",
				"medal_kill_enemy_with_fists",
				"medal_kill_enemy_with_gunbutt",
				"medal_kill_enemy_with_hacked_care_package",
				"medal_kill_enemy_with_more_ammo_oic",
				"medal_kill_enemy_with_their_weapon",
				"medal_kill_flag_carrier",
				"medal_kill_hacker_in_hack",
				"medal_kill_hacker_then_hack_in_hack",
				"medal_kill_in__seconds_gun",
				"medal_kill_underwater_enemy_explosive",
				"medal_kill_x_score_shrp",
				"medal_killed_annihilator_enemy",
				"medal_killed_armblades_enemy",
				"medal_killed_bomb_defuser",
				"medal_killed_bomb_planter",
				"medal_killed_bowlauncher_enemy",
				"medal_killed_enemy_while_carrying_flag",
				"medal_killed_flamethrower_enemy",
				"medal_killed_gelgun_enemy",
				"medal_killed_gravityspikes_enemy",
				"medal_killed_lightninggun_enemy",
				"medal_killed_minigun_enemy",
				"medal_killed_pineapple_enemy",
				"medal_killstreak_",
				"medal_killstreak_",
				"medal_killstreak_",
				"medal_killstreak_",
				"medal_killstreak_",
				"medal_killstreak_",
				"medal_killstreak_more_than_",
				"medal_knife_leader_gun",
				"medal_knife_with_ammo_oic",
				"medal_koth_secure",
				"medal_lightninggun_kill",
				"medal_lightninggun_multikill",
				"medal_lightninggun_multikill_2",
				"medal_longshot_kill",
				"medal_microwave_turret_kill",
				"medal_minigun_kill",
				"medal_minigun_multikill",
				"medal_minigun_multikill_2",
				"medal_most_points_shrp",
				"medal_multikill_2",
				"medal_multikill_3",
				"medal_multikill_4",
				"medal_multikill_5",
				"medal_multikill_6",
				"medal_multikill_7",
				"medal_multikill_8",
				"medal_multikill_more_than_8",
				"medal_multiple_grenade_launcher_kill",
				"medal_neutral_b_secured",
				"medal_optic_camo_capture_objective",
				"medal_optic_camo_kill",
				"medal_pineapple_kill",
				"medal_pineapple_multikill",
				"medal_pineapple_multikill_2",
				"medal_plane_mortar_kill",
				"medal_position_secure",
				"medal_power_armor_kill",
				"medal_quickly_secure_point",
				"medal_raps_kill",
				"medal_remote_missile_kill",
				"medal_resurrect_kill",
				"medal_retrieve_own_tags",
				"medal_revenge_kill",
				"medal_robot_disable_near_goal",
				"medal_rolling_thunder_kill",
				"medal_sentinel_kill",
				"medal_sentry_gun_kill",
				"medal_share_care_package",
				"medal_speed_burst_kill",
				"medal_stick_explosive_kill",
				"medal_stop_enemy_killstreak",
				"medal_straff_run_kill",
				"medal_teammate_confirm_kill",
				"medal_traversal_kill",
				"medal_uninterrupted_obit_feed_kills",
				"medal_vision_pulse_kill",
				"medal_vtol_mothership_kill",
				"medal_won_match",
				"medal_x2_score_shrp",
				"most_kills_least_deaths",
				"multikill_2_objective_scorestreak_projectile",
				"multikill_2_rcbomb",
				"multikill_2_with_heroability",
				"multikill_2_with_heroweapon",
				"multikill_2_with_rcbomb",
				"multikill_2_zone_attackers",
				"multikill_3_attackers_ai_tank",
				"multikill_3_lmg_or_smg_hip_fire",
				"multikill_3_near_death",
				"multikill_3_remote_missile",
				"multikill_3_with_heroability",
				"multikill_3_with_heroweapon",
				"multikill_3_with_mgl",
				"multikill_5_attackers",
				"objective_time",
				"offends",
				"oic_gamemode_mastery",
				"optic_camo_capture_objective",
				"penetration_shots",
				"score",
				"perk_bulletflinch_kills",
				"perk_earnmoremomentum_earn_streak",
				"perk_fastmantle_kills",
				"perk_fastweaponswitch_kill_after_swap",
				"perk_flak_survive",
				"perk_gpsjammer_immune_kills",
				"perk_hacker_destroy",
				"perk_immune_cuav_kills",
				"perk_longersprint",
				"perk_loudenemies_kills",
				"perk_movefaster_kills",
				"perk_noname_kills",
				"perk_nottargetedbyairsupport_destroy_aircraft",
				"perk_protection_stun_kills",
				"perk_quieter_kills",
				"perk_scavenger_kills_after_resupply",
				"pistolheadshot_10_onegame",
				"precision_master",
				"primary_mastery",
				"kills",
				"deaths",
				"plants",
				"protect_streak_with_trophy",
				"reload_then_kill_dualclip",
				"return_fire_killstreak_mastery",
				"returns",
				"revives",
				"sas_gamemode_mastery",
				"score_hc",
				"score_multiteam",
				"score_streaks_mastery",
				"sd_gamemode_mastery",
				"secondary_mastery",
				"shock_enemy_then_stab_them",
				"shoot_aircraft",
				"shoot_down_helicopter",
				"shoot_down_sentinel",
				"shotgun_mastery",
				"shrp_gamemode_mastery",
				"smg_mastery",
				"sniper_mastery",
				"specialist_transmissions",
				"stick_explosive_kill_5_onegame",
				"streaker",
				"stun_aitank_with_emp_grenade",
				"suicides",
				"support_killstreak_mastery",
				"survive_claymore_kill_planter_flak_jacket_equipped",
				"survive_with_flak",
				"tdm_gamemode_mastery",
				"teamkills",
				"teamkills_nostats",
				"throws",
				"ties",
				"time_played_alive",
				"time_played_allies",
				"time_played_axis",
				"time_played_opfor",
				"time_played_other",
				"time_played_team3",
				"time_played_total",
				"top3",
				"top3any",
				"top3any_hc",
				"top3any_multiteam",
				"top3team",
				"topplayer",
				"total_shots",
				"triple_kill_defenders_and_capture",
				"weapons_mastery",
				"weekly_timestamp",
				"wins",
				"wins_hc",
				"wins_multiteam",
				"mantle_then_kill",
				"longshot_3_onelife",
				"losses",
				"long_shot_longbarrel_suppressor_optic",
				"long_distance_hatchet_kill",
				"lmg_mastery",
				"lifetime_earnings",
				"lifetime_buyin",
				"last_escrow",
				"koth_gamemode_mastery",
				"killstreak_5_with_sentry_gun",
				"killstreak_5_with_death_machine",
				"killstreak_5_picked_up_weapon",
				"killstreak_5_dogs",
				"killstreak_30_no_scorestreaks",
				"killstreak_10_no_weapons_perks",
				"killsdenied",
				"killsconfirmed",
				"killsasflagcarrier",
				"kills_suppressor_ghost_hardwired_blastsuppressor",
				"kills_sprinting_dual_wield_and_gung_ho",
				"kills_pistol_lasersight_suppressor_longbarrel",
				"kills_one_life_fastmags_and_extclip",
				"kills_hipfire_rapidfire_lasersights_fasthands",
				"kills_first_throw_both_hatchets",
				"kills_extclip_grip_fastmag_quickdraw_stock",
				"kills_double_kill_3_lethal",
				"kills_counteruav_emp_hardline",
				"kills_auto_turret_5",
				"kills_after_reload_fastreload",
				"kills_after_jumping_or_sliding",
				"kills_ads_stock_and_cpu",
				"kills_ads_quickdraw_and_grip",
				"kills_3_resupplied_nade_one_life",
				"killed_raps_assist",
				"killed_raps",
				"killed_dog_close_to_teammate",
				"killed_dog",
				"kill_with_tossed_back_lethal",
				"kill_with_thermal_and_smoke_ads",
				"kill_with_specialist_overclock",
				"kill_with_resupplied_lethal_grenade",
				"kill_with_remote_control_sentry_gun",
				"kill_with_remote_control_ai_tank",
				"kill_with_pickup",
				"kill_with_loadout_weapon_with_3_attachments",
				"kill_with_hacked_claymore",
				"kill_with_hacked_carepackage",
				"kill_with_gunfighter",
				"kill_with_dual_lethal_grenades",
				"kill_with_cooked_grenade",
				"kill_with_controlled_sentinel",
				"kill_with_controlled_ai_tank",
				"kill_with_claymore",
				"kill_with_c4",
				"kill_with_both_primary_weapons",
				"kill_with_2_perks_same_category",
				"kill_while_wallrunning_2_walls",
				"kill_while_wallrunning",
				"kill_while_underwater",
				"kill_while_uav_active",
				"kill_while_sliding_from_doublejump",
				"kill_while_sliding",
				"kill_while_satellite_active",
				"kill_while_mantling",
				"kill_while_in_air",
				"kill_while_emp_active",
				"kill_while_damaging_with_microwave_turret",
				"kill_while_cuav_active",
				"kill_wallrunner_or_air_with_rcbomb",
				"kill_uav_enemy_with_ghost",
				"kill_trip_mine_shocked",
				"kill_tracker_sixthsense",
				"kill_stunned_tacmask",
				"kill_stun_lethal",
				"kill_sprint_stunned_gungho_tac",
				"kill_specialist_with_specialist",
				"kill_sixthsense_awareness",
				"kill_shocked_enemy",
				"kill_scavenger_tracker_resupply",
				"kill_prone_enemy",
				"kill_primary_and_secondary",
				"kill_overkill_gunfighter_5_attachments",
				"kill_overclock_afterburner_specialist_weapon_after_thrust",
				"kill_nemesis",
				"kill_optic_5_attachments",
				"kill_near_plant_engineer_hardwired",
				"kill_hip_gung_ho",
				"kill_hardwired_coldblooded",
				"kill_flashed_enemy",
				"kill_flak_tac_while_stunned",
				"kill_flak_tac_while_stunned",
				"kill_every_enemy",
				"kill_entire_team_with_specialist_weapon",
				"kill_enemy_withcar",
				"kill_enemy_with_tacknife",
				"kill_enemy_with_picked_up_weapon",
				"kill_enemy_with_fists",
				"kill_enemy_who_shocked_you",
				"kill_enemy_who_damaged_robot",
				"kill_enemy_while_prone",
				"kill_enemy_while_crouched",
				"kill_enemy_through_wall_with_fmj",
				"kill_enemy_through_wall",
				"kill_enemy_thats_wallrunning",
				"kill_enemy_that_in_air",
				"kill_enemy_that_blinded_you",
				"kill_enemy_survive_flak",
				"kill_enemy_sixth_sense",
				"kill_enemy_shoot_their_explosive",
				"kill_enemy_revealed_by_sensor",
				"kill_enemy_one_bullet_sniper",
				"kill_enemy_one_bullet_shotgun",
				"kill_enemy_locking_on_with_chopper_gunner",
				"kill_enemy_5_teammates_assists",
				"kill_doublejump_uav_engineer_hardwired",
				"kill_detect_tracker",
				"kill_dead_silence",
				"kill_crossbow_stackfire",
				"kill_concussed_enemy",
				"kill_close_deadsilence_awareness",
				"kill_close_blast_deadsilence",
				"kill_carrier",
				"kill_booby_trap_engineer",
				"kill_blindeye_ghost_aircraft",
				"kill_blast_doublejump",
				"kill_before_specialist_weapon_use",
				"kill_awareness",
				"kill_attacker_with_robot_or_tank",
				"kill_as_support_gunner",
				"kill_anteup_overclock_scorestreak_specialist",
				"kill_after_tac_insert",
				"kill_after_resupply",
				"kill_after_doublejump_out_of_water",
				"kill_2_wildcards",
				"kill_2_greed_2_perks_each",
				"kill_2_attackers_with_comlink",
				"kill_15_with_blade",
				"kill_10_enemy_one_bullet_sniper_onegame",
				"humiliate_victim",
				"kill_10_enemy_one_bullet_shotgun_onegame",
				"humiliate_attacker",
				"hq_gamemode_mastery",
				"holdingteamdefenderflag",
				"hits",
				"highlights_created",
				"hero_weapon_mastery",
				"hero_transmissions",
				"headshots",
				"headshot_fmj_highcaliber_longbarrel",
				"headshot_assault_5_onegame",
				"hatchet_kill_with_shield_equiped",
				"hasprestiged",
				"hasclantag",
				"hack_streak_with_blindeye_or_engineer",
				"hack_gamemode_mastery",
				"hack_enemy_target",
				"gun_gamemode_mastery",
				"ground_assault_killstreak_mastery",
				"gold_club",
				"get_final_kill",
				"game_modes_mastery",
				"flagcarrierkills",
				"films_shoutcasted",
				"field_specialist",
				"escorts",
				"end_enemy_specialist_ability_with_emp",
				"emblem_version",
				"earn_scorestreak_anteup",
				"earn_5_scorestreaks_anteup",
				"dr_lung",
				"double_kill_defenders",
				"double_kill_attackers",
				"dom_gamemode_mastery",
				"dm_gamemode_mastery",
				"disarm_hacked_carepackage",
				"disables",
				"diamond_club",
				"destructions",
				"destroyed_qrdrone_with_bullet",
				"destroyed_helicopter_with_bullet",
				"destroy_turret",
				"destroy_scorestreak_with_specialist",
				"destroy_scorestreak_with_dart",
				"destroy_scorestreak_rapidfire_fmj",
				"destroy_score_streak_with_qrdrone",
				"destroy_rcbomb_with_hatchet",
				"destroy_raps_before_drop",
				"destroy_qrdrone",
				"destroy_helicopter",
				"destroy_hcxd_with_hatchet",
				"destroy_explosive_with_trophy",
				"destroy_explosive",
				"destroy_equipment_with_emp_grenade",
				"destroy_equipment_with_emp_engineer",
				"destroy_equipment_engineer",
				"destroy_equipment",
				"destroy_combat_robot",
				"destroy_car",
				"destroy_aircraft_with_missile_drone",
				"destroy_aircraft_with_emp",
				"destroy_aircraft",
				"destroy_air_and_ground_blindeye_coldblooded",
				"destroy_ai_scorestreak_coldblooded",
				"destroy_ai_aircraft_using_blindeye",
				"destroy_5_tactical_inserts",
				"dem_gamemode_mastery",
				"defuses",
				"defused_bomb_last_man_alive",
				"defends",
				"defend_teammate_who_captured_package",
				"defend_hq_last_man_alive",
				"defend_carrier",
				"death_dodger",
				"currencyspent",
				"ctf_gamemode_mastery",
				"contracts_xp_earned",
				"contracts_purchased",
				"contracts_cp_spent",
				"contracts_cp_earned",
				"contracts_completed",
				"conf_gamemode_mastery",
				"completed_all_challenges",
				"complete_all_career_ops",
				"complete_all_career_combat_ops",
				"codpoints",
				"carries",
				"career_score_multiteam",
				"career_score_hc",
				"career_score",
				"captures",
				"capture_objective_tactician",
				"capture_objective_in_smoke",
				"capture_enemy_carepackage",
				"call_in_3_care_packages",
				"boot_camp_graduate",
				"assists",
				"assist_score_uav",
				"assist_score_satellite",
				"assist_score_microwave_turret",
				"assist_score_killstreak",
				"assist_score_emp",
				"assist_score_cuav",
				"assist_score",
				"assist",
				"assignments_mastery",
				"assault_rifle_mastery",
				"all_diamond_weapons",
				"air_assault_killstreak_mastery",
				"activate_cuav_while_enemy_satelite_active",
				"melee",
				"misc_bonus",
				"monthly_timestamp",
				"match_bonus",
				"maxxp"
			};
			this.bool_0 = false;
			this.PlayerLevel = 3324845279U;
			this.Souls = 3324845307U;
			this.Vigor = 3324845077U;
			this.Endurance = 3324845079U;
			this.Vitality = 3324845081U;
			this.Attunement = 3324845083U;
			this.Strength = 3324845085U;
			this.Dexterity = 3324845087U;
			this.Intelligence = 3324845089U;
			this.Adaptability = 3324845093U;
			this.Faith = 3324845091U;
			this.healthstuff = new uint[]
			{
				3260816936U,
				3260839064U,
				3260881624U,
				3260903752U,
				3260925880U,
				3260946312U,
				3260968440U,
				3260990568U,
				3261011000U,
				3261033128U,
				3261055256U,
				3261119944U
			};

			this.icontainer_0 = null;
			this.InitializeComponent();
			this.listBox7.MouseDoubleClick += this.listBox7_MouseDoubleClick;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0001D120 File Offset: 0x0001B320
		private void listBox7_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.simpleButton47_Click(sender, null);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0001D138 File Offset: 0x0001B338
		

		// Token: 0x060000BE RID: 190 RVA: 0x0001D244 File Offset: 0x0001B444
		private void Form1_Load(object sender, EventArgs e)
		{
			new Form1();
			this.timer_0.Interval = 30000;
			if (!this.ixboxConsole_0.Connect(out this.ixboxConsole_0, "default"))
			{
				XtraMessageBox.Show("Failed to establish a connection to your console, the tool will load disconnected.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				try
				{
					File.Delete("./temp.ini");
					if (!(this.ini_0.Read("Settings", "CustomConnectionXnotifyStatus") == "Enabled"))
					{
						this.ixboxConsole_0.XNotify("Welcome, " + "Hakka" + "Guido's Console Tool Successfully Connected!\n                 Cracked By Academician#7754");
					}
					else
					{
						this.ixboxConsole_0.XNotify(this.ini_0.Read("Settings", "CustomConnectionXnotifyMessage"));
					}
					this.labelControl2.Text = "Connected!";
					this.labelControl2.ForeColor = System.Drawing.Color.Green;
					if (!(this.ini_0.Read("Settings", "HidePrivateInfo") == "Enabled"))
					{
						if (!(this.ini_0.Read("Settings", "XDKMode") == "Enabled"))
						{
							this.textEdit5.Text = "CPUKey : " + this.ixboxConsole_0.GetCPUKey();
							this.textEdit1.Text = "Kernel : " + this.ixboxConsole_0.GetKernalVersion().ToString();
							this.textEdit2.Text = "Connected To Xbox Live : " + this.XblCheck();
							this.textEdit_3.Text = "Console IP : " + this.ixboxConsole_0.XboxIP();
							this.textEdit9.Text = "Motherboard Type : " + this.ixboxConsole_0.ConsoleType();
							this.textEdit8.Text = "CPU Temperature : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.CPU).ToString();
							this.textEdit7.Text = "Motherboard Temperature : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.MotherBoard).ToString();
							this.textEdit6.Text = "GPU Temperature : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.GPU).ToString();
							this.textEdit3.Text = "Current Title ID : " + this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X");
							this.textEdit4.Text = "Gamertag: " + Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]);
							this.textEdit_147.Text = this.ixboxConsole_0.DebugTarget.RunningProcessInfo.ProgramName.Replace("\\Device\\Harddisk0\\Partition1", "Hdd:");
						}
						else
						{
							this.textEdit5.Text = "CPUKey : " + this.ixboxConsole_0.GetCPUKey();
							this.textEdit1.Text = "Kernel : " + this.ixboxConsole_0.GetKernalVersion().ToString();
							this.textEdit2.Text = "Connected To Xbox Live : XDK Mode";
							this.textEdit_3.Text = "Console IP : " + this.ixboxConsole_0.XboxIP();
							this.textEdit9.Text = "Motherboard Type : " + this.ixboxConsole_0.ConsoleType();
							this.textEdit8.Text = "CPU Temperature : XDK Mode";
							this.textEdit7.Text = "Motherboard Temperature : XDK Mode";
							this.textEdit6.Text = "GPU Temperature : XDK Mode";
							this.textEdit3.Text = "Current Title ID : XDK Mode";
							this.textEdit4.Text = "Gamertag: XDK Mode";
							this.textEdit_147.Text = this.ixboxConsole_0.DebugTarget.RunningProcessInfo.ProgramName.Replace("\\Device\\Harddisk0\\Partition1", "Hdd:");
						}
					}
					else if (!(this.ini_0.Read("Settings", "XDKMode") == "Enabled"))
					{
						this.textEdit5.Text = "CPUKey : Hidden";
						this.textEdit1.Text = "Kernel : " + this.ixboxConsole_0.GetKernalVersion().ToString();
						this.textEdit2.Text = "Connected To Xbox Live : " + this.XblCheck();
						this.textEdit_3.Text = "Console IP : " + this.ixboxConsole_0.XboxIP();
						this.textEdit9.Text = "Motherboard Type : " + this.ixboxConsole_0.ConsoleType();
						this.textEdit8.Text = "CPU Temperature : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.CPU).ToString();
						this.textEdit7.Text = "Motherboard Temperature : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.MotherBoard).ToString();
						this.textEdit6.Text = "GPU Temperature : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.GPU).ToString();
						this.textEdit3.Text = "Current Title ID : " + this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X");
						this.textEdit4.Text = "Gamertag: " + Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]);
						this.textEdit_147.Text = this.ixboxConsole_0.DebugTarget.RunningProcessInfo.ProgramName.Replace("\\Device\\Harddisk0\\Partition1", "Hdd:");
					}
					else
					{
						this.textEdit5.Text = "CPUKey : Hidden";
						this.textEdit1.Text = "Kernel : " + this.ixboxConsole_0.GetKernalVersion().ToString();
						this.textEdit2.Text = "Connected To Xbox Live : XDK Mode";
						this.textEdit_3.Text = "Console IP : " + this.ixboxConsole_0.XboxIP();
						this.textEdit9.Text = "Motherboard Type : " + this.ixboxConsole_0.ConsoleType();
						this.textEdit8.Text = "CPU Temperature : XDK Mode";
						this.textEdit7.Text = "Motherboard Temperature : XDK Mode";
						this.textEdit6.Text = "GPU Temperature : XDK Mode";
						this.textEdit3.Text = "Current Title ID : XDK Mode";
						this.textEdit4.Text = "Gamertag: XDK Mode";
						this.textEdit_147.Text = this.ixboxConsole_0.DebugTarget.RunningProcessInfo.ProgramName.Replace("\\Device\\Harddisk0\\Partition1", "Hdd:");
					}
					if (this.ini_0.Read("Settings", "HidePrivateInfo") == "Enabled")
					{
						this.simpleButton5.Text = "Show CPUKey";
					}
					if (this.ini_0.Read("Settings", "DiscordRPC") == "Disabled")
					{
						this.discordRpcClient_0.Deinitialize();
					}
					if (this.ini_0.Read("Settings", "Scrollerbars") == "Enabled")
					{
					}
				}
				catch (Exception)
				{
				}
				this.ixboxConsole_0.DebugTarget.ConnectAsDebugger(null, XboxDebugConnectFlags.Force);
			}
			if (File.Exists("./temp.ini"))
			{
				File.Delete("./temp.ini");
			}
			File.AppendAllText("GameNames.txt", "");
			try
			{
				foreach (string text in this.ixboxConsole_0.Drives.Split(new char[]
				{
					",".Last<char>()
				}))
				{
					if (text.Contains("DVD"))
					{
						this.listBox7.Items.Add("Launch Game From Disc");
					}
				}
			}
			catch (Exception)
			{
			}
			ListBox.ObjectCollection items = this.listBox7.Items;
			object[] items2 = File.ReadAllLines("GameNames.txt");
			items.AddRange(items2);
			string text2 = Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "";
			this.textEdit_4.Text = text2;
			this.textEdit_29.Text = text2;
			this.textEdit_32.Text = text2;
			this.textEdit_36.Text = text2;
			this.textEdit_34.Text = text2;
			this.textEdit_39.Text = text2;
			this.textEdit_72.Text = text2;
			this.textEdit_70.Text = text2;
			this.textEdit_68.Text = text2;
			this.textEdit_66.Text = text2;
			this.textEdit_74.Text = text2;
			this.textEdit_152.Text = text2;
			this.textEdit_174.Text = text2;
			this.textEdit_181.Text = text2;
			this.textEdit_183.Text = text2;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0001DBAC File Offset: 0x0001BDAC
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			try
			{
				this.ixboxConsole_0.CloseConnection(1U);
			}
			catch
			{
			}
			Application.Exit();
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0001DBE0 File Offset: 0x0001BDE0
		private void simpleButton38_Click(object sender, EventArgs e)
		{
			ScreenshotTool screenshotTool = new ScreenshotTool();
			screenshotTool.Show();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0001DBFC File Offset: 0x0001BDFC
		private void simpleButton39_Click(object sender, EventArgs e)
		{
			ModuleConfigTool moduleConfigTool = new ModuleConfigTool();
			moduleConfigTool.Show();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0001DC18 File Offset: 0x0001BE18
		private void simpleButton41_Click(object sender, EventArgs e)
		{
			ModuleLibTool moduleLibTool = new ModuleLibTool();
			moduleLibTool.Show();
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0001DC34 File Offset: 0x0001BE34
		private void simpleButton40_Click(object sender, EventArgs e)
		{
			INIEditorTool inieditorTool = new INIEditorTool();
			inieditorTool.Show();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0001DC50 File Offset: 0x0001BE50
		private void simpleButton45_Click(object sender, EventArgs e)
		{
			DashEditor dashEditor = new DashEditor();
			dashEditor.Show();
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0001DC6C File Offset: 0x0001BE6C
		private void simpleButton44_Click(object sender, EventArgs e)
		{
			CmdTool cmdTool = new CmdTool();
			cmdTool.Show();
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0001DC88 File Offset: 0x0001BE88
		private void simpleButton42_Click(object sender, EventArgs e)
		{
			FileBrowser fileBrowser = new FileBrowser();
			fileBrowser.Show();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0001DCA4 File Offset: 0x0001BEA4
		private void simpleButton43_Click(object sender, EventArgs e)
		{
			DevTools devTools = new DevTools();
			devTools.Show();
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0001DCC0 File Offset: 0x0001BEC0
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (this.labelControl2.Text == "Connected!")
			{
				this.ixboxConsole_0.XNotify("Oh lord you got the easteregg, open your Xbox Guide!");
				this.ixboxConsole_0.SetMemory(2436932881U, Encoding.ASCII.GetBytes("AcademicianWasHere"));
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0001DD14 File Offset: 0x0001BF14
		private void simpleButton1_Click(object sender, EventArgs e)
		{
			if (this.ixboxConsole_0.Connect(out this.ixboxConsole_0, "default"))
			{
				if (!(this.ini_0.Read("Settings", "CustomConnectionXnotifyStatus") == "Enabled"))
				{
					this.ixboxConsole_0.XNotify("Welcome," + "Hakka" + "Guido's Console Tool Successfully Connected!\n                 Cracked By Academician#7754");
				}
				else
				{
					this.ixboxConsole_0.XNotify(this.ini_0.Read("Settings", "CustomConnectionXnotifyMessage"));
				}
				this.labelControl2.Text = "Connected!";
				this.labelControl2.ForeColor = System.Drawing.Color.Green;
				if (this.ini_0.Read("Settings", "HidePrivateInfo") == "Enabled")
				{
					if (!(this.ini_0.Read("Settings", "XDKMode") == "Enabled"))
					{
						this.textEdit5.Text = "CPUKey : Hidden";
						this.textEdit1.Text = "Kernel : " + this.ixboxConsole_0.GetKernalVersion().ToString();
						this.textEdit2.Text = "Connected To Xbox Live : " + this.XblCheck();
						this.textEdit_3.Text = "Console IP : " + this.ixboxConsole_0.XboxIP();
						this.textEdit9.Text = "Motherboard Type : " + this.ixboxConsole_0.ConsoleType();
						this.textEdit8.Text = "CPU Temperature : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.CPU).ToString();
						this.textEdit7.Text = "Motherboard Temperature : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.MotherBoard).ToString();
						this.textEdit6.Text = "GPU Temperature : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.GPU).ToString();
						this.textEdit3.Text = "Current Title ID : " + this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X");
						this.textEdit4.Text = "Gamertag: " + Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]);
						this.textEdit_147.Text = this.ixboxConsole_0.DebugTarget.RunningProcessInfo.ProgramName.Replace("\\Device\\Harddisk0\\Partition1", "Hdd:");
					}
					else
					{
						this.textEdit5.Text = "CPUKey : Hidden";
						this.textEdit1.Text = "Kernel : " + this.ixboxConsole_0.GetKernalVersion().ToString();
						this.textEdit2.Text = "Connected To Xbox Live : XDK Mode";
						this.textEdit_3.Text = "Console IP : " + this.ixboxConsole_0.XboxIP();
						this.textEdit9.Text = "Motherboard Type : " + this.ixboxConsole_0.ConsoleType();
						this.textEdit8.Text = "CPU Temperature : XDK Mode";
						this.textEdit7.Text = "Motherboard Temperature : XDK Mode";
						this.textEdit6.Text = "GPU Temperature : XDK Mode";
						this.textEdit3.Text = "Current Title ID : XDK Mode";
						this.textEdit4.Text = "Gamertag: XDK Mode";
						this.textEdit_147.Text = this.ixboxConsole_0.DebugTarget.RunningProcessInfo.ProgramName.Replace("\\Device\\Harddisk0\\Partition1", "Hdd:");
					}
				}
				else if (!(this.ini_0.Read("Settings", "XDKMode") == "Enabled"))
				{
					this.textEdit5.Text = "CPUKey : " + this.ixboxConsole_0.GetCPUKey();
					this.textEdit1.Text = "Kernel : " + this.ixboxConsole_0.GetKernalVersion().ToString();
					this.textEdit2.Text = "Connected To Xbox Live : " + this.XblCheck();
					this.textEdit_3.Text = "Console IP : " + this.ixboxConsole_0.XboxIP();
					this.textEdit9.Text = "Motherboard Type : " + this.ixboxConsole_0.ConsoleType();
					this.textEdit8.Text = "CPU Temperature : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.CPU).ToString();
					this.textEdit7.Text = "Motherboard Temperature : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.MotherBoard).ToString();
					this.textEdit6.Text = "GPU Temperature : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.GPU).ToString();
					this.textEdit3.Text = "Current Title ID : " + this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X");
					this.textEdit4.Text = "Gamertag: " + Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]);
					this.textEdit_147.Text = this.ixboxConsole_0.DebugTarget.RunningProcessInfo.ProgramName.Replace("\\Device\\Harddisk0\\Partition1", "Hdd:");
				}
				else
				{
					this.textEdit5.Text = "CPUKey : " + this.ixboxConsole_0.GetCPUKey();
					this.textEdit1.Text = "Kernel : " + this.ixboxConsole_0.GetKernalVersion().ToString();
					this.textEdit2.Text = "Connected To Xbox Live : XDK Mode";
					this.textEdit_3.Text = "Console IP : " + this.ixboxConsole_0.XboxIP();
					this.textEdit9.Text = "Motherboard Type : " + this.ixboxConsole_0.ConsoleType();
					this.textEdit8.Text = "CPU Temperature : XDK Mode";
					this.textEdit7.Text = "Motherboard Temperature : XDK Mode";
					this.textEdit6.Text = "GPU Temperature : XDK Mode";
					this.textEdit3.Text = "Current Title ID : XDK Mode";
					this.textEdit4.Text = "Gamertag: XDK Mode";
					this.textEdit_147.Text = this.ixboxConsole_0.DebugTarget.RunningProcessInfo.ProgramName.Replace("\\Device\\Harddisk0\\Partition1", "Hdd:");
				}
			}
			else
			{
				XtraMessageBox.Show("Failed to establish a connection to your console, the tool will load disconnected.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0001E3E0 File Offset: 0x0001C5E0
		public string XblCheck()
		{
			uint num = this.ixboxConsole_0.Call<uint>(2171219848U, new object[]
			{
				252,
				360451U,
				0,
				0
			});
			if (num == 1380593U)
			{
				this.string_0 = "False";
			}
			else
			{
				this.string_0 = "True";
			}
			return this.string_0;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0001E460 File Offset: 0x0001C660
		private void simpleButton3_Click(object sender, EventArgs e)
		{
			new Form1();
			if (!(this.ini_0.Read("Settings", "HidePrivateInfo") == "Enabled"))
			{
				if (this.ini_0.Read("Settings", "XDKMode") == "Enabled")
				{
					this.textEdit5.Text = "CPUKey : " + this.ixboxConsole_0.GetCPUKey();
					this.textEdit2.Text = "Connected To Xbox Live : XDK Mode";
					this.textEdit_3.Text = "Console IP : " + this.ixboxConsole_0.XboxIP();
					this.textEdit9.Text = "Motherboard Type : " + this.ixboxConsole_0.ConsoleType();
					this.textEdit8.Text = "CPU Temperature : XDK Mode";
					this.textEdit7.Text = "Motherboard Temperature : XDK Mode";
					this.textEdit6.Text = "GPU Temperature : XDK Mode";
					this.textEdit3.Text = "Current Title ID : XDK Mode";
					this.textEdit4.Text = "Gamertag: XDK Mode";
					this.textEdit_147.Text = this.ixboxConsole_0.DebugTarget.RunningProcessInfo.ProgramName.Replace("\\Device\\Harddisk0\\Partition1", "Hdd:");
				}
				else
				{
					this.textEdit5.Text = "CPUKey : " + this.ixboxConsole_0.GetCPUKey();
					this.textEdit2.Text = "Connected To Xbox Live : " + this.XblCheck();
					this.textEdit_3.Text = "Console IP : " + this.ixboxConsole_0.XboxIP();
					this.textEdit9.Text = "Motherboard Type : " + this.ixboxConsole_0.ConsoleType();
					this.textEdit8.Text = "CPU Temperature : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.CPU).ToString();
					this.textEdit7.Text = "Motherboard Temperature : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.MotherBoard).ToString();
					this.textEdit6.Text = "GPU Temperature : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.GPU).ToString();
					this.textEdit3.Text = "Current Title ID : " + this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X");
					this.textEdit4.Text = "Gamertag: " + Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]);
					this.textEdit_147.Text = this.ixboxConsole_0.DebugTarget.RunningProcessInfo.ProgramName.Replace("\\Device\\Harddisk0\\Partition1", "Hdd:");
				}
			}
			else if (this.ini_0.Read("Settings", "XDKMode") == "Enabled")
			{
				this.textEdit5.Text = "CPUKey : Hidden";
				this.textEdit1.Text = "Kernel : " + this.ixboxConsole_0.GetKernalVersion().ToString();
				this.textEdit2.Text = "Connected To Xbox Live : XDK Mode";
				this.textEdit_3.Text = "Console IP : " + this.ixboxConsole_0.XboxIP();
				this.textEdit9.Text = "Motherboard Type : " + this.ixboxConsole_0.ConsoleType();
				this.textEdit8.Text = "CPU Temperature : XDK Mode";
				this.textEdit7.Text = "Motherboard Temperature : XDK Mode";
				this.textEdit6.Text = "GPU Temperature : XDK Mode";
				this.textEdit3.Text = "Current Title ID : XDK Mode";
				this.textEdit4.Text = "Gamertag: XDK Mode";
				this.textEdit_147.Text = this.ixboxConsole_0.DebugTarget.RunningProcessInfo.ProgramName.Replace("\\Device\\Harddisk0\\Partition1", "Hdd:");
			}
			else
			{
				this.textEdit5.Text = "CPUKey : Hidden";
				this.textEdit1.Text = "Kernel : " + this.ixboxConsole_0.GetKernalVersion().ToString();
				this.textEdit2.Text = "Connected To Xbox Live : " + this.XblCheck();
				this.textEdit_3.Text = "Console IP : " + this.ixboxConsole_0.XboxIP();
				this.textEdit9.Text = "Motherboard Type : " + this.ixboxConsole_0.ConsoleType();
				this.textEdit8.Text = "CPU Temperature : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.CPU).ToString();
				this.textEdit7.Text = "Motherboard Temperature : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.MotherBoard).ToString();
				this.textEdit6.Text = "GPU Temperature : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.GPU).ToString();
				this.textEdit3.Text = "Current Title ID : " + this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X");
				this.textEdit4.Text = "Gamertag: " + Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]);
				this.textEdit_147.Text = this.ixboxConsole_0.DebugTarget.RunningProcessInfo.ProgramName.Replace("\\Device\\Harddisk0\\Partition1", "Hdd:");
			}
			string text = Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "";
			this.textEdit_4.Text = text;
			this.textEdit_29.Text = text;
			this.textEdit_32.Text = text;
			this.textEdit_36.Text = text;
			this.textEdit_34.Text = text;
			this.textEdit_39.Text = text;
			this.textEdit_72.Text = text;
			this.textEdit_70.Text = text;
			this.textEdit_68.Text = text;
			this.textEdit_66.Text = text;
			this.textEdit_74.Text = text;
			this.textEdit_152.Text = text;
			this.textEdit_174.Text = text;
			this.textEdit_181.Text = text;
			this.textEdit_183.Text = text;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0001EB28 File Offset: 0x0001CD28
		private void simpleButton2_Click(object sender, EventArgs e)
		{
			if (this.ini_0.Read("Settings", "XDKMode") == "Enabled")
			{
				XtraMessageBox.Show("This option is disabled while using XDK Mode.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				string localName = Path.GetDirectoryName(Application.ExecutablePath) + "/temp.ini";
				if (!(this.labelControl3.Text == "Not Connected!"))
				{
					try
					{
						this.ixboxConsole_0.ReceiveFile(localName, "Hdd:\\launch.ini");
					}
					catch
					{
						this.ixboxConsole_0.ReceiveFile(localName, "Usb:\\launch.ini");
					}
					string text = "Plugin 1: " + this.ini_1.Read("Plugins", "plugin1");
					string text2 = "Plugin 2: " + this.ini_1.Read("Plugins", "plugin2");
					string text3 = "Plugin 3: " + this.ini_1.Read("Plugins", "plugin3");
					string text4 = "Plugin 4: " + this.ini_1.Read("Plugins", "plugin4");
					string text5 = "Plugin 5: " + this.ini_1.Read("Plugins", "plugin5");
					string text6 = Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "";
					File.WriteAllText("ConsoleInformation.txt", string.Concat(new string[]
					{
						this.textEdit5.Text,
						Environment.NewLine,
						this.textEdit1.Text,
						Environment.NewLine,
						this.textEdit2.Text,
						Environment.NewLine,
						this.textEdit_3.Text,
						Environment.NewLine,
						this.textEdit9.Text,
						Environment.NewLine,
						this.textEdit8.Text,
						Environment.NewLine,
						this.textEdit7.Text,
						Environment.NewLine,
						this.textEdit6.Text,
						Environment.NewLine,
						this.textEdit3.Text,
						Environment.NewLine,
						this.textEdit_147.Text,
						Environment.NewLine,
						"Gamertag: ",
						text6,
						Environment.NewLine,
						Environment.NewLine,
						"Plugin List:",
						Environment.NewLine,
						text,
						Environment.NewLine,
						text2,
						Environment.NewLine,
						text3,
						Environment.NewLine,
						text4,
						Environment.NewLine,
						text5
					}));
					File.Delete("temp.ini");
					XtraMessageBox.Show("Saved ConsoleInformation.txt to current directory!", base.Name, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					XtraMessageBox.Show("Tool is not connected to RGH!", base.Name, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0001EE5C File Offset: 0x0001D05C
		private void simpleButton5_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton5.Text == "Hide CPUKey"))
			{
				this.simpleButton5.Text = "Hide CPUKey";
				this.textEdit5.Text = "CPUKey : " + this.ixboxConsole_0.GetCPUKey();
			}
			else
			{
				this.simpleButton5.Text = "Show CPUKey";
				this.textEdit5.Text = "CPUKey : Hidden";
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0001EED4 File Offset: 0x0001D0D4
		private void simpleButton4_Click(object sender, EventArgs e)
		{
			Settings settings = new Settings();
			settings.Show();
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0001EEF0 File Offset: 0x0001D0F0
		private byte[] method_0(string string_3)
		{
			byte[] array = new byte[string_3.Length * 2 + 2];
			int num = 1;
			array[0] = 0;
			foreach (char value in string_3)
			{
				array[num] = Convert.ToByte(value);
				num += 2;
			}
			return array;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0001EF54 File Offset: 0x0001D154
		public void method_1(string string_9, string string_10, string string_11)
		{
			uint num = this.ixboxConsole_0.Call<uint>("xam.xex", 1161, new object[]
			{
				255,
				1
			});
			uint num2 = this.ixboxConsole_0.Call<uint>("xam.xex", 1161, new object[]
			{
				1024,
				1
			});
			uint num3 = this.ixboxConsole_0.Call<uint>("xam.xex", 1161, new object[]
			{
				8,
				1
			});
			uint num4 = this.ixboxConsole_0.Call<uint>("xam.xex", 1161, new object[]
			{
				12,
				1
			});
			uint num5 = this.ixboxConsole_0.Call<uint>("xam.xex", 1161, new object[]
			{
				32,
				1
			});
			uint num6 = this.ixboxConsole_0.Call<uint>("xam.xex", 1161, new object[]
			{
				32,
				1
			});
			this.ixboxConsole_0.SetMemory(num, this.method_0(string_9));
			this.ixboxConsole_0.SetMemory(num2, this.method_0(string_10));
			this.ixboxConsole_0.WriteUInt32(num3, num6);
			this.ixboxConsole_0.SetMemory(num6, this.method_0(string_11));
			uint address = this.ixboxConsole_0.ResolveFunction("xam.xex", 714U);
			this.ixboxConsole_0.CallVoid(address, new object[]
			{
				0,
				num,
				num2,
				1,
				num3,
				0,
				2,
				num4,
				num5
			});
			this.ixboxConsole_0.CallVoid("xam.xex", 1163, new object[]
			{
				num,
				1
			});
			this.ixboxConsole_0.CallVoid("xam.xex", 1163, new object[]
			{
				num2,
				1
			});
			this.ixboxConsole_0.CallVoid("xam.xex", 1163, new object[]
			{
				num3,
				1
			});
			this.ixboxConsole_0.CallVoid("xam.xex", 1163, new object[]
			{
				num4,
				1
			});
			this.ixboxConsole_0.CallVoid("xam.xex", 1163, new object[]
			{
				num5,
				1
			});
			this.ixboxConsole_0.CallVoid("xam.xex", 1163, new object[]
			{
				num6,
				1
			});
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0001F268 File Offset: 0x0001D468
		public string GameName()
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1085243771517665400/titleids.txt", "./titleids.txt");
			string[] array = File.ReadAllLines("./titleids.txt");
			foreach (string text in array)
			{
				string[] array3 = text.Split(new char[]
				{
					",".Last<char>()
				});
				string b = array3.First<string>();
				string result = array3[1];
				if (this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X") == b)
				{
					return result;
				}
			}
			File.Delete("./titleids.txt");
			return "Unknown Title";
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0001F320 File Offset: 0x0001D520
		private void simpleButton7_Click(object sender, EventArgs e)
		{
			if (this.ini_0.Read("Settings", "DiscordRPC") == "Disabled")
			{
				DialogResult dialogResult = XtraMessageBox.Show("DiscordRPC is not enabled and it has to be for Game RPC to work, do you want to enable it?", "Warning", MessageBoxButtons.YesNo);
				if (dialogResult != DialogResult.Yes)
				{
					if (dialogResult != DialogResult.No)
					{
					}
				}
				else
				{
					this.ini_0.Write("Settings", "DiscordRPC", "Enabled");
				}
			}
			else if (!(this.simpleButton7.Text == "Enable Discord RPC"))
			{
				this.simpleButton7.Text = "Enable Discord RPC";
				this.ixboxConsole_0.XNotify("Discord Game RPC Disabled!");
				try
				{
					this.discordRpcClient_0.Deinitialize();
				}
				catch (Exception)
				{
				}
				this.simpleButton11.Text = "Hide Gamertag [OFF]";
				this.simpleButton12.Text = "Hide Current Game [OFF]";
			}
			else
			{
				this.simpleButton7.Text = "Disable Discord RPC";
				this.ixboxConsole_0.XNotify("Discord Game RPC Enabled!");
				try
				{
					this.discordRpcClient_0.Initialize();
					this.discordRpcClient_0.SetPresence(new RichPresence
					{
						Details = "Currently Playing : " + this.GameName(),
						State = "Gamertag : " + Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]),
						Timestamps = Timestamps.Now,
						Buttons = new DiscordRPC.Button[]
						{
							new DiscordRPC.Button
							{
								Label = "Website",
								Url = "https://www.youtube.com/watch?v=Oqrm-9Wy8iU"
							},
							new DiscordRPC.Button
							{
								Label = "Discord Server",
								Url = "https://www.youtube.com/watch?v=BBJa32lCaaY"
							}
						}
					});
				}
				catch (Exception)
				{
					XtraMessageBox.Show("Failed to initialize Discord RPC", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0001F520 File Offset: 0x0001D720
		private void timer_1_Tick(object sender, EventArgs e)
		{
			if (this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X") != this.string_1 && this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X") != "0")
			{
				this.string_1 = this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X");
				this.discordRpcClient_0.SetPresence(new RichPresence
				{
					Details = "Currently Playing : " + this.GameName(),
					State = "Gamertag : " + Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]),
					Timestamps = Timestamps.Now,
					Buttons = new DiscordRPC.Button[]
					{
						new DiscordRPC.Button
						{
							Label = "Website",
							Url = "https://www.youtube.com/watch?v=Oqrm-9Wy8iU"
						},
						new DiscordRPC.Button
						{
							Label = "Discord Server",
							Url = "https://www.youtube.com/watch?v=BBJa32lCaaY"
						}
					}
				});
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0001F65C File Offset: 0x0001D85C
		private void simpleButton9_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton9.Text == "Auto Update RPC [OFF]"))
			{
				this.simpleButton9.Text = "Auto Update RPC [OFF]";
				this.string_1 = "";
				this.timer_1.Enabled = false;
			}
			else
			{
				this.simpleButton9.Text = "Auto Update RPC [ON]";
				this.string_1 = this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X");
				this.timer_1.Interval = 5000;
				this.timer_1.Tick += this.timer_1_Tick;
				this.timer_1.Enabled = true;
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0001F70C File Offset: 0x0001D90C
		private void simpleButton8_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton7.Text == "Enable Discord Game RPC"))
			{
				try
				{
					this.discordRpcClient_0.SetPresence(new RichPresence
					{
						Details = "Currently Playing : " + this.GameName(),
						State = "Gamertag : " + Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]),
						Timestamps = Timestamps.Now,
						Buttons = new DiscordRPC.Button[]
						{
							new DiscordRPC.Button
							{
								Label = "Website",
								Url = "https://guidosconsoletool.com"
							},
							new DiscordRPC.Button
							{
								Label = "Discord Server",
								Url = "https://discord.gg/r2TvpbdHU6"
							}
						}
					});
				}
				catch (Exception)
				{
					XtraMessageBox.Show("Failed to initialize Discord RPC", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				this.simpleButton11.Text = "Hide Gamertag [OFF]";
				this.simpleButton12.Text = "Hide Current Game [OFF]";
			}
			else
			{
				XtraMessageBox.Show("Discord Game RPC isn't enabled, do that first.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0001F850 File Offset: 0x0001DA50
		private void simpleButton10_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("This will change your current Tool Discord RPC to show your current title and or your current gamertag. Discord RPC has to be enabled in settings for this.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0001F870 File Offset: 0x0001DA70
		private void simpleButton11_Click(object sender, EventArgs e)
		{
			if (this.simpleButton7.Text == "Enable Discord RPC")
			{
				XtraMessageBox.Show("Discord Game RPC isn't enabled, do that first.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else if (this.simpleButton11.Text == "Hide Gamertag [OFF]")
			{
				this.simpleButton11.Text = "Hide Gamertag [OFF]";
				if (!(this.simpleButton12.Text == "Hide Current Game [OFF]"))
				{
					this.discordRpcClient_0.SetPresence(new RichPresence
					{
						Details = "Currently Playing : " + this.GameName(),
						State = "https://guidosconsoletool.com",
						Timestamps = Timestamps.Now,
						Buttons = new DiscordRPC.Button[]
						{
							new DiscordRPC.Button
							{
								Label = "Website",
								Url = "https://guidosconsoletool.com"
							},
							new DiscordRPC.Button
							{
								Label = "Discord Server",
								Url = "https://discord.gg/r2TvpbdHU6"
							}
						}
					});
				}
				else
				{
					this.discordRpcClient_0.SetPresence(new RichPresence
					{
						Details = "Grinding the tool!",
						State = "https://guidosconsoletool.com",
						Timestamps = Timestamps.Now,
						Buttons = new DiscordRPC.Button[]
						{
							new DiscordRPC.Button
							{
								Label = "Website",
								Url = "https://guidosconsoletool.com"
							},
							new DiscordRPC.Button
							{
								Label = "Discord Server",
								Url = "https://discord.gg/r2TvpbdHU6"
							}
						}
					});
				}
			}
			else
			{
				this.simpleButton11.Text = "Hide Gamertag [OFF]";
				if (!(this.simpleButton12.Text == "Hide Current Game [OFF]"))
				{
					this.discordRpcClient_0.SetPresence(new RichPresence
					{
						Details = "Currently Playing : " + this.GameName(),
						State = "Gamertag : " + Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]),
						Timestamps = Timestamps.Now,
						Buttons = new DiscordRPC.Button[]
						{
							new DiscordRPC.Button
							{
								Label = "Website",
								Url = "https://guidosconsoletool.com"
							},
							new DiscordRPC.Button
							{
								Label = "Discord Server",
								Url = "https://discord.gg/r2TvpbdHU6"
							}
						}
					});
				}
				else
				{
					this.discordRpcClient_0.SetPresence(new RichPresence
					{
						Details = "Grinding the tool!",
						State = "Gamertag : " + Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]),
						Timestamps = Timestamps.Now,
						Buttons = new DiscordRPC.Button[]
						{
							new DiscordRPC.Button
							{
								Label = "Website",
								Url = "https://guidosconsoletool.com"
							},
							new DiscordRPC.Button
							{
								Label = "Discord Server",
								Url = "https://discord.gg/r2TvpbdHU6"
							}
						}
					});
				}
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0001FBA8 File Offset: 0x0001DDA8
		private void simpleButton12_Click(object sender, EventArgs e)
		{
			if (this.simpleButton7.Text == "Enable Discord RPC")
			{
				XtraMessageBox.Show("Discord Game RPC isn't enabled, do that first.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else if (!(this.simpleButton12.Text == "Hide Current Game [OFF]"))
			{
				this.simpleButton12.Text = "Hide Gamertag [OFF]";
				if (!(this.simpleButton11.Text == "Hide Current Game [OFF]"))
				{
					this.discordRpcClient_0.SetPresence(new RichPresence
					{
						Details = "Currently Playing : " + this.GameName(),
						State = "Gamertag : " + Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]),
						Timestamps = Timestamps.Now,
						Buttons = new DiscordRPC.Button[]
						{
							new DiscordRPC.Button
							{
								Label = "Website",
								Url = "https://guidosconsoletool.com"
							},
							new DiscordRPC.Button
							{
								Label = "Discord Server",
								Url = "https://discord.gg/r2TvpbdHU6"
							}
						}
					});
				}
				else
				{
					this.discordRpcClient_0.SetPresence(new RichPresence
					{
						Details = "Currently Playing : " + this.GameName(),
						State = "https://guidosconsoletool.com",
						Timestamps = Timestamps.Now,
						Buttons = new DiscordRPC.Button[]
						{
							new DiscordRPC.Button
							{
								Label = "Website",
								Url = "https://guidosconsoletool.com"
							},
							new DiscordRPC.Button
							{
								Label = "Discord Server",
								Url = "https://discord.gg/r2TvpbdHU6"
							}
						}
					});
				}
			}
			else
			{
				this.simpleButton12.Text = "Hide Gamertag [OFF]";
				if (this.simpleButton11.Text == "Hide Current Game [OFF]")
				{
					this.discordRpcClient_0.SetPresence(new RichPresence
					{
						Details = "Grinding the tool!",
						State = "https://guidosconsoletool.com",
						Timestamps = Timestamps.Now,
						Buttons = new DiscordRPC.Button[]
						{
							new DiscordRPC.Button
							{
								Label = "Website",
								Url = "https://guidosconsoletool.com"
							},
							new DiscordRPC.Button
							{
								Label = "Discord Server",
								Url = "https://discord.gg/r2TvpbdHU6"
							}
						}
					});
				}
				else
				{
					this.discordRpcClient_0.SetPresence(new RichPresence
					{
						Details = "Grinding the tool!",
						State = "Gamertag : " + Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]),
						Timestamps = Timestamps.Now,
						Buttons = new DiscordRPC.Button[]
						{
							new DiscordRPC.Button
							{
								Label = "Website",
								Url = "https://guidosconsoletool.com"
							},
							new DiscordRPC.Button
							{
								Label = "Discord Server",
								Url = "https://discord.gg/r2TvpbdHU6"
							}
						}
					});
				}
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0001FEE0 File Offset: 0x0001E0E0
		private void simpleButton22_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.ShutDownConsole();
			DialogResult dialogResult = XtraMessageBox.Show("Console shut down, do you want to close the tool?", "Console Shutdown", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0001FF18 File Offset: 0x0001E118
		private void simpleButton21_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.Reboot(null, null, null, XboxRebootFlags.Cold);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0001FF34 File Offset: 0x0001E134
		private void simpleButton29_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.Reboot(null, null, null, XboxRebootFlags.Warm);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0001FF50 File Offset: 0x0001E150
		private void simpleButton26_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.Reboot(null, null, null, XboxRebootFlags.Title);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0001FF6C File Offset: 0x0001E16C
		private void simpleButton25_Click(object sender, EventArgs e)
		{
			string programName = this.ixboxConsole_0.DebugTarget.RunningProcessInfo.ProgramName;
			string text = programName.Replace("\\Device\\Harddisk0\\Partition1", "Hdd:");
			string text2 = text;
			int length = text2.LastIndexOf("\\");
			this.ixboxConsole_0.Reboot(text, text.Substring(0, length), null, XboxRebootFlags.Title);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0001FFD0 File Offset: 0x0001E1D0
		private void simpleButton23_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.Reboot(null, null, null, XboxRebootFlags.Stop);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0001FFEC File Offset: 0x0001E1EC
		private void simpleButton24_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.Call<uint>(2175215860U, new object[]
			{
				74568
			});
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00020020 File Offset: 0x0001E220
		private void simpleButton19_Click(object sender, EventArgs e)
		{
			if (!(this.comboBoxEdit20.Text == ""))
			{
				if (this.comboBoxEdit20.SelectedIndex == 0)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 1U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 1)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 2U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 2)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 3U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 3)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 4U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 4)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 5U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 5)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 6U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 6)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 7U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 7)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 8U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 8)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 9U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 9)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 10U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 10)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 11U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 11)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 12U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 12)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 13U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 13)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 14U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 14)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 15U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 15)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 16U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 16)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 18U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 17)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 19U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 18)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 20U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 19)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 21U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 20)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 22U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 21)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text + " ", 27U);
				}
				if (this.comboBoxEdit20.SelectedIndex == 22)
				{
					this.ixboxConsole_0.XNotify(this.textEdit_0.Text, 31U);
				}
			}
			else
			{
				this.ixboxConsole_0.XNotify(this.textEdit_0.Text);
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00020408 File Offset: 0x0001E608
		private void simpleButton18_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.XNotify("Your CPUKey : " + this.ixboxConsole_0.GetCPUKey());
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00020438 File Offset: 0x0001E638
		private void simpleButton17_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.XNotify(DateTime.Now.ToString());
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00020460 File Offset: 0x0001E660
		private void simpleButton16_Click(object sender, EventArgs e)
		{
			string text = new WebClient().DownloadString("https://ipv4.icanhazip.com/").Replace("\\r\\n", "").Replace("\\n", "").Trim();
			this.ixboxConsole_0.XNotify("Your Public Ip Address : " + text.ToString());
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000204C0 File Offset: 0x0001E6C0
		private void simpleButton15_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			this.ixboxConsole_0.XNotify("Guido's Console Tool, https://guidosconsoletool.com, Build Version: " + form.labelControl3.Text);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000204F8 File Offset: 0x0001E6F8
		private void simpleButton20_Click(object sender, EventArgs e)
		{
			this.method_1(this.textEdit_2.Text, this.richTextBox1.Text, this.textEdit_1.Text);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0002052C File Offset: 0x0001E72C
		private void simpleButton13_Click(object sender, EventArgs e)
		{
			this.method_1("Console Banned", "This console has been banned for violations of the Terms of Use. To protect the Xbox LIVE service and its members, Microsoft does not provide details about console bans. There is no recourse of Terms of Use violations.", "OK");
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00020550 File Offset: 0x0001E750
		private void simpleButton14_Click(object sender, EventArgs e)
		{
			this.method_1("Xbox Live", "Sorry, this profile can't connect to Xbox Live on this console. To fix it, download it again.", "OK");
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00020574 File Offset: 0x0001E774
		private void simpleButton27_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton27.Text == "Top Left [OFF]"))
			{
				this.simpleButton27.Text = "Top Left [OFF]";
				this.ixboxConsole_0.SetLeds(JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF);
			}
			else
			{
				this.simpleButton27.Text = "Top Left [ON]";
				this.ixboxConsole_0.SetLeds(JRPC.LEDState.GREEN, JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF);
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000205DC File Offset: 0x0001E7DC
		private void simpleButton30_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton30.Text == "Top Right [OFF]"))
			{
				this.simpleButton30.Text = "Top Right [OFF]";
				this.ixboxConsole_0.SetLeds(JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF);
			}
			else
			{
				this.simpleButton30.Text = "Top Right [ON]";
				this.ixboxConsole_0.SetLeds(JRPC.LEDState.OFF, JRPC.LEDState.GREEN, JRPC.LEDState.OFF, JRPC.LEDState.OFF);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00020644 File Offset: 0x0001E844
		private void simpleButton28_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton28.Text == "Bottom Left [OFF]"))
			{
				this.simpleButton28.Text = "Bottom Left [OFF]";
				this.ixboxConsole_0.SetLeds(JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF);
			}
			else
			{
				this.simpleButton28.Text = "Bottom Left [ON]";
				this.ixboxConsole_0.SetLeds(JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.GREEN, JRPC.LEDState.OFF);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000206AC File Offset: 0x0001E8AC
		private void simpleButton31_Click(object sender, EventArgs e)
		{
			if (this.simpleButton31.Text == "Bottom Right [OFF]")
			{
				this.simpleButton31.Text = "Bottom Right [ON]";
				this.ixboxConsole_0.SetLeds(JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.GREEN);
			}
			else
			{
				this.simpleButton31.Text = "Bottom Right [OFF]";
				this.ixboxConsole_0.SetLeds(JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00020714 File Offset: 0x0001E914
		private void method_2(object sender, ElapsedEventArgs e)
		{
			this.ixboxConsole_0.SetLeds(JRPC.LEDState.GREEN, JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF);
			Thread.Sleep(30);
			this.ixboxConsole_0.SetLeds(JRPC.LEDState.OFF, JRPC.LEDState.GREEN, JRPC.LEDState.OFF, JRPC.LEDState.OFF);
			Thread.Sleep(30);
			this.ixboxConsole_0.SetLeds(JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.GREEN, JRPC.LEDState.OFF);
			Thread.Sleep(30);
			this.ixboxConsole_0.SetLeds(JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.GREEN);
			Thread.Sleep(30);
			this.ixboxConsole_0.SetLeds(JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.GREEN, JRPC.LEDState.OFF);
			Thread.Sleep(30);
			this.ixboxConsole_0.SetLeds(JRPC.LEDState.OFF, JRPC.LEDState.GREEN, JRPC.LEDState.OFF, JRPC.LEDState.OFF);
			Thread.Sleep(30);
			this.ixboxConsole_0.SetLeds(JRPC.LEDState.GREEN, JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF);
			Thread.Sleep(30);
			this.ixboxConsole_0.SetLeds(JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF);
			Thread.Sleep(30);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000207F0 File Offset: 0x0001E9F0
		private void simpleButton32_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			Form1.timer7.Elapsed += this.method_2;
			Form1.timer7.AutoReset = true;
			Form1.timer7.Enabled = this.TimerEnabled;
			this.simpleButton32.Text = ((!this.TimerEnabled) ? "Disco [OFF]" : "Disco [ON]");
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0002085C File Offset: 0x0001EA5C
		private void method_3(object sender, ElapsedEventArgs e)
		{
			this.ixboxConsole_0.SetLeds(JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF);
			Thread.Sleep(30);
			this.ixboxConsole_0.SetLeds(JRPC.LEDState.GREEN, JRPC.LEDState.GREEN, JRPC.LEDState.GREEN, JRPC.LEDState.GREEN);
			Thread.Sleep(30);
			this.ixboxConsole_0.SetLeds(JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF);
			Thread.Sleep(30);
			this.ixboxConsole_0.SetLeds(JRPC.LEDState.GREEN, JRPC.LEDState.GREEN, JRPC.LEDState.GREEN, JRPC.LEDState.GREEN);
			Thread.Sleep(30);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000208E4 File Offset: 0x0001EAE4
		private void simpleButton33_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			Form1.timer8.Elapsed += this.method_3;
			Form1.timer8.AutoReset = true;
			Form1.timer8.Enabled = this.TimerEnabled;
			this.simpleButton33.Text = (this.TimerEnabled ? "Flash [ON]" : "Flash [OFF]");
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00020950 File Offset: 0x0001EB50
		private void simpleButton34_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton34.Text == "All LEDs [OFF]"))
			{
				this.simpleButton34.Text = "All LEDs [OFF]";
				this.ixboxConsole_0.SetLeds(JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF, JRPC.LEDState.OFF);
			}
			else
			{
				this.simpleButton34.Text = "All LEDs [ON]";
				this.ixboxConsole_0.SetLeds(JRPC.LEDState.GREEN, JRPC.LEDState.GREEN, JRPC.LEDState.GREEN, JRPC.LEDState.GREEN);
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000209C4 File Offset: 0x0001EBC4
		private void simpleButton37_Click(object sender, EventArgs e)
		{
			if (this.textEdit_134.Text == "")
			{
				XtraMessageBox.Show("Name can not be empty!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			if (this.textEdit_133.Text == "")
			{
				XtraMessageBox.Show("Path can not be empty!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			if (!(this.textEdit_132.Text == ""))
			{
				try
				{
					if (this.listBox7.SelectedItem.ToString() == this.textEdit_134.Text)
					{
						this.ini_2.Write(this.textEdit_134.Text + "p1", "Path1", this.textEdit_133.Text + "\\" + this.textEdit_132.Text);
						this.ini_2.Write(this.textEdit_134.Text + "p2", "Path2", this.textEdit_133.Text);
					}
					else
					{
						this.listBox7.Items.Add(this.textEdit_134.Text);
						this.ini_2.Write(this.textEdit_134.Text + "p1", "Path1", this.textEdit_133.Text + "\\" + this.textEdit_132.Text);
						this.ini_2.Write(this.textEdit_134.Text + "p2", "Path2", this.textEdit_133.Text);
						string contents = this.textEdit_134.Text + Environment.NewLine;
						File.AppendAllText("GameNames.txt", contents);
					}
					return;
				}
				catch (Exception)
				{
					this.listBox7.Items.Add(this.textEdit_134.Text);
					this.ini_2.Write(this.textEdit_134.Text + "p1", "Path1", this.textEdit_133.Text + "\\" + this.textEdit_132.Text);
					this.ini_2.Write(this.textEdit_134.Text + "p2", "Path2", this.textEdit_133.Text);
					string contents2 = this.textEdit_134.Text + Environment.NewLine;
					File.AppendAllText("GameNames.txt", contents2);
					return;
				}
			}
			XtraMessageBox.Show("XeX Type can not be empty!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00020C7C File Offset: 0x0001EE7C
		private void simpleButton47_Click(object sender, EventArgs e)
		{
			if (this.listBox7.SelectedItem.ToString() == "Launch Game From Disc")
			{
				this.ixboxConsole_0.Reboot("DVD:\\default.xex", "DVD:\\", null, XboxRebootFlags.Title);
				this.ixboxConsole_0.XNotify("Launched Game From Disc!");
			}
			else
			{
				string section = this.listBox7.SelectedItem.ToString() + "p1";
				string section2 = this.listBox7.SelectedItem.ToString() + "p2";
				string name = this.ini_2.Read(section, "Path1");
				string mediaDirectory = this.ini_2.Read(section2, "Path2");
				this.ixboxConsole_0.Reboot(name, mediaDirectory, null, XboxRebootFlags.Title);
				this.ixboxConsole_0.XNotify("Launched title : " + this.listBox7.SelectedItem.ToString());
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00020D68 File Offset: 0x0001EF68
		private void simpleButton36_Click(object sender, EventArgs e)
		{
			string tempFileName = Path.GetTempFileName();
			IEnumerable<string> contents = File.ReadLines("GameNames.txt").Where(new Func<string, bool>(this.method_99));
			File.WriteAllLines(tempFileName, contents);
			File.Delete("GameNames.txt");
			File.Move(tempFileName, "GameNames.txt");
			File.AppendAllText("GameNames.txt", "");
			this.listBox7.Items.Clear();
			ListBox.ObjectCollection items = this.listBox7.Items;
			object[] items2 = File.ReadAllLines("GameNames.txt");
			items.AddRange(items2);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00020DF8 File Offset: 0x0001EFF8
		private void simpleButton35_Click(object sender, EventArgs e)
		{
			File.Delete("GameNames.txt");
			File.AppendAllText("GameNames.txt", "");
			ListBox.ObjectCollection items = this.listBox7.Items;
			object[] items2 = File.ReadAllLines("GameNames.txt");
			items.AddRange(items2);
			File.Delete("GameLauncher.ini");
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00020E48 File Offset: 0x0001F048
		private void simpleButton46_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.XNotify("Tool will unfreeze once you have selected the game to purchase!");
			byte[] data = new byte[]
			{
				56,
				128,
				0,
				5,
				128,
				99,
				0,
				28,
				144,
				131,
				0,
				4,
				56,
				128,
				9,
				196,
				144,
				131,
				0,
				8,
				56,
				96,
				0,
				0,
				78,
				128,
				0,
				32
			};
			this.ixboxConsole_0.GetMemory(1610612736U, 32U);
			this.ixboxConsole_0.GetMemory(1207959752U, 32U);
			uint num;
			for (num = this.ixboxConsole_0.Call<uint>("xam.xex", 1102, new object[]
			{
				"Guide.MP.Purchase.xex"
			}); num == 0U; num = this.ixboxConsole_0.Call<uint>("xam.xex", 1102, new object[]
			{
				"Guide.MP.Purchase.xex"
			}))
			{
			}
			if (num > 0U)
			{
				this.ixboxConsole_0.SetMemory(2171119352U, data);
				this.ixboxConsole_0.WriteInt32(2173606884U, 1610612736);
				this.ixboxConsole_0.WriteInt32(2173625364U, 1207959752);
				this.ixboxConsole_0.WriteInt32(2417350752U, 1610612736);
				this.ixboxConsole_0.WriteInt32(2417350948U, 1610612736);
				this.ixboxConsole_0.XNotify("Guido's MSP Spoofer Enabled!");
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00020F70 File Offset: 0x0001F170
		private void simpleButton121_Click(object sender, EventArgs e)
		{
			if (this.simpleButton121.Text == "No Clip [OFF]")
			{
				this.simpleButton121.Text = "No Clip [ON]";
				this.ixboxConsole_0.SetMemory(2194748724U, new byte[]
				{
					1
				});
			}
			else
			{
				this.simpleButton121.Text = "No Clip [OFF]";
				this.ixboxConsole_0.SetMemory(2194748724U, new byte[1]);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00020FE8 File Offset: 0x0001F1E8
		private void simpleButton120_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton120.Text == "UFO [OFF]"))
			{
				this.simpleButton120.Text = "UFO [OFF]";
				this.ixboxConsole_0.SetMemory(2194748728U, new byte[1]);
			}
			else
			{
				this.simpleButton120.Text = "UFO [ON]";
				this.ixboxConsole_0.SetMemory(2194748728U, new byte[]
				{
					1
				});
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00021060 File Offset: 0x0001F260
		private void simpleButton119_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton119.Text == "Super Speed [OFF]"))
			{
				this.simpleButton119.Text = "Super Speed [OFF]";
				this.ixboxConsole_0.CallVoid(2183684008U, new object[]
				{
					-1,
					0,
					"v\\seta g_speed 165\0"
				});
			}
			else
			{
				this.simpleButton119.Text = "Super Speed [ON]";
				this.ixboxConsole_0.CallVoid(2183684008U, new object[]
				{
					-1,
					0,
					"v\\seta g_speed 650\0"
				});
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00021108 File Offset: 0x0001F308
		private void simpleButton117_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton117.Text == "Low Gravity [OFF]"))
			{
				this.simpleButton117.Text = "Low Gravity [OFF]";
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"toggle g_gravity 800"
				});
			}
			else
			{
				this.simpleButton117.Text = "Low Gravity [ON]";
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"toggle g_gravity 200"
				});
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0002119C File Offset: 0x0001F39C
		private void simpleButton116_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"fast_restart"
			});
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000211D0 File Offset: 0x0001F3D0
		private void simpleButton115_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183684008U, new object[]
			{
				-1,
				0,
				"v\\" + this.textEdit_25.Text + "\0"
			});
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00021224 File Offset: 0x0001F424
		private void simpleButton118_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183684008U, new object[]
			{
				-1,
				0,
				"f \"" + this.textEdit_24.Text + "\""
			});
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00021278 File Offset: 0x0001F478
		private void simpleButton150_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183684008U, new object[]
			{
				-1,
				0,
				"c \"" + this.textEdit_24.Text + "\""
			});
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000212CC File Offset: 0x0001F4CC
		private void simpleButton103_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"customclass1 " + this.textEdit_23.Text
			});
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"customclass2 " + this.textEdit_19.Text
			});
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"customclass3 " + this.textEdit_20.Text
			});
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"customclass4 " + this.textEdit_22.Text
			});
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"customclass5 " + this.textEdit_21.Text
			});
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"prestigeclass1 " + this.textEdit_18.Text
			});
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"prestigeclass2 " + this.textEdit_14.Text
			});
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"prestigeclass3 " + this.textEdit_15.Text
			});
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"prestigeclass4 " + this.textEdit_17.Text
			});
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"prestigeclass5 " + this.textEdit_16.Text
			});
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.XNotify("Custom Class Names Set!");
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00021538 File Offset: 0x0001F738
		private void simpleButton108_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"exec mp/unlock_init.cfg;exec mp/unlock_menu.cfg;exec mp/unlock_allperks.cfg;exec mp/unlock_allweapon"
			});
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"exec mp/unlock_challenges.cfg;updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.XNotify("Unlock All Applied!");
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000215A4 File Offset: 0x0001F7A4
		private void simpleButton105_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = XtraMessageBox.Show("Are you sure you want to reset your stats?", "Warning", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"resetstats"
				});
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000215F4 File Offset: 0x0001F7F4
		private void simpleButton104_Click(object sender, EventArgs e)
		{
			this.numericUpDown10.Value = 10m;
			this.numericUpDown12.Value = 1000000m;
			this.numericUpDown14.Value = 10000000m;
			this.numericUpDown16.Value = 50000m;
			this.numericUpDown15.Value = 1500m;
			this.numericUpDown13.Value = 50000m;
			this.numericUpDown11.Value = 1500m;
			this.simpleButton106_Click(sender, null);
			this.simpleButton110_Click(sender, null);
			this.simpleButton112_Click(sender, null);
			this.simpleButton113_Click(sender, null);
			this.simpleButton111_Click(sender, null);
			this.simpleButton109_Click(sender, null);
			this.simpleButton107_Click(sender, null);
			this.ixboxConsole_0.XNotify("Quick Stats Set!");
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000216DC File Offset: 0x0001F8DC
		private void simpleButton106_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"statset 2326 " + this.numericUpDown10.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00021728 File Offset: 0x0001F928
		private void simpleButton110_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"statset 2301 " + this.numericUpDown12.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00021774 File Offset: 0x0001F974
		private void simpleButton112_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"statset 2302 " + this.numericUpDown14.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000217C0 File Offset: 0x0001F9C0
		private void simpleButton113_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"statset 2303 " + this.numericUpDown16.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0002180C File Offset: 0x0001FA0C
		private void simpleButton111_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"statset 2305 " + this.numericUpDown15.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00021858 File Offset: 0x0001FA58
		private void simpleButton109_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"statset 2316 " + this.numericUpDown13.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000218A4 File Offset: 0x0001FAA4
		private void simpleButton107_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"statset 2317 " + this.numericUpDown11.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000218F0 File Offset: 0x0001FAF0
		private void simpleButton151_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"say \"" + this.textEdit_24.Text + "\""
			});
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0002193C File Offset: 0x0001FB3C
		private void simpleButton102_Click(object sender, EventArgs e)
		{
			string str = Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "";
			this.textEdit_23.Text = "^1" + str;
			this.textEdit_19.Text = "^2" + str;
			this.textEdit_20.Text = "^3" + str;
			this.textEdit_22.Text = "^4" + str;
			this.textEdit_21.Text = "^5" + str;
			this.textEdit_18.Text = "^1" + str;
			this.textEdit_14.Text = "^2" + str;
			this.textEdit_15.Text = "^3" + str;
			this.textEdit_17.Text = "^4" + str;
			this.textEdit_16.Text = "^5" + str;
			this.simpleButton103_Click(sender, null);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00021A70 File Offset: 0x0001FC70
		private void simpleButton99_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit3.SelectedIndex == 0)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"ui_mapname \"mp_dome;motd ^1Infected ^2By ^3Guido's ^4Console ^5Tool ^1:);exec mp/unlock_init.cfg;updategamerprofile;uploadstats;wait 30;disconnect\""
				});
			}
			if (this.comboBoxEdit3.SelectedIndex == 1)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"ui_mapname \"mp_dome;motd ^1Infected ^2By ^3Guido's ^4Console ^5Tool ^1:);clanname " + this.textEdit_135.Text + ";updategamerprofile;uploadstats;wait 30;disconnect\""
				});
			}
			if (this.comboBoxEdit3.SelectedIndex == 2)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"ui_mapname \"mp_dome;motd ^1Infected ^2By ^3Guido's ^4Console ^5Tool ^1:);resetstats;updategamerprofile;uploadstats;wait 30;disconnect\""
				});
			}
			if (this.comboBoxEdit3.SelectedIndex == 3)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"ui_mapname \"mp_dome;motd ^1Infected ^2By ^3Guido's ^4Console ^5Tool ^1:);statset 2326 10;statset 2301 1000000;updategamerprofile;uploadstats;wait 30;disconnect\""
				});
			}
			if (this.comboBoxEdit3.SelectedIndex == 4)
			{
				string text = this.textEdit_136.Text;
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					string.Concat(new string[]
					{
						"ui_mapname \"mp_dome;motd ^1Infected ^2By ^3Guido's ^4Console ^5Tool ^1:);customclass1 ",
						text,
						";customclass2 ",
						text,
						";customclass3 ",
						text,
						";customclass4 ",
						text,
						";customclass5 ",
						text,
						";updategamerprofile;uploadstats;wait 30;disconnect\""
					})
				});
			}
			this.ixboxConsole_0.XNotify("Infection Created Successfully! Start a split screen match to finalize");
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00021C18 File Offset: 0x0001FE18
		private void simpleButton134_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"disconnect"
			});
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00021C4C File Offset: 0x0001FE4C
		private void simpleButton133_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"set party_minplayers 1;xpartygo"
			});
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00021C80 File Offset: 0x0001FE80
		private void simpleButton132_Click(object sender, EventArgs e)
		{
			if (this.simpleButton132.Text == "Force Host [OFF]")
			{
				this.simpleButton132.Text = "Force Host [ON]";
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"party_connectToOthers 00; partyMigrate_disabled 01; sv_endGameIfISuck 0; badhost_endgameifisuck 0​; set allowAllNAT 1"
				});
			}
			else
			{
				this.simpleButton132.Text = "Force Host [OFF]";
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"party_connectToOthers 01; partyMigrate_disabled 00"
				});
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00021D14 File Offset: 0x0001FF14
		private void simpleButton130_Click(object sender, EventArgs e)
		{
			if (this.simpleButton130.Text == "Laser [OFF]")
			{
				this.simpleButton130.Text = "Laser [ON]";
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"toggle cg_laserforceon"
				});
			}
			else
			{
				this.simpleButton130.Text = "Laser [OFF]";
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"toggle cg_laserforceon"
				});
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00021DA8 File Offset: 0x0001FFA8
		private void simpleButton129_Click(object sender, EventArgs e)
		{
			if (this.simpleButton129.Text == "Big Map [OFF]")
			{
				this.simpleButton129.Text = "Big Map [ON]";
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"set compassSize 1.5\""
				});
			}
			else
			{
				this.simpleButton129.Text = "Big Map [OFF]";
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"set compassSize 1\""
				});
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00021E3C File Offset: 0x0002003C
		private void method_4(object sender, ElapsedEventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"give ammo"
			});
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00021E70 File Offset: 0x00020070
		private void simpleButton128_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton128.Text = (this.TimerEnabled ? "Unlimited Ammo [ON]" : "Unlimited Ammo [OFF]");
			Form1.timer2.Elapsed += this.method_4;
			Form1.timer2.AutoReset = true;
			Form1.timer2.Enabled = this.TimerEnabled;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00021EDC File Offset: 0x000200DC
		private void simpleButton131_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton131.Text == "UAV [OFF]"))
			{
				this.simpleButton131.Text = "UAV [OFF]";
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"compassEnemyFootstepEnabled 1;g_compassshowenemies 9;compassEnemyFootstepMaxRange 999;compassEnemyFootstepMaxZ 999"
				});
			}
			else
			{
				this.simpleButton131.Text = "UAV [ON]";
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"compassEnemyFootstepEnabled 1;g_compassshowenemies 9;compassEnemyFootstepMaxRange 999;compassEnemyFootstepMaxZ 999"
				});
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00021F70 File Offset: 0x00020170
		private void simpleButton152_Click(object sender, EventArgs e)
		{
			if (this.simpleButton152.Text == "Wallhack [OFF]")
			{
				this.simpleButton152.Text = "Wallhack [ON]";
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"toggle r_znear 60"
				});
			}
			else
			{
				this.simpleButton152.Text = "Wallhack [OFF]";
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"toggle r_znear 35"
				});
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00022004 File Offset: 0x00020204
		private void simpleButton155_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"god"
			});
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00022038 File Offset: 0x00020238
		private void simpleButton154_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"demigod"
			});
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0002206C File Offset: 0x0002026C
		private void simpleButton157_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"noclip"
			});
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00021E3C File Offset: 0x0002003C
		private void simpleButton153_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"give ammo"
			});
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000220A0 File Offset: 0x000202A0
		private void simpleButton156_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"toggle ui_allow_teamchange"
			});
			this.ixboxConsole_0.XNotify("You can now change teams in the game menu!");
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000220E4 File Offset: 0x000202E4
		private void method_5(object sender, ElapsedEventArgs e)
		{
			Random random = new Random();
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				string.Concat(new string[]
				{
					"r_filmTweakInvert 1;r_filmTweakbrightness 2;r_filmusetweaks 1;r_filmTweakenable 1;r_filmtweakLighttint ",
					random.Next(0, 2).ToString(),
					" ",
					random.Next(0, 2).ToString(),
					" ",
					random.Next(0, 2).ToString(),
					" ",
					random.Next(0, 2).ToString(),
					";r_filmtweakdarktint ",
					random.Next(0, 2).ToString(),
					" ",
					random.Next(0, 2).ToString(),
					" ",
					random.Next(0, 2).ToString(),
					";"
				})
			});
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00022200 File Offset: 0x00020400
		private void simpleButton127_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton127.Text = ((!this.TimerEnabled) ? "Disco Vision [OFF]" : "Disco Vision [ON]");
			Form1.DiscoTimerWAW.Elapsed += this.method_5;
			Form1.DiscoTimerWAW.AutoReset = true;
			Form1.DiscoTimerWAW.Enabled = this.TimerEnabled;
			if (this.simpleButton127.Text == "Disco Vision [OFF]")
			{
				this.simpleButton124_Click(sender, null);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0002228C File Offset: 0x0002048C
		private void simpleButton124_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"r_debugShader 0;r_fullbright 0;r_filmTweakInvert 0;r_filmTweakbrightness 0;r_filmusetweaks 0;r_filmTweakenable 0;r_filmtweakLighttint 1.1 1.05 0.85;r_filmtweakdarktint 0.7 0.85 1;"
			});
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"scr_art_tweak 0;r_glowUseTweaks 1;r_contrast 1;r_specularmap 0;r_flameFX_enable 0;r_waterSheetingFX_enable 0;r_poisonFX_debug_enable 0;"
			});
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000222E8 File Offset: 0x000204E8
		private void method_6(object sender, ElapsedEventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"toggle r_contrast 0 1"
			});
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0002231C File Offset: 0x0002051C
		private void simpleButton126_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton126.Text = (this.TimerEnabled ? "Flash Vision [ON]" : "Flash Vision [OFF]");
			Form1.FlashTimer.Elapsed += this.method_6;
			Form1.FlashTimer.AutoReset = true;
			Form1.FlashTimer.Enabled = this.TimerEnabled;
			if (this.simpleButton126.Text == "Flash Vision [OFF]")
			{
				this.simpleButton124_Click(sender, null);
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000223A8 File Offset: 0x000205A8
		private void simpleButton122_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"cg_fov " + this.numericUpDown17.Value.ToString()
			});
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000223F8 File Offset: 0x000205F8
		private void simpleButton123_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				this.textEdit_26.Text
			});
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00022434 File Offset: 0x00020634
		private void simpleButton125_Click(object sender, EventArgs e)
		{
			this.simpleButton124_Click(sender, null);
			if (this.comboBoxEdit4.SelectedIndex == 0)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"r_fullbright 0;r_specularmap 2;"
				});
			}
			if (this.comboBoxEdit4.SelectedIndex == 1)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"scr_art_tweak 1;r_glowUseTweaks 1;r_filmUseTweaks 1;"
				});
			}
			if (this.comboBoxEdit4.SelectedIndex == 2)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"toggle r_filmTweakInvert 1 0;toggle r_filmTweakbrightness 2 0;toggle r_filmusetweaks 1 0;toggle r_filmTweakenable 1 0;toggle r_filmtweakLighttint 1.06 0.5 1.3 0"
				});
			}
			if (this.comboBoxEdit4.SelectedIndex == 3)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"r_filmTweakInvert 1;r_filmTweakbrightness 2;r_filmusetweaks 1;r_filmTweakenable 1;r_filmtweakLighttint 1 2 1 1.1;r_filmtweakdarktint 1 2 1;"
				});
			}
			if (this.comboBoxEdit4.SelectedIndex == 4)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"r_filmTweakInvert 1;r_filmusetweaks 1;r_filmtweakenable 1;r_filmTweakLightTint 5.3 6.3 7.2;"
				});
			}
			if (this.comboBoxEdit4.SelectedIndex == 5)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"r_filmTweakInvert 1;r_filmTweakbrightness 2;r_filmusetweaks 1;r_filmTweakenable 1;r_filmtweakLighttint 1 2 1 1.1;r_filmtweakdarktint 0 0 2;"
				});
			}
			if (this.comboBoxEdit4.SelectedIndex == 6)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"r_filmTweakInvert 1;r_filmTweakbrightness 2;r_filmusetweaks 1;r_filmTweakenable 1;r_filmtweakLighttint 1 2 1 1.1;r_filmtweakdarktint 0 1 2;"
				});
			}
			if (this.comboBoxEdit4.SelectedIndex == 7)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"r_filmTweakInvert 1;r_filmTweakbrightness 2;r_filmusetweaks 1;r_filmTweakenable 1;r_filmtweakLighttint 1 1 1 1;r_filmtweakdarktint 0 0 0;"
				});
			}
			if (this.comboBoxEdit4.SelectedIndex == 8)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"r_flameFX_enable 1"
				});
			}
			if (this.comboBoxEdit4.SelectedIndex == 9)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"r_waterSheetingFX_enable 1"
				});
			}
			if (this.comboBoxEdit4.SelectedIndex == 10)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"r_poisonFX_debug_enable 1"
				});
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000226A8 File Offset: 0x000208A8
		private void simpleButton182_Click(object sender, EventArgs e)
		{
			this.simpleButton129.Text = "Big Map [ON]";
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"set compassSize 1.5\""
			});
			this.simpleButton130.Text = "Laser [ON]";
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"toggle cg_laserforceon"
			});
			this.simpleButton131.Text = "UAV [ON]";
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"compassEnemyFootstepEnabled 1;g_compassshowenemies 9;compassEnemyFootstepMaxRange 999;compassEnemyFootstepMaxZ 999"
			});
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"set cg_fov 90"
			});
			this.textEdit_26.Text = "set cg_fov 90";
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"give ammo"
			});
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"toggle ui_allow_teamchange"
			});
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"toggle player_sustainammo"
			});
			this.ixboxConsole_0.XNotify("All Offhost Cheats set!");
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00022818 File Offset: 0x00020A18
		private void method_7(string string_3)
		{
			this.ixboxConsole_0.CallVoid(2183452896U, new object[]
			{
				0,
				string_3
			});
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00022848 File Offset: 0x00020A48
		private void simpleButton149_Click(object sender, EventArgs e)
		{
			this.method_7(this.textEdit_27.Text);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00022868 File Offset: 0x00020A68
		private void simpleButton148_Click(object sender, EventArgs e)
		{
			this.method_7("noclip");
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00022880 File Offset: 0x00020A80
		private void simpleButton147_Click(object sender, EventArgs e)
		{
			this.method_7("ufo");
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00022898 File Offset: 0x00020A98
		private void simpleButton146_Click(object sender, EventArgs e)
		{
			this.method_7("god");
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000228B0 File Offset: 0x00020AB0
		private void simpleButton145_Click(object sender, EventArgs e)
		{
			this.method_7("demigod");
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000228C8 File Offset: 0x00020AC8
		private void simpleButton144_Click(object sender, EventArgs e)
		{
			this.method_7("toggle player_sustainammo");
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000228E0 File Offset: 0x00020AE0
		private void simpleButton143_Click(object sender, EventArgs e)
		{
			this.method_7("give ammo");
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000228F8 File Offset: 0x00020AF8
		private void simpleButton142_Click(object sender, EventArgs e)
		{
			this.method_7("give all");
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00022910 File Offset: 0x00020B10
		private void simpleButton137_Click(object sender, EventArgs e)
		{
			if (this.simpleButton137.Text == "Super Speed [OFF]")
			{
				this.simpleButton137.Text = "Super Speed [ON]";
				this.method_7("g_speed 650");
			}
			else
			{
				this.simpleButton137.Text = "Super Speed [OFF]";
				this.method_7("g_speed 165");
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0002296C File Offset: 0x00020B6C
		private void simpleButton136_Click(object sender, EventArgs e)
		{
			if (this.simpleButton136.Text == "Low Gravity [OFF]")
			{
				this.simpleButton136.Text = "Low Gravity [ON]";
				this.method_7("g_gravity 125");
			}
			else
			{
				this.simpleButton136.Text = "Low Gravity [OFF]";
				this.method_7("g_gravity 650");
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000229C8 File Offset: 0x00020BC8
		private void simpleButton135_Click(object sender, EventArgs e)
		{
			this.method_7("cg_fov " + this.numericUpDown18.Value.ToString());
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000229FC File Offset: 0x00020BFC
		private void simpleButton141_Click(object sender, EventArgs e)
		{
			this.method_7("take all");
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00022A14 File Offset: 0x00020C14
		private void simpleButton140_Click(object sender, EventArgs e)
		{
			this.method_7("fast_restart");
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00022A2C File Offset: 0x00020C2C
		private void simpleButton139_Click(object sender, EventArgs e)
		{
			this.method_7("ai axis delete");
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00022A44 File Offset: 0x00020C44
		private void simpleButton138_Click(object sender, EventArgs e)
		{
			if (this.simpleButton138.Text == "Super Jump [OFF]")
			{
				this.simpleButton138.Text = "Super Jump [ON]";
				this.method_7("jump_height 999");
				this.method_7("bg_fallDamageMinHeight 998");
				this.method_7("bg_fallDamageMaxHeight 999");
			}
			else
			{
				this.simpleButton138.Text = "Super Jump [OFF]";
				this.method_7("jump_height 39");
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00022868 File Offset: 0x00020A68
		private void simpleButton171_Click(object sender, EventArgs e)
		{
			this.method_7("noclip");
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00022880 File Offset: 0x00020A80
		private void simpleButton170_Click(object sender, EventArgs e)
		{
			this.method_7("ufo");
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00022898 File Offset: 0x00020A98
		private void simpleButton169_Click(object sender, EventArgs e)
		{
			this.method_7("god");
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000228B0 File Offset: 0x00020AB0
		private void simpleButton168_Click(object sender, EventArgs e)
		{
			this.method_7("demigod");
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000228C8 File Offset: 0x00020AC8
		private void simpleButton167_Click(object sender, EventArgs e)
		{
			this.method_7("toggle player_sustainammo");
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000228E0 File Offset: 0x00020AE0
		private void simpleButton166_Click(object sender, EventArgs e)
		{
			this.method_7("give ammo");
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000228F8 File Offset: 0x00020AF8
		private void simpleButton165_Click(object sender, EventArgs e)
		{
			this.method_7("give all");
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00022AB8 File Offset: 0x00020CB8
		private void simpleButton173_Click(object sender, EventArgs e)
		{
			this.method_7("toggle r_fullbright");
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00022AD0 File Offset: 0x00020CD0
		private void simpleButton174_Click(object sender, EventArgs e)
		{
			this.method_7("player_meleerange 10000");
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00022AE8 File Offset: 0x00020CE8
		private void simpleButton176_Click(object sender, EventArgs e)
		{
			this.method_7("perk_weapReloadMultiplier 0.01");
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00022B00 File Offset: 0x00020D00
		private void simpleButton179_Click(object sender, EventArgs e)
		{
			this.method_7("toggle cg_laserforceon");
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00022910 File Offset: 0x00020B10
		private void simpleButton160_Click(object sender, EventArgs e)
		{
			if (this.simpleButton137.Text == "Super Speed [OFF]")
			{
				this.simpleButton137.Text = "Super Speed [ON]";
				this.method_7("g_speed 650");
			}
			else
			{
				this.simpleButton137.Text = "Super Speed [OFF]";
				this.method_7("g_speed 165");
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0002296C File Offset: 0x00020B6C
		private void simpleButton159_Click(object sender, EventArgs e)
		{
			if (this.simpleButton136.Text == "Low Gravity [OFF]")
			{
				this.simpleButton136.Text = "Low Gravity [ON]";
				this.method_7("g_gravity 125");
			}
			else
			{
				this.simpleButton136.Text = "Low Gravity [OFF]";
				this.method_7("g_gravity 650");
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00022A44 File Offset: 0x00020C44
		private void simpleButton161_Click(object sender, EventArgs e)
		{
			if (this.simpleButton138.Text == "Super Jump [OFF]")
			{
				this.simpleButton138.Text = "Super Jump [ON]";
				this.method_7("jump_height 999");
				this.method_7("bg_fallDamageMinHeight 998");
				this.method_7("bg_fallDamageMaxHeight 999");
			}
			else
			{
				this.simpleButton138.Text = "Super Jump [OFF]";
				this.method_7("jump_height 39");
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000229FC File Offset: 0x00020BFC
		private void simpleButton164_Click(object sender, EventArgs e)
		{
			this.method_7("take all");
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00022B18 File Offset: 0x00020D18
		private void simpleButton180_Click(object sender, EventArgs e)
		{
			this.method_7("give zombie_perk_bottle_doubletap");
			this.method_7("give zombie_perk_bottle_jugg");
			this.method_7("give zombie_perk_bottle_revive");
			this.method_7("give zombie_perk_bottle_sleight");
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00022B54 File Offset: 0x00020D54
		private void simpleButton162_Click(object sender, EventArgs e)
		{
			this.method_7("ai_axis delete");
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00022B6C File Offset: 0x00020D6C
		private void simpleButton158_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183452896U, new object[]
			{
				0,
				"toggle ai_disableSpawn"
			});
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00022BA0 File Offset: 0x00020DA0
		private void simpleButton172_Click(object sender, EventArgs e)
		{
			this.method_7("toggle r_fog");
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00022BB8 File Offset: 0x00020DB8
		private void simpleButton175_Click(object sender, EventArgs e)
		{
			this.method_7("phys_gravity 1");
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00022BD0 File Offset: 0x00020DD0
		private void simpleButton177_Click(object sender, EventArgs e)
		{
			this.method_7("notarget");
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00022BE8 File Offset: 0x00020DE8
		private void simpleButton178_Click(object sender, EventArgs e)
		{
			this.method_7("toggle cg_thirdperson");
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00022C00 File Offset: 0x00020E00
		private void simpleButton181_Click(object sender, EventArgs e)
		{
			this.method_7("give " + this.comboBoxEdit6.Text);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00022C28 File Offset: 0x00020E28
		private void simpleButton163_Click(object sender, EventArgs e)
		{
			this.method_7("give " + this.comboBoxEdit5.Text);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00022C50 File Offset: 0x00020E50
		private void simpleButton48_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton48.Text == "Super Jump [OFF]"))
			{
				this.simpleButton48.Text = "Super Jump [OFF]";
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"jump_height 39"
				});
			}
			else
			{
				this.simpleButton48.Text = "Super Jump [ON]";
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"jump_height 1000"
				});
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"bg_fallDamageMinHeight 9999"
				});
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00022D0C File Offset: 0x00020F0C
		private void simpleButton49_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton49.Text == "Super Speed [OFF]"))
			{
				this.simpleButton49.Text = "Super Speed [OFF]";
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"g_speed 165"
				});
			}
			else
			{
				this.simpleButton49.Text = "Super Speed [ON]";
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"g_speed 650"
				});
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00022DA0 File Offset: 0x00020FA0
		private void simpleButton50_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton50.Text == "Low Gravity [OFF]"))
			{
				this.simpleButton50.Text = "Low Gravity [OFF]";
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"g_gravity 800"
				});
			}
			else
			{
				this.simpleButton50.Text = "Low Gravity [ON]";
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"g_gravity 100"
				});
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00022E34 File Offset: 0x00021034
		private void simpleButton52_Click(object sender, EventArgs e)
		{
			if (this.simpleButton52.Text == "Unlimited Ammo [OFF]")
			{
				this.simpleButton52.Text = "Unlimited Ammo [ON]";
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"player_sustainAmmo 1"
				});
			}
			else
			{
				this.simpleButton52.Text = "Unlimited Ammo [OFF]";
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"player_sustainAmmo 0"
				});
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00022EC8 File Offset: 0x000210C8
		private void simpleButton51_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton51.Text == "Godmode [OFF]"))
			{
				this.simpleButton51.Text = "Godmode [OFF]";
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"set scr_csMode 100"
				});
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"kill"
				});
			}
			else
			{
				this.simpleButton51.Text = "Godmode [ON]";
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"set scr_csMode 99999"
				});
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"kill"
				});
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00022FAC File Offset: 0x000211AC
		private void simpleButton54_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"kick all"
			});
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00022FE0 File Offset: 0x000211E0
		private void simpleButton53_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"fast_restart"
			});
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00023014 File Offset: 0x00021214
		private void simpleButton55_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				string.Concat(new string[]
				{
					"userinfo \"\\clanabbrev\\",
					this.textEdit_175.Text,
					"\\name\\",
					this.textEdit_4.Text,
					"\\xuid\\"
				})
			});
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00023084 File Offset: 0x00021284
		private void simpleButton71_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"disconnect"
			});
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000230B8 File Offset: 0x000212B8
		private void simpleButton72_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"set party_minplayers 1; xpartygo"
			});
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000230EC File Offset: 0x000212EC
		private void simpleButton73_Click(object sender, EventArgs e)
		{
			if (this.simpleButton73.Text == "Force Host [OFF]")
			{
				this.simpleButton73.Text = "Force Host [ON]";
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"party_iamhost 1;party_hostmigration 0;party_connectToOthers 0"
				});
			}
			else
			{
				this.simpleButton73.Text = "Force Host [OFF]";
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"party_iamhost 0;party_hostmigration 1;party_connectToOthers 1"
				});
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00023180 File Offset: 0x00021380
		private void simpleButton75_Click(object sender, EventArgs e)
		{
			if (this.simpleButton75.Text == "Laser [OFF]")
			{
				this.simpleButton75.Text = "Laser [ON]";
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"cg_laserforceOn 1"
				});
			}
			else
			{
				this.simpleButton75.Text = "Laser [OFF]";
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"cg_laserforceOn 0"
				});
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00023214 File Offset: 0x00021414
		private void simpleButton76_Click(object sender, EventArgs e)
		{
			if (this.simpleButton76.Text == "Big Map [OFF]")
			{
				this.simpleButton76.Text = "Big Map [ON]";
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"compassSize 1.5"
				});
			}
			else
			{
				this.simpleButton76.Text = "Big Map [OFF]";
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"compassSize 1"
				});
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000232A8 File Offset: 0x000214A8
		private void simpleButton77_Click(object sender, EventArgs e)
		{
			if (this.simpleButton77.Text == "Third Person [OFF]")
			{
				this.simpleButton77.Text = "Third Person [ON]";
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"cg_thirdPerson 1"
				});
			}
			else
			{
				this.simpleButton77.Text = "Third Person [OFF]";
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"cg_thirdPerson 0"
				});
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0002333C File Offset: 0x0002153C
		private void method_8(object sender, ElapsedEventArgs e)
		{
			Random random = new Random();
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				string.Concat(new string[]
				{
					"r_filmTweakInvert 1;r_filmTweakbrightness 2;r_filmusetweaks 1;r_filmTweakenable 1;r_filmtweakLighttint ",
					random.Next(0, 2).ToString(),
					" ",
					random.Next(0, 2).ToString(),
					" ",
					random.Next(0, 2).ToString(),
					" ",
					random.Next(0, 2).ToString(),
					";r_filmtweakdarktint ",
					random.Next(0, 2).ToString(),
					" ",
					random.Next(0, 2).ToString(),
					" ",
					random.Next(0, 2).ToString(),
					";"
				})
			});
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00023458 File Offset: 0x00021658
		private void simpleButton78_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton78.Text = (this.TimerEnabled ? "Disco Vision [ON]" : "Disco Vision [OFF]");
			Form1.DiscoTimer.Elapsed += this.method_8;
			Form1.DiscoTimer.AutoReset = true;
			Form1.DiscoTimer.Enabled = this.TimerEnabled;
			if (this.simpleButton78.Text == "Disco Vision [OFF]")
			{
				this.simpleButton80_Click(sender, null);
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000234E4 File Offset: 0x000216E4
		private void simpleButton80_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"r_debugShader 0;r_fullbright 0;r_filmTweakInvert 0;r_filmTweakbrightness 0;r_filmusetweaks 0;r_filmTweakenable 0;r_filmtweakLighttint 1.1 1.05 0.85;r_filmtweakdarktint 0.7 0.85 1;"
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"scr_art_tweak 0;r_glowUseTweaks 1;r_contrast 1;r_specularmap 0;"
			});
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00023540 File Offset: 0x00021740
		private void method_9(object sender, ElapsedEventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"toggle r_contrast 0 1"
			});
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00023574 File Offset: 0x00021774
		private void simpleButton79_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton79.Text = ((!this.TimerEnabled) ? "Flash Vision [OFF]" : "Flash Vision [ON]");
			Form1.FlashTimer.Elapsed += this.method_9;
			Form1.FlashTimer.AutoReset = true;
			Form1.FlashTimer.Enabled = this.TimerEnabled;
			if (this.simpleButton79.Text == "Flash Vision [OFF]")
			{
				this.simpleButton80_Click(sender, null);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00023600 File Offset: 0x00021800
		private void simpleButton83_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"cg_fov " + this.numericUpDown8.Value.ToString()
			});
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00023650 File Offset: 0x00021850
		private void simpleButton82_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				this.textEdit_11.Text
			});
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0002368C File Offset: 0x0002188C
		private void simpleButton81_Click(object sender, EventArgs e)
		{
			this.simpleButton80_Click(sender, null);
			if (this.comboBoxEdit2.SelectedIndex == 0)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"r_fullbright 0;r_specularmap 2;"
				});
			}
			if (this.comboBoxEdit2.SelectedIndex == 1)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"r_fullbright 1;"
				});
			}
			if (this.comboBoxEdit2.SelectedIndex == 2)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"r_debugShader 1;"
				});
			}
			if (this.comboBoxEdit2.SelectedIndex == 3)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"scr_art_tweak 1;r_glowUseTweaks 1;r_filmUseTweaks 1;"
				});
			}
			if (this.comboBoxEdit2.SelectedIndex == 4)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"toggle r_filmTweakInvert 1 0;toggle r_filmTweakbrightness 2 0;toggle r_filmusetweaks 1 0;toggle r_filmTweakenable 1 0;toggle r_filmtweakLighttint 1.06 0.5 1.3 0"
				});
			}
			if (this.comboBoxEdit2.SelectedIndex == 5)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"r_filmTweakInvert 1;r_filmTweakbrightness 2;r_filmusetweaks 1;r_filmTweakenable 1;r_filmtweakLighttint 1 2 1 1.1;r_filmtweakdarktint 1 2 1;"
				});
			}
			if (this.comboBoxEdit2.SelectedIndex == 6)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"r_filmTweakInvert 1;r_filmusetweaks 1;r_filmtweakenable 1;r_filmTweakLightTint 5.3 6.3 7.2;"
				});
			}
			if (this.comboBoxEdit2.SelectedIndex == 7)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"r_filmTweakInvert 1;r_filmTweakbrightness 2;r_filmusetweaks 1;r_filmTweakenable 1;r_filmtweakLighttint 1 2 1 1.1;r_filmtweakdarktint 0 0 2;"
				});
			}
			if (this.comboBoxEdit2.SelectedIndex == 8)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"r_filmTweakInvert 1;r_filmTweakbrightness 2;r_filmusetweaks 1;r_filmTweakenable 1;r_filmtweakLighttint 1 2 1 1.1;r_filmtweakdarktint 0 1 2;"
				});
			}
			if (this.comboBoxEdit2.SelectedIndex == 9)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"r_filmTweakInvert 1;r_filmTweakbrightness 2;r_filmusetweaks 1;r_filmTweakenable 1;r_filmtweakLighttint 1 1 1 1;r_filmtweakdarktint 0 0 0;"
				});
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000238C8 File Offset: 0x00021AC8
		private void simpleButton74_Click(object sender, EventArgs e)
		{
			if (!(this.textEdit_12.Text == ""))
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"bind DPAD_UP " + this.textEdit_12.Text
				});
				this.ixboxConsole_0.XNotify("Successfully binded DPAD_UP To : " + this.textEdit_12.Text);
			}
			else
			{
				XtraMessageBox.Show("Field cannot be empty.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00023958 File Offset: 0x00021B58
		private void method_10(string string_3)
		{
			this.ixboxConsole_0.CallVoid(2182998488U, new object[]
			{
				0,
				string_3
			});
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00023988 File Offset: 0x00021B88
		private void simpleButton84_Click(object sender, EventArgs e)
		{
			this.method_10(this.textEdit_13.Text);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000239A8 File Offset: 0x00021BA8
		private void simpleButton85_Click(object sender, EventArgs e)
		{
			this.method_10("noclip");
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000239C0 File Offset: 0x00021BC0
		private void simpleButton86_Click(object sender, EventArgs e)
		{
			this.method_10("ufo");
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000239D8 File Offset: 0x00021BD8
		private void simpleButton87_Click(object sender, EventArgs e)
		{
			this.method_10("god");
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000239F0 File Offset: 0x00021BF0
		private void simpleButton88_Click(object sender, EventArgs e)
		{
			this.method_10("demigod");
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00023A08 File Offset: 0x00021C08
		private void simpleButton89_Click(object sender, EventArgs e)
		{
			this.method_10("toggle player_sustainammo");
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00023A20 File Offset: 0x00021C20
		private void simpleButton90_Click(object sender, EventArgs e)
		{
			this.method_10("give ammo");
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00023A38 File Offset: 0x00021C38
		private void simpleButton91_Click(object sender, EventArgs e)
		{
			this.method_10("give all");
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00023A50 File Offset: 0x00021C50
		private void simpleButton97_Click(object sender, EventArgs e)
		{
			this.method_10("cg_fov " + this.numericUpDown9.Value.ToString());
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00023A84 File Offset: 0x00021C84
		private void simpleButton92_Click(object sender, EventArgs e)
		{
			this.method_10("take all");
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00023A9C File Offset: 0x00021C9C
		private void simpleButton93_Click(object sender, EventArgs e)
		{
			this.method_10("fast_restart");
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00023AB4 File Offset: 0x00021CB4
		private void simpleButton94_Click(object sender, EventArgs e)
		{
			this.method_10("ai axis delete");
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00023ACC File Offset: 0x00021CCC
		private void simpleButton98_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton98.Text == "Super Speed [OFF]"))
			{
				this.simpleButton98.Text = "Super Speed [OFF]";
				this.method_10("g_speed 165");
			}
			else
			{
				this.simpleButton98.Text = "Super Speed [ON]";
				this.method_10("g_speed 650");
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00023B28 File Offset: 0x00021D28
		private void simpleButton96_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton96.Text == "Low Gravity [OFF]"))
			{
				this.simpleButton96.Text = "Low Gravity [OFF]";
				this.method_10("g_gravity 650");
			}
			else
			{
				this.simpleButton96.Text = "Low Gravity [ON]";
				this.method_10("g_gravity 125");
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00023B84 File Offset: 0x00021D84
		private void simpleButton95_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton95.Text == "Super Jump [OFF]"))
			{
				this.simpleButton95.Text = "Super Jump [OFF]";
				this.method_10("jump_height 39");
			}
			else
			{
				this.simpleButton95.Text = "Super Jump [ON]";
				this.method_10("jump_height 999");
				this.method_10("bg_fallDamageMinHeight 998");
				this.method_10("bg_fallDamageMaxHeight 999");
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00023BF8 File Offset: 0x00021DF8
		private void simpleButton57_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset 2326 " + this.numericUpDown1.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00023C44 File Offset: 0x00021E44
		private void simpleButton58_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset 2301 " + this.numericUpDown2.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00023C90 File Offset: 0x00021E90
		private void simpleButton59_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset 2302 " + this.numericUpDown3.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00023CDC File Offset: 0x00021EDC
		private void simpleButton60_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset 2303 " + this.numericUpDown4.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00023D28 File Offset: 0x00021F28
		private void simpleButton61_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset 2305 " + this.numericUpDown5.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00023D74 File Offset: 0x00021F74
		private void simpleButton63_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset 2316 " + this.numericUpDown7.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00023DC0 File Offset: 0x00021FC0
		private void simpleButton62_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset 2317 " + this.numericUpDown6.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00023E0C File Offset: 0x0002200C
		private void simpleButton65_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset 3000 9;statset 3001 9;statset 3002 9;statset 3003 1;statset 3004 1;"
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset 3010 7951;statset 3011 7951;statset 3012 16143;statset 3013 7951;statset 3014 7951;"
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset 3020 16175;statset 3021 7983;statset 3022 7937;statset 3023 7983;statset 3024 7983;"
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset 3025 7983;statset 3026 7983;statset 3060 16131;statset 3061 7939;statset 3062 7939;"
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset 3064 7939;statset 3065 7939;statset 3070 16149;statset 3071 7957;statset 3080 7959;"
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset 3081 7959;statset 3082 16151;"
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.XNotify("Unlock All Applied!");
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00023F3C File Offset: 0x0002213C
		private void simpleButton67_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = XtraMessageBox.Show("Are you sure you want to reset your stats?", "Warning", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"resetstats"
				});
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00023F8C File Offset: 0x0002218C
		private void simpleButton68_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset 2326 10;updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset 2301 1000000;updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset 2302 10000000;updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset 2303 50000;updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset 2305 1500;updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset 2316 50000;updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset 2317 1500;updategamerprofile;uploadstats"
			});
			this.numericUpDown1.Value = 10m;
			this.numericUpDown2.Value = 1000000m;
			this.numericUpDown3.Value = 10000000m;
			this.numericUpDown4.Value = 50000m;
			this.numericUpDown5.Value = 1500m;
			this.numericUpDown7.Value = 50000m;
			this.numericUpDown6.Value = 1500m;
			this.ixboxConsole_0.XNotify("Quick Stats Set!");
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0002414C File Offset: 0x0002234C
		private void simpleButton64_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"customclass1 " + this.textEdit_10.Text
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"customclass2 " + this.textEdit_6.Text
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"customclass3 " + this.textEdit_7.Text
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"customclass4 " + this.textEdit_9.Text
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"customclass5 " + this.textEdit_8.Text
			});
			this.ixboxConsole_0.XNotify("Custom Class Names Set!");
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0002427C File Offset: 0x0002247C
		private void simpleButton69_Click(object sender, EventArgs e)
		{
			string str = Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "";
			this.textEdit_10.Text = "^1" + str;
			this.textEdit_6.Text = "^2" + str;
			this.textEdit_7.Text = "^3" + str;
			this.textEdit_9.Text = "^4" + str;
			this.textEdit_8.Text = "^5" + str;
			this.simpleButton64_Click(sender, null);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0002433C File Offset: 0x0002253C
		private void simpleButton70_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"motd " + this.textEdit_5.Text
			});
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00024380 File Offset: 0x00022580
		private void simpleButton66_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit1.SelectedIndex == 0)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"ui_mapname \"mp_backlot;motd ^1Infected ^2By ^3Guido's ^4Console ^5Tool ^1:);exec mp/unlock_init.cfg;updategamerprofile;uploadstats;wait 30;disconnect\""
				});
			}
			if (this.comboBoxEdit1.SelectedIndex == 1)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"ui_mapname \"mp_backlot;motd ^1Infected ^2By ^3Guido's ^4Console ^5Tool ^1:);clanname " + this.textEdit_138.Text + ";updategamerprofile;uploadstats;wait 30;disconnect\""
				});
			}
			if (this.comboBoxEdit1.SelectedIndex == 2)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"ui_mapname \"mp_backlot;motd ^1Infected ^2By ^3Guido's ^4Console ^5Tool ^1:);resetstats;updategamerprofile;uploadstats;wait 30;disconnect\""
				});
			}
			if (this.comboBoxEdit1.SelectedIndex == 3)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"ui_mapname \"mp_backlot;motd ^1Infected ^2BY ^3Guido's ^4Console ^5Tool ^1:);statset 2326 10;statset 2301 1253874;updategamerprofile;uploadstats;wait 30;disconnect\""
				});
			}
			if (this.comboBoxEdit1.SelectedIndex == 4)
			{
				string text = this.textEdit_137.Text;
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					string.Concat(new string[]
					{
						"ui_mapname \"mp_backlot;motd ^1Infected ^2By ^3Guido's ^4Console ^5Tool ^1:);customclass1 ",
						text,
						";customclass2 ",
						text,
						";customclass3 ",
						text,
						";customclass4 ",
						text,
						";customclass5 ",
						text,
						";updategamerprofile;uploadstats;wait 30;disconnect\""
					})
				});
			}
			this.ixboxConsole_0.XNotify("Infection Created Successfully! Start a split screen match to finalize");
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00024528 File Offset: 0x00022728
		private void simpleButton227_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				"disconnect"
			});
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0002455C File Offset: 0x0002275C
		private void simpleButton226_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				"xpartygo"
			});
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00024590 File Offset: 0x00022790
		private void simpleButton225_Click(object sender, EventArgs e)
		{
			if (this.simpleButton225.Text == "Force Host [OFF]")
			{
				this.simpleButton225.Text = "Force Host [ON]";
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"party_connectToOthers 00; partyMigrate_disabled 01; sv_endGameIfISuck 0; badhost_endgameifisuck 0​; set allowAllNAT 1"
				});
			}
			else
			{
				this.simpleButton225.Text = "Force Host [OFF]";
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"party_connectToOthers 01; partyMigrate_disabled 00"
				});
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00024624 File Offset: 0x00022824
		private void simpleButton224_Click(object sender, EventArgs e)
		{
			if (this.simpleButton224.Text == "Laser [OFF]")
			{
				this.simpleButton224.Text = "Laser [ON]";
				this.ixboxConsole_0.SetMemory(2182103187U, new byte[]
				{
					1
				});
			}
			else
			{
				this.simpleButton224.Text = "Laser [OFF]";
				byte[] data = new byte[1];
				this.ixboxConsole_0.SetMemory(2182103187U, data);
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000246A0 File Offset: 0x000228A0
		private void simpleButton223_Click(object sender, EventArgs e)
		{
			try
			{
				this.ixboxConsole_0.SetMemory(2182484368U, new byte[]
				{
					47,
					3,
					0,
					18,
					64,
					152,
					254,
					232
				});
				this.ixboxConsole_0.XNotify("Patch Remote Code Execution Loaded Successfully!");
			}
			catch (Exception)
			{
				this.ixboxConsole_0.XNotify("Failed To Load Patch!");
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000077B0 File Offset: 0x000059B0
		private void method_11(object sender, EventArgs e)
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00024704 File Offset: 0x00022904
		private void simpleButton204_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				"set xblive_privatematch \"1\""
			});
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				"set xblive_rankedmatch \"0\""
			});
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				"set ui_allow_teamchange"
			});
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				"set xblive_rankedmatch \"1\""
			});
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				"set xblive_rankedmatch \"0\""
			});
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000247D4 File Offset: 0x000229D4
		private void simpleButton203_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton203.Text == "Big Map [OFF]"))
			{
				this.simpleButton203.Text = "Big Map [OFF]";
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"set compassSize 1\""
				});
			}
			else
			{
				this.simpleButton203.Text = "Big Map [ON]";
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"set compassSize 1.5\""
				});
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000077B0 File Offset: 0x000059B0
		private void method_12(object sender, EventArgs e)
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00024868 File Offset: 0x00022A68
		private void simpleButton213_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				"cmd mr " + this.ixboxConsole_0.ReadInt32(2187474912U).ToString() + " -1 endround"
			});
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000248C0 File Offset: 0x00022AC0
		private void simpleButton201_Click(object sender, EventArgs e)
		{
			if (this.simpleButton201.Text == "No Recoil [OFF]")
			{
				this.simpleButton201.Text = "No Recoil [ON]";
				byte[] data = new byte[1];
				this.ixboxConsole_0.SetMemory(2182306787U, data);
			}
			else
			{
				this.simpleButton201.Text = "No Recoil [OFF]";
				this.ixboxConsole_0.SetMemory(2182306787U, new byte[]
				{
					7
				});
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0002493C File Offset: 0x00022B3C
		private void simpleButton215_Click(object sender, EventArgs e)
		{
			if (this.simpleButton215.Text == "UAV [OFF]")
			{
				this.simpleButton215.Text = "UAV [ON]";
				this.ixboxConsole_0.SetMemory(2182017324U, new byte[]
				{
					59,
					160,
					0,
					1
				});
			}
			else
			{
				this.simpleButton215.Text = "UAV [OFF]";
				this.ixboxConsole_0.SetMemory(2182017324U, new byte[]
				{
					86,
					29,
					6,
					62
				});
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000249C4 File Offset: 0x00022BC4
		private void simpleButton202_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton202.Text == "ESP [OFF]"))
			{
				this.simpleButton202.Text = "ESP [OFF]";
				this.ixboxConsole_0.SetMemory(2182038068U, new byte[]
				{
					65,
					154,
					0,
					12
				});
				this.ixboxConsole_0.SetMemory(2182294320U, new byte[]
				{
					64,
					154,
					0,
					100
				});
				this.ixboxConsole_0.SetMemory(2182033312U, new byte[]
				{
					65,
					154,
					1,
					4
				});
				this.ixboxConsole_0.SetMemory(2182033364U, new byte[]
				{
					65,
					154,
					0,
					208
				});
				this.ixboxConsole_0.SetMemory(2182033440U, new byte[]
				{
					65,
					154,
					0,
					32
				});
			}
			else
			{
				this.simpleButton202.Text = "ESP [ON]";
				byte[] array = new byte[4];
				array[0] = 96;
				this.ixboxConsole_0.SetMemory(2182038068U, array);
				IXboxConsole console = this.ixboxConsole_0;
				array = new byte[4];
				array[0] = 96;
				console.SetMemory(2182294320U, array);
				IXboxConsole console2 = this.ixboxConsole_0;
				array = new byte[4];
				array[0] = 96;
				console2.SetMemory(2182033312U, array);
				IXboxConsole console3 = this.ixboxConsole_0;
				array = new byte[4];
				array[0] = 96;
				console3.SetMemory(2182033364U, array);
				IXboxConsole console4 = this.ixboxConsole_0;
				array = new byte[4];
				array[0] = 96;
				console4.SetMemory(2182033440U, array);
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00024B68 File Offset: 0x00022D68
		private void simpleButton210_Click(object sender, EventArgs e)
		{
			if (this.simpleButton210.Text == "No Sway [OFF]")
			{
				this.simpleButton210.Text = "No Sway [ON]";
				byte[] array = new byte[4];
				array[0] = 96;
				this.ixboxConsole_0.SetMemory(2181981564U, array);
				IXboxConsole console = this.ixboxConsole_0;
				array = new byte[4];
				array[0] = 96;
				console.SetMemory(2181978936U, array);
			}
			else
			{
				this.simpleButton210.Text = "No Sway [OFF]";
				this.ixboxConsole_0.SetMemory(2181981564U, new byte[]
				{
					75,
					byte.MaxValue,
					251,
					197
				});
				this.ixboxConsole_0.SetMemory(2181978936U, new byte[]
				{
					75,
					byte.MaxValue,
					234,
					169
				});
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00024C34 File Offset: 0x00022E34
		private void method_13(object sender, ElapsedEventArgs e)
		{
			Random random = new Random();
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				string.Concat(new string[]
				{
					"r_filmTweakInvert 1;r_filmTweakbrightness 2;r_filmusetweaks 1;r_filmTweakenable 1;r_filmtweakLighttint ",
					random.Next(0, 2).ToString(),
					" ",
					random.Next(0, 2).ToString(),
					" ",
					random.Next(0, 2).ToString(),
					" ",
					random.Next(0, 2).ToString(),
					";r_filmtweakdarktint ",
					random.Next(0, 2).ToString(),
					" ",
					random.Next(0, 2).ToString(),
					" ",
					random.Next(0, 2).ToString(),
					";"
				})
			});
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00024D50 File Offset: 0x00022F50
		private void simpleButton221_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton221.Text = (this.TimerEnabled ? "Disco Vision [ON]" : "Disco Vision [OFF]");
			Form1.DiscoTimer.Elapsed += this.method_13;
			Form1.DiscoTimer.AutoReset = true;
			Form1.DiscoTimer.Enabled = this.TimerEnabled;
			if (this.simpleButton221.Text == "Disco Vision [OFF]")
			{
				this.simpleButton218_Click(sender, null);
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00024DDC File Offset: 0x00022FDC
		private void method_14(object sender, ElapsedEventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				"toggle r_contrast 0 1"
			});
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00024E10 File Offset: 0x00023010
		private void simpleButton220_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton220.Text = ((!this.TimerEnabled) ? "Flash Vision [OFF]" : "Flash Vision [ON]");
			Form1.FlashTimer.Elapsed += this.method_14;
			Form1.FlashTimer.AutoReset = true;
			Form1.FlashTimer.Enabled = this.TimerEnabled;
			if (this.simpleButton220.Text == "Flash Vision [OFF]")
			{
				this.simpleButton218_Click(sender, null);
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00024E9C File Offset: 0x0002309C
		private void simpleButton218_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				"r_debugShader 0;r_fullbright 0;r_filmTweakInvert 0;r_filmTweakbrightness 0;r_filmusetweaks 0;r_filmTweakenable 0;r_filmtweakLighttint 1.1 1.05 0.85;r_filmtweakdarktint 0.7 0.85 1;"
			});
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				"scr_art_tweak 0;scr_art_tweak_message 0;r_glowUseTweaks 1;r_contrast 1;r_specularmap 0;"
			});
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00024EF8 File Offset: 0x000230F8
		private void simpleButton205_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				"userinfo \\xuid\\0000000000"
			});
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00024F2C File Offset: 0x0002312C
		private void simpleButton216_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				"cg_fov " + this.numericUpDown26.Value.ToString()
			});
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00024F7C File Offset: 0x0002317C
		private void simpleButton217_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				this.textEdit_30.Text
			});
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00024FB8 File Offset: 0x000231B8
		private void simpleButton219_Click(object sender, EventArgs e)
		{
			this.simpleButton218_Click(sender, null);
			if (this.comboBoxEdit8.SelectedIndex == 0)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"r_fullbright 0;r_specularmap 2;"
				});
			}
			if (this.comboBoxEdit8.SelectedIndex == 1)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"r_fullbright 1;"
				});
			}
			if (this.comboBoxEdit8.SelectedIndex == 2)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"r_debugShader 1;"
				});
			}
			if (this.comboBoxEdit8.SelectedIndex == 3)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"scr_art_tweak 1;scr_art_tweak_message 1;r_glowUseTweaks 1;r_filmUseTweaks 1;"
				});
			}
			if (this.comboBoxEdit8.SelectedIndex == 4)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"toggle r_filmTweakInvert 1 0;toggle r_filmTweakbrightness 2 0;toggle r_filmusetweaks 1 0;toggle r_filmTweakenable 1 0;toggle r_filmtweakLighttint 1.06 0.5 1.3 0"
				});
			}
			if (this.comboBoxEdit8.SelectedIndex == 5)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"r_filmTweakInvert 1;r_filmTweakbrightness 2;r_filmusetweaks 1;r_filmTweakenable 1;r_filmtweakLighttint 1 2 1 1.1;r_filmtweakdarktint 1 2 1;"
				});
			}
			if (this.comboBoxEdit8.SelectedIndex == 6)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"r_filmTweakInvert 1;r_filmusetweaks 1;r_filmtweakenable 1;r_filmTweakLightTint 5.3 6.3 7.2;"
				});
			}
			if (this.comboBoxEdit8.SelectedIndex == 7)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"r_filmTweakInvert 1;r_filmTweakbrightness 2;r_filmusetweaks 1;r_filmTweakenable 1;r_filmtweakLighttint 1 2 1 1.1;r_filmtweakdarktint 0 0 2;"
				});
			}
			if (this.comboBoxEdit8.SelectedIndex == 8)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"r_filmTweakInvert 1;r_filmTweakbrightness 2;r_filmusetweaks 1;r_filmTweakenable 1;r_filmtweakLighttint 1 2 1 1.1;r_filmtweakdarktint 0 1 2;"
				});
			}
			if (this.comboBoxEdit8.SelectedIndex == 9)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"r_filmTweakInvert 1;r_filmTweakbrightness 2;r_filmusetweaks 1;r_filmTweakenable 1;r_filmtweakLighttint 0 0 0 0;r_filmtweakdarktint 0 0 0;"
				});
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000251F4 File Offset: 0x000233F4
		private void simpleButton208_Click(object sender, EventArgs e)
		{
			this.simpleButton201.Text = "No Recoil [ON]";
			byte[] array = new byte[1];
			this.ixboxConsole_0.SetMemory(2182306787U, array);
			this.simpleButton215.Text = "UAV [ON]";
			this.ixboxConsole_0.SetMemory(2182017324U, new byte[]
			{
				59,
				160,
				0,
				1
			});
			this.simpleButton202.Text = "ESP [ON]";
			byte[] array2 = new byte[4];
			array2[0] = 96;
			this.ixboxConsole_0.SetMemory(2182038068U, array2);
			IXboxConsole console = this.ixboxConsole_0;
			array = new byte[4];
			array[0] = 96;
			console.SetMemory(2182294320U, array);
			IXboxConsole console2 = this.ixboxConsole_0;
			array = new byte[4];
			array[0] = 96;
			console2.SetMemory(2182033312U, array);
			IXboxConsole console3 = this.ixboxConsole_0;
			array = new byte[4];
			array[0] = 96;
			console3.SetMemory(2182033364U, array);
			IXboxConsole console4 = this.ixboxConsole_0;
			array = new byte[4];
			array[0] = 96;
			console4.SetMemory(2182033440U, array);
			this.simpleButton224.Text = "Laser [ON]";
			this.ixboxConsole_0.SetMemory(2182103187U, new byte[]
			{
				1
			});
			this.simpleButton210.Text = "No Sway [ON]";
			byte[] array3 = new byte[4];
			array3[0] = 96;
			this.ixboxConsole_0.SetMemory(2181981564U, array3);
			array = new byte[4];
			array[0] = 96;
			console.SetMemory(2181978936U, array);
			this.ixboxConsole_0.XNotify("All Offhost Cheats set!");
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000253A4 File Offset: 0x000235A4
		private void simpleButton184_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.WriteString(2206967844U, this.textEdit_29.Text);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000253CC File Offset: 0x000235CC
		private void simpleButton183_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				string.Concat(new string[]
				{
					"userinfo \"\\clanabbrev\\",
					this.textEdit_31.Text,
					"\\name\\",
					this.textEdit_32.Text,
					"\\xuid\\"
				})
			});
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000253A4 File Offset: 0x000235A4
		private void method_15(object sender, ElapsedEventArgs e)
		{
			this.ixboxConsole_0.WriteString(2206967844U, this.textEdit_29.Text);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0002543C File Offset: 0x0002363C
		private void checkEdit1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkEdit1.Checked)
			{
				Form1.timer4.Elapsed += this.method_15;
				Form1.timer4.AutoReset = true;
				Form1.timer4.Enabled = true;
			}
			else
			{
				Form1.timer4.Enabled = false;
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00025490 File Offset: 0x00023690
		public static string RandomShitGamertag(int length)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Random random = new Random();
			for (int i = 0; i < length; i++)
			{
				int index = random.Next("0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%&*()-+=[]{};:.,></?".Length);
				stringBuilder.Append("0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%&*()-+=[]{};:.,></?"[index]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000254F0 File Offset: 0x000236F0
		private void method_16(object sender, ElapsedEventArgs e)
		{
			string @string = Form1.RandomShitGamertag(32);
			this.ixboxConsole_0.WriteString(2206967844U, @string);
			Thread.Sleep(20);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00025520 File Offset: 0x00023720
		private void checkEdit2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkEdit2.Checked)
			{
				Form1.timer5.Elapsed += this.method_16;
				Form1.timer5.AutoReset = true;
				Form1.timer5.Enabled = this.TimerEnabled;
			}
			else
			{
				Form1.timer5.Enabled = false;
				this.ixboxConsole_0.WriteString(2206967844U, this.textEdit_29.Text);
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00025594 File Offset: 0x00023794
		private void method_17(object sender, ElapsedEventArgs e)
		{
			this.ixboxConsole_0.WriteString(2206967844U, "");
			Thread.Sleep(125);
			this.ixboxConsole_0.WriteString(2206967844U, this.textEdit_29.Text);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000255D8 File Offset: 0x000237D8
		private void checkEdit3_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.checkEdit3.Checked)
			{
				Form1.timer5.Enabled = false;
				this.ixboxConsole_0.WriteString(2206967844U, this.textEdit_29.Text);
			}
			else
			{
				Form1.timer3.Elapsed += this.method_17;
				Form1.timer3.AutoReset = true;
				Form1.timer3.Enabled = this.TimerEnabled;
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0002564C File Offset: 0x0002384C
		public static int rainbowgt(string s)
		{
			int num = 0;
			foreach (char c in s)
			{
				num++;
			}
			return num;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0002568C File Offset: 0x0002388C
		private void method_18(object sender, ElapsedEventArgs e)
		{
			int num = new Random().Next(1, 9);
			if (Form1.rainbowgt("^" + num.ToString() + this.textEdit_29.Text) < 31)
			{
				this.ixboxConsole_0.WriteString(2206967844U, "^" + num.ToString() + this.textEdit_29.Text);
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00025704 File Offset: 0x00023904
		private void simpleButton199_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton199.Text = ((!this.TimerEnabled) ? "Rainbow GT Pregame [OFF]" : "Rainbow GT Pregame [ON]");
			Form1.flashgtmw2.Elapsed += this.method_4;
			Form1.flashgtmw2.AutoReset = true;
			Form1.flashgtmw2.Enabled = this.TimerEnabled;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00025770 File Offset: 0x00023970
		private void method_19(object sender, ElapsedEventArgs e)
		{
			int num = new Random().Next(1, 9);
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				string.Concat(new string[]
				{
					"userinfo \"\\clanabbrev\\^",
					num.ToString(),
					"\\name\\",
					this.textEdit_29.Text,
					"\\xuid\\"
				})
			});
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000257EC File Offset: 0x000239EC
		private void simpleButton198_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton198.Text = (this.TimerEnabled ? "Rainbow Gamertag In-Game [ON]" : "Rainbow Gamertag In-Game [OFF]");
			Form1.timer15.Elapsed += this.method_19;
			Form1.timer15.AutoReset = true;
			Form1.timer15.Enabled = this.TimerEnabled;
			if (this.simpleButton198.Text == "Rainbow Gamertag In-Game [OFF]")
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"userinfo \"\\clanabbrev\\\\name\\" + this.textEdit_29.Text + "\\xuid\\"
				});
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000258AC File Offset: 0x00023AAC
		private void simpleButton200_Click(object sender, EventArgs e)
		{
			this.textEdit_29.Text = (Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "");
			this.textEdit_32.Text = (Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "");
			this.simpleButton184_Click(sender, null);
			this.simpleButton183_Click(sender, null);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0002594C File Offset: 0x00023B4C
		private void method_20(string string_3)
		{
			this.ixboxConsole_0.CallVoid(2183647120U, new object[]
			{
				0,
				string_3
			});
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0002597C File Offset: 0x00023B7C
		private void simpleButton626_Click(object sender, EventArgs e)
		{
			this.method_20(this.textEdit_139.Text);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0002599C File Offset: 0x00023B9C
		private void simpleButton625_Click(object sender, EventArgs e)
		{
			this.method_20("noclip");
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000259B4 File Offset: 0x00023BB4
		private void simpleButton624_Click(object sender, EventArgs e)
		{
			this.method_20("ufo");
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000259CC File Offset: 0x00023BCC
		private void simpleButton623_Click(object sender, EventArgs e)
		{
			this.method_20("god");
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000259E4 File Offset: 0x00023BE4
		private void simpleButton622_Click(object sender, EventArgs e)
		{
			this.method_20("demigod");
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000259FC File Offset: 0x00023BFC
		private void simpleButton621_Click(object sender, EventArgs e)
		{
			this.method_20("toggle player_sustainammo");
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00025A14 File Offset: 0x00023C14
		private void simpleButton620_Click(object sender, EventArgs e)
		{
			this.method_20("give ammo");
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00025A2C File Offset: 0x00023C2C
		private void simpleButton619_Click(object sender, EventArgs e)
		{
			this.method_20("give all");
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00025A44 File Offset: 0x00023C44
		private void simpleButton618_Click(object sender, EventArgs e)
		{
			this.method_20("take all");
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00025A5C File Offset: 0x00023C5C
		private void simpleButton617_Click(object sender, EventArgs e)
		{
			this.method_20("fast_restart");
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00025A74 File Offset: 0x00023C74
		private void simpleButton345_Click(object sender, EventArgs e)
		{
			this.method_20("ai axis delete");
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00025A8C File Offset: 0x00023C8C
		private void simpleButton56_Click(object sender, EventArgs e)
		{
			this.method_20("cg_fov " + this.numericUpDown21.Value.ToString());
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00025AC0 File Offset: 0x00023CC0
		private void simpleButton214_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton214.Text == "Super Speed [OFF]"))
			{
				this.simpleButton214.Text = "Super Speed [OFF]";
				this.method_20("g_speed 165");
			}
			else
			{
				this.simpleButton214.Text = "Super Speed [ON]";
				this.method_20("g_speed 650");
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00025B1C File Offset: 0x00023D1C
		private void simpleButton100_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton100.Text == "Low Gravity [OFF]"))
			{
				this.simpleButton100.Text = "Low Gravity [OFF]";
				this.method_20("g_gravity 650");
			}
			else
			{
				this.simpleButton100.Text = "Low Gravity [ON]";
				this.method_20("g_gravity 125");
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00025B78 File Offset: 0x00023D78
		private void simpleButton222_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton222.Text == "Super Jump [OFF]"))
			{
				this.simpleButton222.Text = "Super Jump [OFF]";
				this.method_20("jump_height 39");
			}
			else
			{
				this.simpleButton222.Text = "Super Jump [ON]";
				this.method_20("jump_height 999");
				this.method_20("bg_fallDamageMinHeight 998");
				this.method_20("bg_fallDamageMaxHeight 999");
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00025BEC File Offset: 0x00023DEC
		private void simpleButton377_Click(object sender, EventArgs e)
		{
			if (this.simpleButton377.Text == "Godmode [OFF]")
			{
				this.simpleButton377.Text = "Godmode [ON]";
				this.ixboxConsole_0.WriteUInt32(2185381224U, 1610612736U);
			}
			else
			{
				this.simpleButton377.Text = "Godmode [OFF]";
				this.ixboxConsole_0.WriteUInt32(2185381224U, 2441019608U);
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00025C5C File Offset: 0x00023E5C
		private void simpleButton358_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton358.Text == "Unlimited Ammo [OFF]"))
			{
				this.simpleButton358.Text = "Unlimited Ammo [OFF]";
				this.ixboxConsole_0.WriteUInt32(2185613500U, 2432892928U);
			}
			else
			{
				this.simpleButton358.Text = "Unlimited Ammo [ON]";
				this.ixboxConsole_0.WriteUInt32(2185613500U, 1610612736U);
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00025CCC File Offset: 0x00023ECC
		private void simpleButton357_Click(object sender, EventArgs e)
		{
			if (this.simpleButton357.Text == "Unlimited Armor [OFF]")
			{
				this.simpleButton357.Text = "Unlimited Armor [ON]";
				this.ixboxConsole_0.WriteUInt32(2185382900U, 1610612736U);
			}
			else
			{
				this.simpleButton357.Text = "Unlimited Armor [OFF]";
				this.ixboxConsole_0.WriteUInt32(2185382900U, 2434668528U);
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00025D3C File Offset: 0x00023F3C
		private void simpleButton356_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(3283830596U, new byte[]
			{
				0,
				0,
				byte.MaxValue,
				byte.MaxValue
			});
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00025D70 File Offset: 0x00023F70
		private void simpleButton355_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(3255487360U, new byte[]
			{
				0,
				0,
				0,
				byte.MaxValue
			});
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00025D9C File Offset: 0x00023F9C
		private void simpleButton354_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(3255487368U, new byte[]
			{
				0,
				0,
				0,
				byte.MaxValue
			});
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00025DC8 File Offset: 0x00023FC8
		private void simpleButton386_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit19.SelectedIndex == 0)
			{
				this.ixboxConsole_0.SetMemory(2206863971U, new byte[1]);
			}
			if (this.comboBoxEdit19.SelectedIndex == 1)
			{
				this.ixboxConsole_0.SetMemory(2206863971U, new byte[]
				{
					1
				});
			}
			if (this.comboBoxEdit19.SelectedIndex == 5)
			{
				this.ixboxConsole_0.SetMemory(2206863971U, new byte[]
				{
					4
				});
			}
			if (this.comboBoxEdit19.SelectedIndex == 4)
			{
				this.ixboxConsole_0.SetMemory(2206863971U, new byte[]
				{
					5
				});
			}
			if (this.comboBoxEdit19.SelectedIndex == 3)
			{
				this.ixboxConsole_0.SetMemory(2206863971U, new byte[]
				{
					2
				});
			}
			if (this.comboBoxEdit19.SelectedIndex == 2)
			{
				this.ixboxConsole_0.SetMemory(2206863971U, new byte[]
				{
					3
				});
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00025ED0 File Offset: 0x000240D0
		private void simpleButton383_Click(object sender, EventArgs e)
		{
			int value = Convert.ToInt32(this.textEdit_129.Text);
			byte[] bytes = BitConverter.GetBytes(value);
			Array.Reverse(bytes);
			Array.Resize<byte>(ref bytes, bytes.Length);
			this.ixboxConsole_0.SetMemory(2181999906U, bytes);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00025F1C File Offset: 0x0002411C
		private void simpleButton382_Click(object sender, EventArgs e)
		{
			int value = Convert.ToInt32(this.textEdit_128.Text);
			byte[] bytes = BitConverter.GetBytes(value);
			Array.Reverse(bytes);
			Array.Resize<byte>(ref bytes, bytes.Length);
			this.ixboxConsole_0.SetMemory(2206532206U, bytes);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00025F68 File Offset: 0x00024168
		private void simpleButton379_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2206532131U, new byte[1]);
			this.ixboxConsole_0.SetMemory(2206532132U, new byte[1]);
			this.ixboxConsole_0.SetMemory(2206532133U, new byte[1]);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00025FB8 File Offset: 0x000241B8
		private void simpleButton343_Click(object sender, EventArgs e)
		{
			if (this.simpleButton343.Text == "No Gravity [OFF]")
			{
				this.simpleButton343.Text = "No Gravity [ON]";
				this.ixboxConsole_0.SetMemory(2210073184U, new byte[]
				{
					0,
					128
				});
				this.ixboxConsole_0.SetMemory(2210073188U, new byte[]
				{
					63,
					128
				});
			}
			else
			{
				this.simpleButton343.Text = "No Gravity [OFF]";
				this.ixboxConsole_0.SetMemory(2210073184U, new byte[]
				{
					0,
					128
				});
				this.ixboxConsole_0.SetMemory(2210073188U, new byte[]
				{
					191,
					128
				});
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00026084 File Offset: 0x00024284
		private void simpleButton342_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton342.Text == "Always Kart Boost [OFF]"))
			{
				this.simpleButton342.Text = "Always Kart Boost [OFF]";
				this.ixboxConsole_0.SetMemory(2209735947U, new byte[1]);
			}
			else
			{
				this.simpleButton342.Text = "Always Kart Boost [ON]";
				this.ixboxConsole_0.SetMemory(2209735947U, new byte[]
				{
					1
				});
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000260FC File Offset: 0x000242FC
		private void simpleButton385_Click(object sender, EventArgs e)
		{
			int value = Convert.ToInt32(this.textEdit_131.Text);
			byte[] bytes = BitConverter.GetBytes(value);
			Array.Reverse(bytes);
			Array.Resize<byte>(ref bytes, bytes.Length);
			this.ixboxConsole_0.SetMemory(2206532260U, bytes);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00026148 File Offset: 0x00024348
		private void simpleButton384_Click(object sender, EventArgs e)
		{
			int value = Convert.ToInt32(this.textEdit_130.Text);
			byte[] bytes = BitConverter.GetBytes(value);
			Array.Reverse(bytes);
			Array.Resize<byte>(ref bytes, bytes.Length);
			this.ixboxConsole_0.SetMemory(2206532248U, bytes);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00026194 File Offset: 0x00024394
		private void simpleButton381_Click(object sender, EventArgs e)
		{
			int value = Convert.ToInt32(this.textEdit_127.Text);
			byte[] bytes = BitConverter.GetBytes(value);
			Array.Reverse(bytes);
			Array.Resize<byte>(ref bytes, bytes.Length);
			this.ixboxConsole_0.SetMemory(2206532205U, bytes);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000261E0 File Offset: 0x000243E0
		private void simpleButton380_Click(object sender, EventArgs e)
		{
			int value = Convert.ToInt32(this.textEdit_126.Text);
			byte[] bytes = BitConverter.GetBytes(value);
			Array.Reverse(bytes);
			Array.Resize<byte>(ref bytes, bytes.Length);
			this.ixboxConsole_0.SetMemory(2181999578U, bytes);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0002622C File Offset: 0x0002442C
		private void simpleButton242_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183692136U, new object[]
			{
				0,
				"xpartygo"
			});
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00026260 File Offset: 0x00024460
		private void simpleButton207_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton207.Text == "Big Map [OFF]"))
			{
				this.simpleButton207.Text = "Big Map [OFF]";
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"compassSize 1"
				});
			}
			else
			{
				this.simpleButton207.Text = "Big Map [ON]";
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"compassSize 1.5"
				});
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000262F4 File Offset: 0x000244F4
		private void simpleButton240_Click(object sender, EventArgs e)
		{
			if (this.simpleButton240.Text == "Laser [OFF]")
			{
				this.simpleButton240.Text = "Laser [ON]";
				this.ixboxConsole_0.SetMemory(2182456000U, new byte[]
				{
					47,
					16,
					0,
					1
				});
			}
			else
			{
				this.simpleButton240.Text = "Laser [OFF]";
				byte[] array = new byte[4];
				array[0] = 47;
				array[1] = 16;
				this.ixboxConsole_0.SetMemory(2182456000U, array);
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00026384 File Offset: 0x00024584
		private void simpleButton238_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton238.Text == "No Fog [OFF]"))
			{
				this.simpleButton238.Text = "No Fog [OFF]";
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"r_fog 1"
				});
			}
			else
			{
				this.simpleButton238.Text = "No Fog [ON]";
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"r_fog 0"
				});
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00026418 File Offset: 0x00024618
		private void simpleButton228_Click(object sender, EventArgs e)
		{
			if (this.simpleButton228.Text == "No Spread [OFF]")
			{
				this.simpleButton228.Text = "No Spread [ON]";
				byte[] array = new byte[4];
				array[0] = 128;
				array[1] = 112;
				this.ixboxConsole_0.SetMemory(2181041000U, array);
			}
			else
			{
				this.simpleButton228.Text = "No Spread [OFF]";
				byte[] array2 = new byte[4];
				array2[0] = 67;
				array2[1] = 112;
				this.ixboxConsole_0.SetMemory(2181041000U, array2);
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000264B0 File Offset: 0x000246B0
		private void simpleButton211_Click(object sender, EventArgs e)
		{
			if (this.simpleButton211.Text == "No Recoil [OFF]")
			{
				this.simpleButton211.Text = "No Recoil [ON]";
				byte[] array = new byte[4];
				array[0] = 96;
				this.ixboxConsole_0.SetMemory(2182485204U, array);
			}
			else
			{
				this.simpleButton211.Text = "No Recoil [OFF]";
				this.ixboxConsole_0.SetMemory(2182485204U, new byte[]
				{
					75,
					250,
					3,
					149
				});
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00026538 File Offset: 0x00024738
		private void simpleButton231_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton231.Text == "UAV [OFF]"))
			{
				this.simpleButton231.Text = "UAV [OFF]";
			}
			else
			{
				this.simpleButton231.Text = "UAV [ON]";
				this.ixboxConsole_0.SetMemory(2182145420U, new byte[]
				{
					59,
					80,
					0,
					1
				});
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000265A0 File Offset: 0x000247A0
		private void simpleButton209_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton209.Text == "ESP [OFF]"))
			{
				this.simpleButton209.Text = "ESP [OFF]";
				this.ixboxConsole_0.SetMemory(2182173860U, new byte[]
				{
					65,
					154,
					0,
					12
				});
			}
			else
			{
				this.simpleButton209.Text = "ESP [ON]";
				byte[] array = new byte[4];
				array[0] = 96;
				this.ixboxConsole_0.SetMemory(2182173860U, array);
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00026628 File Offset: 0x00024828
		private void simpleButton232_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183692136U, new object[]
			{
				0,
				"cg_fov " + this.numericUpDown23.Value.ToString()
			});
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00026678 File Offset: 0x00024878
		private void simpleButton233_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183692136U, new object[]
			{
				0,
				this.textEdit_37.Text
			});
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000266B4 File Offset: 0x000248B4
		private void simpleButton235_Click(object sender, EventArgs e)
		{
			this.simpleButton234_Click(sender, null);
			if (this.comboBoxEdit7.SelectedIndex == 0)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"r_fullbright 0;r_specularmap 2;"
				});
			}
			if (this.comboBoxEdit7.SelectedIndex == 1)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"scr_art_tweak 1;scr_art_tweak_message 1;r_glowUseTweaks 1;r_filmUseTweaks 1;"
				});
			}
			if (this.comboBoxEdit7.SelectedIndex == 2)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"toggle r_filmTweakInvert 1 0;toggle r_filmTweakbrightness 2 0;toggle r_filmusetweaks 1 0;toggle r_filmTweakenable 1 0;toggle r_filmtweakLighttint 1.06 0.5 1.3 0"
				});
			}
			if (this.comboBoxEdit7.SelectedIndex == 3)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"r_filmTweakInvert 1;r_filmTweakbrightness 2;r_filmusetweaks 1;r_filmTweakenable 1;r_filmtweakLighttint 1 2 1 1.1;r_filmtweakdarktint 1 2 1;"
				});
			}
			if (this.comboBoxEdit7.SelectedIndex == 4)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"r_filmTweakInvert 1;r_filmusetweaks 1;r_filmtweakenable 1;r_filmTweakLightTint 5.3 6.3 7.2;"
				});
			}
			if (this.comboBoxEdit7.SelectedIndex == 5)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"r_filmTweakInvert 1;r_filmTweakbrightness 2;r_filmusetweaks 1;r_filmTweakenable 1;r_filmtweakLighttint 1 2 1 1.1;r_filmtweakdarktint 0 0 2;"
				});
			}
			if (this.comboBoxEdit7.SelectedIndex == 6)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"r_filmTweakInvert 1;r_filmTweakbrightness 2;r_filmusetweaks 1;r_filmTweakenable 1;r_filmtweakLighttint 1 2 1 1.1;r_filmtweakdarktint 0 1 2;"
				});
			}
			if (this.comboBoxEdit7.SelectedIndex == 7)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"r_filmTweakInvert 1;r_filmTweakbrightness 2;r_filmusetweaks 1;r_filmTweakenable 1;r_filmtweakLighttint 0 0 0 0;r_filmtweakdarktint 0 0 0;"
				});
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00026884 File Offset: 0x00024A84
		private void simpleButton234_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183692136U, new object[]
			{
				0,
				"r_debugShader 0;r_fullbright 0;r_filmTweakInvert 0;r_filmTweakbrightness 0;r_filmusetweaks 0;r_filmTweakenable 0;r_filmtweakLighttint 1.1 1.05 0.85;r_filmtweakdarktint 0.7 0.85 1;"
			});
			this.ixboxConsole_0.CallVoid(2183692136U, new object[]
			{
				0,
				"scr_art_tweak 0;scr_art_tweak_message 0;r_glowUseTweaks 1;r_contrast 1;r_specularmap 0;"
			});
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000268E0 File Offset: 0x00024AE0
		private void method_21(object sender, ElapsedEventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183692136U, new object[]
			{
				0,
				"toggle r_contrast 0 1"
			});
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00026914 File Offset: 0x00024B14
		private void simpleButton236_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton236.Text = (this.TimerEnabled ? "Flash Vision [ON]" : "Flash Vision [OFF]");
			Form1.FlashTimer.Elapsed += this.method_21;
			Form1.FlashTimer.AutoReset = true;
			Form1.FlashTimer.Enabled = this.TimerEnabled;
			if (this.simpleButton236.Text == "Flash Vision [OFF]")
			{
				this.simpleButton234_Click(sender, null);
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000269A0 File Offset: 0x00024BA0
		private void method_22(object sender, ElapsedEventArgs e)
		{
			Random random = new Random();
			this.ixboxConsole_0.CallVoid(2183692136U, new object[]
			{
				0,
				string.Concat(new string[]
				{
					"r_filmTweakInvert 1;r_filmTweakbrightness 2;r_filmusetweaks 1;r_filmTweakenable 1;r_filmtweakLighttint ",
					random.Next(0, 2).ToString(),
					" ",
					random.Next(0, 2).ToString(),
					" ",
					random.Next(0, 2).ToString(),
					" ",
					random.Next(0, 2).ToString(),
					";r_filmtweakdarktint ",
					random.Next(0, 2).ToString(),
					" ",
					random.Next(0, 2).ToString(),
					" ",
					random.Next(0, 2).ToString(),
					";"
				})
			});
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00026ABC File Offset: 0x00024CBC
		private void simpleButton237_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton237.Text = ((!this.TimerEnabled) ? "Disco Vision [OFF]" : "Disco Vision [ON]");
			Form1.DiscoTimer.Elapsed += this.method_22;
			Form1.DiscoTimer.AutoReset = true;
			Form1.DiscoTimer.Enabled = this.TimerEnabled;
			if (this.simpleButton237.Text == "Disco Vision [OFF]")
			{
				this.simpleButton234_Click(sender, null);
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00026B48 File Offset: 0x00024D48
		private void simpleButton212_Click(object sender, EventArgs e)
		{
			this.simpleButton211.Text = "No Recoil [ON]";
			byte[] array = new byte[4];
			array[0] = 96;
			this.ixboxConsole_0.SetMemory(2182485204U, array);
			this.simpleButton231.Text = "UAV [ON]";
			this.ixboxConsole_0.SetMemory(2182145420U, new byte[]
			{
				59,
				80,
				0,
				1
			});
			this.simpleButton209.Text = "ESP [ON]";
			byte[] array2 = new byte[4];
			array2[0] = 96;
			this.ixboxConsole_0.SetMemory(2182173860U, array2);
			this.simpleButton228.Text = "No Spread [ON]";
			byte[] array3 = new byte[4];
			array3[0] = 128;
			array3[1] = 112;
			this.ixboxConsole_0.SetMemory(2181041000U, array3);
			this.ixboxConsole_0.XNotify("All Offhost Cheats set!");
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00026C30 File Offset: 0x00024E30
		public string method_23(int client)
		{
			byte[] array = new byte[20];
			uint num;
			this.ixboxConsole_0.DebugTarget.GetMemory(Form1.getClientState(client) + Form1.playerStateInfo.getGamertags, 20U, array, out num);
			this.ixboxConsole_0.DebugTarget.InvalidateMemoryCache(true, Form1.getClientState(client) + Form1.playerStateInfo.getGamertags, 20U);
			return new ASCIIEncoding().GetString(array);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00026C98 File Offset: 0x00024E98
		public static uint getClientState(int client)
		{
			return Form1.playerState + Convert.ToUInt32(client) * Form1.playerStateInfo.difference;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00026CBC File Offset: 0x00024EBC
		private void simpleButton197_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
			for (int i = 0; i < 18; i++)
			{
				this.listBox1.Items.Add(i.ToString() + "= " + this.method_23(i));
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00026D18 File Offset: 0x00024F18
		private void method_24(int int_0)
		{
			byte[] data = new byte[]
			{
				2
			};
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.getClientState(int_0) + 13823U, 1U, data, out num);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00026D54 File Offset: 0x00024F54
		private void simpleButton206_Click(object sender, EventArgs e)
		{
			this.method_24(Convert.ToInt32(this.numericUpDown24.Value));
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00026D78 File Offset: 0x00024F78
		public void Thermal(int client)
		{
			this.ixboxConsole_0.SetMemory(Form1.getClientState(client) + 19U, new byte[]
			{
				24
			});
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00026DA4 File Offset: 0x00024FA4
		private void simpleButton229_Click(object sender, EventArgs e)
		{
			this.Thermal(Convert.ToInt32(this.numericUpDown25.Value));
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00026DC8 File Offset: 0x00024FC8
		private void method_25(int int_0)
		{
			byte[] data = new byte[]
			{
				byte.MaxValue
			};
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.getClientState(int_0) + 922U, 1U, data, out num);
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.getClientState(int_0) + 938U, 1U, data, out num);
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.getClientState(int_0) + 1066U, 1U, data, out num);
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.getClientState(int_0) + 1090U, 1U, data, out num);
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.getClientState(int_0) + 946U, 1U, data, out num);
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.getClientState(int_0) + 1042U, 1U, data, out num);
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.getClientState(int_0) + 1054U, 1U, data, out num);
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.getClientState(int_0) + 1078U, 1U, data, out num);
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.getClientState(int_0) + 1058U, 1U, data, out num);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00026F10 File Offset: 0x00025110
		private void simpleButton230_Click(object sender, EventArgs e)
		{
			this.method_25(Convert.ToInt32(this.numericUpDown27.Value));
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00026F34 File Offset: 0x00025134
		private void method_26(int int_0)
		{
			byte[] data = new byte[1];
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.getClientState(int_0) + 13823U, 1U, data, out num);
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.getClientState(int_0) + 19U, 1U, new byte[1], out num);
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.getClientState(int_0) + 1U, 1U, data, out num);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00026FAC File Offset: 0x000251AC
		private void simpleButton239_Click(object sender, EventArgs e)
		{
			this.method_26(Convert.ToInt32(this.numericUpDown29.Value));
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00026FD0 File Offset: 0x000251D0
		private void simpleButton241_Click(object sender, EventArgs e)
		{
			this.method_26(Convert.ToInt32(this.numericUpDown28.Value));
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00026FF4 File Offset: 0x000251F4
		private void simpleButton188_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.WriteString(2207682988U, this.textEdit_36.Text);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0002701C File Offset: 0x0002521C
		private void simpleButton187_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183692136U, new object[]
			{
				0,
				string.Concat(new string[]
				{
					"userinfo \"\\clanabbrev\\",
					this.textEdit_33.Text,
					"\\name\\",
					this.textEdit_34.Text,
					"\\xuid\\"
				})
			});
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0002708C File Offset: 0x0002528C
		private void method_27(object sender, ElapsedEventArgs e)
		{
			string text = this.textEdit_36.Text;
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(2207682988U, 20U, new byte[20], out num);
			this.ixboxConsole_0.DebugTarget.SetMemory(2207682988U, (uint)bytes.Length, bytes, out num);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000270F4 File Offset: 0x000252F4
		private void checkEdit6_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkEdit6.Checked)
			{
				Form1.mw3rtegt.Elapsed += this.method_27;
				Form1.mw3rtegt.AutoReset = true;
				Form1.mw3rtegt.Enabled = true;
			}
			else
			{
				Form1.mw3rtegt.Enabled = false;
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00027148 File Offset: 0x00025348
		private void method_28(object sender, ElapsedEventArgs e)
		{
			string s = "";
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(2207682988U, 20U, new byte[20], out num);
			this.ixboxConsole_0.DebugTarget.SetMemory(2207682988U, (uint)bytes.Length, bytes, out num);
			Thread.Sleep(125);
			string text = this.textEdit_36.Text;
			byte[] bytes2 = Encoding.UTF8.GetBytes(text);
			uint num2;
			this.ixboxConsole_0.DebugTarget.SetMemory(2207682988U, 20U, new byte[20], out num2);
			this.ixboxConsole_0.DebugTarget.SetMemory(2207682988U, (uint)bytes2.Length, bytes2, out num2);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00027208 File Offset: 0x00025408
		private void checkEdit4_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.checkEdit4.Checked)
			{
				Form1.flashgamertagmw3.Enabled = false;
				string text = this.textEdit_36.Text;
				byte[] bytes = Encoding.UTF8.GetBytes(text);
				uint num;
				this.ixboxConsole_0.DebugTarget.SetMemory(2207682988U, 20U, new byte[20], out num);
				this.ixboxConsole_0.DebugTarget.SetMemory(2207682988U, (uint)bytes.Length, bytes, out num);
			}
			else
			{
				Form1.flashgamertagmw3.Elapsed += this.method_28;
				Form1.flashgamertagmw3.AutoReset = true;
				Form1.flashgamertagmw3.Enabled = true;
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000272B4 File Offset: 0x000254B4
		private void method_29(object sender, ElapsedEventArgs e)
		{
			int num = new Random().Next(1, 9);
			if (Form1.rainbowgt("^" + num.ToString() + this.textEdit_36.Text) < 31)
			{
				string s = "^" + num.ToString() + this.textEdit_36.Text;
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				uint num2;
				this.ixboxConsole_0.DebugTarget.SetMemory(2207682988U, 20U, new byte[20], out num2);
				this.ixboxConsole_0.DebugTarget.SetMemory(2207682988U, (uint)bytes.Length, bytes, out num2);
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00027368 File Offset: 0x00025568
		private void simpleButton186_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton186.Text = ((!this.TimerEnabled) ? "Rainbow GT [OFF]" : "Rainbow GT [ON]");
			Form1.rainbowgtmw3timer.Elapsed += this.method_29;
			Form1.rainbowgtmw3timer.AutoReset = true;
			Form1.rainbowgtmw3timer.Enabled = this.TimerEnabled;
			if (this.simpleButton186.Text == "Rainbow GT [OFF]")
			{
				string text = this.textEdit_36.Text;
				byte[] bytes = Encoding.UTF8.GetBytes(text);
				uint num;
				this.ixboxConsole_0.DebugTarget.SetMemory(2207682988U, 20U, new byte[20], out num);
				this.ixboxConsole_0.DebugTarget.SetMemory(2207682988U, (uint)bytes.Length, bytes, out num);
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00027444 File Offset: 0x00025644
		private void simpleButton101_Click(object sender, EventArgs e)
		{
			this.textEdit_36.Text = (Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "");
			this.textEdit_34.Text = (Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "");
			this.simpleButton188_Click(sender, null);
			this.simpleButton187_Click(sender, null);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000274E4 File Offset: 0x000256E4
		public static byte[] ConvertInt32ToByteArray(int dec)
		{
			return BitConverter.GetBytes(dec);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x000274FC File Offset: 0x000256FC
		private void method_30()
		{
			int dec = Convert.ToInt32((uint)this.numericUpDown20.Value);
			byte[] data = Form1.ConvertInt32ToByteArray(dec);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.MW3Offsets.Prestige, 4U, data, out num);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00027544 File Offset: 0x00025744
		private void method_31()
		{
			int dec = Convert.ToInt32((uint)this.numericUpDown22.Value);
			byte[] data = Form1.ConvertInt32ToByteArray(dec);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.MW3Offsets.Experience, 4U, data, out num);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0002758C File Offset: 0x0002578C
		private void method_32()
		{
			int dec = Convert.ToInt32((uint)this.numericUpDown30.Value);
			byte[] data = Form1.ConvertInt32ToByteArray(dec);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.MW3Offsets.Score, 4U, data, out num);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000275D4 File Offset: 0x000257D4
		private void method_33()
		{
			int dec = Convert.ToInt32((uint)this.numericUpDown31.Value);
			byte[] data = Form1.ConvertInt32ToByteArray(dec);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.MW3Offsets.Kills, 4U, data, out num);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0002761C File Offset: 0x0002581C
		private void method_34()
		{
			int dec = Convert.ToInt32((uint)this.numericUpDown32.Value);
			byte[] data = Form1.ConvertInt32ToByteArray(dec);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.MW3Offsets.Deaths, 4U, data, out num);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00027664 File Offset: 0x00025864
		private void method_35()
		{
			int dec = Convert.ToInt32((uint)this.numericUpDown33.Value);
			byte[] data = Form1.ConvertInt32ToByteArray(dec);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.MW3Offsets.KDRatio, 4U, data, out num);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000276AC File Offset: 0x000258AC
		private void method_36()
		{
			int dec = Convert.ToInt32((uint)this.numericUpDown38.Value);
			byte[] data = Form1.ConvertInt32ToByteArray(dec);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.MW3Offsets.Wins, 4U, data, out num);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x000276F4 File Offset: 0x000258F4
		private void method_37()
		{
			int dec = Convert.ToInt32((uint)this.numericUpDown39.Value);
			byte[] data = Form1.ConvertInt32ToByteArray(dec);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.MW3Offsets.Losses, 4U, data, out num);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0002773C File Offset: 0x0002593C
		private void method_38()
		{
			int dec = Convert.ToInt32((uint)this.numericUpDown36.Value);
			byte[] data = Form1.ConvertInt32ToByteArray(dec);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.MW3Offsets.WinStreak, 4U, data, out num);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00027784 File Offset: 0x00025984
		private void method_39()
		{
			int dec = Convert.ToInt32((uint)this.numericUpDown37.Value);
			byte[] data = Form1.ConvertInt32ToByteArray(dec);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.MW3Offsets.Ties, 4U, data, out num);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000277CC File Offset: 0x000259CC
		private void method_40()
		{
			int dec = Convert.ToInt32((uint)this.numericUpDown26.Value);
			byte[] data = Form1.ConvertInt32ToByteArray(dec);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.MW3Offsets.HeadShots, 4U, data, out num);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00027814 File Offset: 0x00025A14
		private void method_41()
		{
			int dec = Convert.ToInt32((uint)this.numericUpDown34.Value);
			byte[] data = Form1.ConvertInt32ToByteArray(dec);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.MW3Offsets.Hits, 4U, data, out num);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0002785C File Offset: 0x00025A5C
		private void method_42()
		{
			int dec = Convert.ToInt32((uint)this.numericUpDown35.Value);
			byte[] data = Form1.ConvertInt32ToByteArray(dec);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.MW3Offsets.Misses, 4U, data, out num);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000278A4 File Offset: 0x00025AA4
		private void method_43()
		{
			int dec = Convert.ToInt32((uint)this.numericUpDown40.Value);
			byte[] data = Form1.ConvertInt32ToByteArray(dec);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.MW3Offsets.Accuracy, 4U, data, out num);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000278EC File Offset: 0x00025AEC
		private void method_44()
		{
			int dec = Convert.ToInt32((uint)this.numericUpDown41.Value);
			byte[] data = Form1.ConvertInt32ToByteArray(dec);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.MW3Offsets.Assists, 4U, data, out num);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00027934 File Offset: 0x00025B34
		private void method_45()
		{
			int dec = Convert.ToInt32((uint)this.numericUpDown42.Value);
			byte[] data = Form1.ConvertInt32ToByteArray(dec);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.MW3Offsets.KillStreak, 4U, data, out num);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0002797C File Offset: 0x00025B7C
		private void Tokens()
		{
			int dec = Convert.ToInt32((uint)this.numericUpDown43.Value);
			byte[] data = Form1.ConvertInt32ToByteArray(dec);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.MW3Offsets.PrestigeTokens, 4U, data, out num);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000279C4 File Offset: 0x00025BC4
		private void method_46()
		{
			int dec = Convert.ToInt32((uint)this.numericUpDown44.Value);
			byte[] data = Form1.ConvertInt32ToByteArray(dec);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.MW3Offsets.DoubleXP, 4U, data, out num);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00027A0C File Offset: 0x00025C0C
		private void method_47()
		{
			int dec = Convert.ToInt32((uint)this.numericUpDown45.Value);
			byte[] data = Form1.ConvertInt32ToByteArray(dec);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.MW3Offsets.DoubleWeaponXP, 4U, data, out num);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00027A54 File Offset: 0x00025C54
		private void method_48()
		{
			int dec = Convert.ToInt32((uint)this.numericUpDown46.Value);
			byte[] data = Form1.ConvertInt32ToByteArray(dec);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(Form1.MW3Offsets.TimePlayed, 4U, data, out num);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00027A9C File Offset: 0x00025C9C
		private void simpleButton195_Click(object sender, EventArgs e)
		{
			this.method_30();
			this.method_31();
			this.method_32();
			this.method_33();
			this.method_34();
			this.method_35();
			this.method_36();
			this.method_37();
			this.method_38();
			this.method_39();
			this.method_40();
			this.method_41();
			this.method_42();
			this.method_43();
			this.method_44();
			this.method_45();
			this.Tokens();
			this.method_46();
			this.method_47();
			this.method_48();
			this.ixboxConsole_0.XNotify("Set All Stats");
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00027B34 File Offset: 0x00025D34
		private void simpleButton269_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"disconnect"
			});
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00027B68 File Offset: 0x00025D68
		private void simpleButton272_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[4];
			array[0] = 96;
			this.ixboxConsole_0.SetMemory(2185110352U, array);
			IXboxConsole console = this.ixboxConsole_0;
			byte[] array2 = new byte[4];
			array2[0] = 96;
			console.SetMemory(2185110376U, array2);
			IXboxConsole console2 = this.ixboxConsole_0;
			byte[] array3 = new byte[4];
			array3[0] = 96;
			console2.SetMemory(2185110400U, array3);
			if (!(this.simpleButton272.Text == "No Recoil [OFF]"))
			{
				this.simpleButton272.Text = "No Recoil [OFF]";
				this.ixboxConsole_0.SetMemory(2183296548U, new byte[]
				{
					75,
					246,
					126,
					197
				});
			}
			else
			{
				this.simpleButton272.Text = "No Recoil [ON]";
				byte[] array4 = new byte[4];
				array4[0] = 96;
				this.ixboxConsole_0.SetMemory(2183296548U, array4);
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00027C58 File Offset: 0x00025E58
		private void simpleButton284_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton284.Text == "UAV [OFF]"))
			{
				this.simpleButton284.Text = "UAV [OFF]";
				this.ixboxConsole_0.WriteByte(2182775199U, 0);
			}
			else
			{
				this.simpleButton284.Text = "UAV [ON]";
				this.ixboxConsole_0.WriteByte(2182775199U, 1);
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00027CC0 File Offset: 0x00025EC0
		private void simpleButton273_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"userinfo \"\\name\\^6GCT\\clanabbrev\\^1\\xuid\\1E0200F003F252F7\\invited\\1\""
			});
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00027CF4 File Offset: 0x00025EF4
		private void simpleButton270_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"set party_minplayers 1;xpartygo"
			});
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00027D28 File Offset: 0x00025F28
		private void simpleButton271_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton271.Text == "Force Host [OFF]"))
			{
				this.simpleButton271.Text = "Force Host [OFF]";
				this.ixboxConsole_0.CallVoid(2184440024U, new object[]
				{
					0,
					"set party_minplayers 8;set party_gamestarttimelength 10;set party_pregamestarttimerlength 10;set party_connectTimeout 2500"
				});
			}
			else
			{
				this.simpleButton271.Text = "Force Host [ON]";
				this.ixboxConsole_0.CallVoid(2184440024U, new object[]
				{
					0,
					"set party_connectToOthers 0;set party_minplayers 1;set party_gamestarttimelength 1;set party_pregamestarttimerlength 1;set party_connectTimeout 1"
				});
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00027DBC File Offset: 0x00025FBC
		private void simpleButton278_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton278.Text == "ESP [OFF]"))
			{
				this.simpleButton278.Text = "ESP [OFF]";
				byte[] data = new byte[1];
				this.ixboxConsole_0.SetMemory(2182980139U, data);
			}
			else
			{
				this.simpleButton278.Text = "ESP [ON]";
				byte[] data2 = new byte[]
				{
					1
				};
				this.ixboxConsole_0.SetMemory(2182980139U, data2);
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00027E3C File Offset: 0x0002603C
		private void simpleButton274_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				this.textEdit_53.Text
			});
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00027E78 File Offset: 0x00026078
		private void simpleButton331_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"set cg_fov 90"
			});
			this.textEdit_53.Text = "set cg_fov 90";
			this.simpleButton272.Text = "No Recoil [ON]";
			byte[] array = new byte[4];
			array[0] = 96;
			this.ixboxConsole_0.SetMemory(2183296548U, array);
			this.simpleButton272.Text = "UAV [ON]";
			this.ixboxConsole_0.WriteByte(2182775199U, 1);
			this.simpleButton278.Text = "ESP [ON]";
			byte[] data = new byte[]
			{
				1
			};
			this.ixboxConsole_0.SetMemory(2182980139U, data);
			this.ixboxConsole_0.XNotify("All Offhost Cheats set!");
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00027F4C File Offset: 0x0002614C
		public uint getBO1PlayerState(int client)
		{
			return 2198054408U + Convert.ToUInt32(client) * 10792U;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00027F70 File Offset: 0x00026170
		public string getBO1Clients(int client)
		{
			byte[] memory = this.ixboxConsole_0.GetMemory(this.getBO1PlayerState(client) + 10232U, 20U);
			memory.Reverse<byte>();
			return Encoding.ASCII.GetString(memory);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00027FB4 File Offset: 0x000261B4
		private void simpleButton303_Click(object sender, EventArgs e)
		{
			this.listBox2.Items.Clear();
			for (int i = 0; i < 18; i++)
			{
				this.listBox2.Items.Add(i.ToString() + "= " + this.getBO1Clients(i));
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00028010 File Offset: 0x00026210
		private void simpleButton309_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.XNotify("Restarting Game!");
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"fast_restart"
			});
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00028054 File Offset: 0x00026254
		public void godmodeon(int int_18)
		{
			this.ixboxConsole_0.SetMemory(this.modhelper(int_18) + 23U, new byte[]
			{
				5
			});
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00028080 File Offset: 0x00026280
		private void method_49(int int_0)
		{
			this.ixboxConsole_0.SetMemory(this.modhelper(int_0) + 23U, new byte[]
			{
				4
			});
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000280AC File Offset: 0x000262AC
		public void ufoon(int int_18)
		{
			this.ixboxConsole_0.SetMemory(this.modhelper(int_18) + 10471U, new byte[]
			{
				2
			});
		}

		// Token: 0x06000213 RID: 531 RVA: 0x000280DC File Offset: 0x000262DC
		public void ufooff(int int_18)
		{
			this.ixboxConsole_0.SetMemory(this.modhelper(int_18) + 10471U, new byte[1]);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00028108 File Offset: 0x00026308
		public uint modhelper(int int_18)
		{
			return 2198054408U + Convert.ToUInt32(int_18) * 10792U;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0002812C File Offset: 0x0002632C
		private void simpleButton302_Click(object sender, EventArgs e)
		{
			this.ufoon(this.listBox2.SelectedIndex);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0002814C File Offset: 0x0002634C
		private void simpleButton304_Click(object sender, EventArgs e)
		{
			this.godmodeon(this.listBox2.SelectedIndex);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0002816C File Offset: 0x0002636C
		private void simpleButton300_Click(object sender, EventArgs e)
		{
			this.ufooff(this.listBox2.SelectedIndex);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0002818C File Offset: 0x0002638C
		private void simpleButton299_Click(object sender, EventArgs e)
		{
			this.method_49(this.listBox2.SelectedIndex);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000281AC File Offset: 0x000263AC
		private void simpleButton305_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184597016U, new object[]
			{
				-1,
				0,
				"w \"" + this.textEdit_52.Text + "\""
			});
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00028200 File Offset: 0x00026400
		private void simpleButton312_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184597016U, new object[]
			{
				-1,
				0,
				"v " + this.textEdit_50.Text
			});
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00028250 File Offset: 0x00026450
		private void simpleButton308_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184597016U, new object[]
			{
				-1,
				0,
				"e \"" + this.textEdit_51.Text + "\""
			});
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000282A4 File Offset: 0x000264A4
		private void simpleButton307_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184597016U, new object[]
			{
				-1,
				0,
				"c \"" + this.textEdit_51.Text + "\""
			});
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000282F8 File Offset: 0x000264F8
		private void simpleButton306_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"say " + this.textEdit_51.Text
			});
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0002833C File Offset: 0x0002653C
		private void simpleButton310_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit10.SelectedIndex == 0)
			{
				this.ixboxConsole_0.CallVoid(2184597016U, new object[]
				{
					this.listBox2.SelectedIndex,
					0,
					"v cg_fov 1"
				});
			}
			if (this.comboBoxEdit10.SelectedIndex == 1)
			{
				this.ixboxConsole_0.CallVoid(2184597016U, new object[]
				{
					this.listBox2.SelectedIndex,
					0,
					"v cg_drawfps 1"
				});
			}
			if (this.comboBoxEdit10.SelectedIndex == 2)
			{
				this.ixboxConsole_0.CallVoid(2184597016U, new object[]
				{
					-1,
					0,
					"v g_speed 0"
				});
			}
			if (this.comboBoxEdit10.SelectedIndex == 3)
			{
				this.ixboxConsole_0.CallVoid(2184597016U, new object[]
				{
					this.listBox2.SelectedIndex,
					0,
					"v cg_thirdperson 1"
				});
			}
			if (this.comboBoxEdit10.SelectedIndex == 4)
			{
				this.ixboxConsole_0.CallVoid(2184597016U, new object[]
				{
					-1,
					0,
					"v bg_gravity 1"
				});
			}
			if (this.comboBoxEdit10.SelectedIndex == 5)
			{
				this.ixboxConsole_0.CallVoid(2184597016U, new object[]
				{
					-1,
					0,
					"v compassSize 0.1"
				});
			}
			if (this.comboBoxEdit10.SelectedIndex == 6)
			{
				this.ixboxConsole_0.CallVoid(2184597016U, new object[]
				{
					-1,
					0,
					"v compassSize 160"
				});
			}
			if (this.comboBoxEdit10.SelectedIndex == 7)
			{
				this.ixboxConsole_0.CallVoid(2184597016U, new object[]
				{
					this.listBox2.SelectedIndex,
					0,
					"v cg_fov 160;v cg_fovscale 2"
				});
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00028574 File Offset: 0x00026774
		private void simpleButton311_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184597016U, new object[]
			{
				-1,
				0,
				"v cg_fovscale 1;v cg_fov 65;v cg_drawfps 0;v compasssize 1;v cg_thirdperson 0;v g_speed 165;v bg_gravity 800"
			});
			this.ixboxConsole_0.XNotify("Undid all DVARS!");
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000285C4 File Offset: 0x000267C4
		private void simpleButton285_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184248664U, new object[]
			{
				0,
				this.textEdit_54.Text
			});
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00028600 File Offset: 0x00026800
		private void simpleButton288_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184248664U, new object[]
			{
				0,
				"noclip"
			});
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00028634 File Offset: 0x00026834
		private void simpleButton290_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184248664U, new object[]
			{
				0,
				"notarget"
			});
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00028668 File Offset: 0x00026868
		private void simpleButton292_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184248664U, new object[]
			{
				0,
				"god"
			});
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0002869C File Offset: 0x0002689C
		private void simpleButton294_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184248664U, new object[]
			{
				0,
				"demigod"
			});
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000286D0 File Offset: 0x000268D0
		private void simpleButton296_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184248664U, new object[]
			{
				0,
				"ai axis delete"
			});
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00028704 File Offset: 0x00026904
		private void simpleButton289_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184248664U, new object[]
			{
				0,
				"ufo"
			});
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00028738 File Offset: 0x00026938
		private void simpleButton291_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184248664U, new object[]
			{
				0,
				"ai_disableSpawn"
			});
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0002876C File Offset: 0x0002696C
		private void simpleButton293_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184248664U, new object[]
			{
				0,
				"give ammo"
			});
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000287A0 File Offset: 0x000269A0
		private void simpleButton315_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184248664U, new object[]
			{
				0,
				"fast_restart"
			});
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000287D4 File Offset: 0x000269D4
		private void simpleButton297_Click(object sender, EventArgs e)
		{
			if (this.simpleButton297.Text == "No Teddybear [OFF]")
			{
				this.simpleButton297.Text = "No Teddybear [ON]";
				this.ixboxConsole_0.CallVoid(2184248664U, new object[]
				{
					0,
					"magic_chest_movable 0"
				});
			}
			else
			{
				this.simpleButton297.Text = "No Teddybear [OFF]";
				this.ixboxConsole_0.CallVoid(2184248664U, new object[]
				{
					0,
					"magic_chest_movable 1"
				});
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00028868 File Offset: 0x00026A68
		private void simpleButton298_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton298.Text == "Super Speed [OFF]"))
			{
				this.simpleButton298.Text = "Super Speed [OFF]";
				this.ixboxConsole_0.CallVoid(2184248664U, new object[]
				{
					0,
					"g_speed 165"
				});
			}
			else
			{
				this.simpleButton298.Text = "Super Speed [ON]";
				this.ixboxConsole_0.CallVoid(2184248664U, new object[]
				{
					0,
					"g_speed 650"
				});
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000288FC File Offset: 0x00026AFC
		private void simpleButton314_Click(object sender, EventArgs e)
		{
			if (this.simpleButton314.Text == "Low Gravity [OFF]")
			{
				this.simpleButton314.Text = "Low Gravity [ON]";
				this.ixboxConsole_0.CallVoid(2184248664U, new object[]
				{
					0,
					"seta bg_gravity 125"
				});
			}
			else
			{
				this.simpleButton314.Text = "Low Gravity [OFF]";
				this.ixboxConsole_0.CallVoid(2184248664U, new object[]
				{
					0,
					"seta bg_gravity 650"
				});
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00028990 File Offset: 0x00026B90
		private void simpleButton313_Click(object sender, EventArgs e)
		{
			if (this.simpleButton313.Text == "Super Jump [OFF]")
			{
				this.simpleButton313.Text = "Super Jump [ON]";
				this.ixboxConsole_0.WriteFloat(2181049184U, 35000f);
				this.ixboxConsole_0.WriteFloat(2181059808U, 35000f);
			}
			else
			{
				this.simpleButton313.Text = "Super Jump [OFF]";
				this.ixboxConsole_0.WriteFloat(2181049184U, 39f);
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00028A18 File Offset: 0x00026C18
		private void simpleButton316_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[4];
			array[0] = 96;
			this.ixboxConsole_0.SetMemory(2182364812U, array);
			this.ixboxConsole_0.XNotify("Unlimited Ammo Enabled! Relaunch Black Ops I to disable!");
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00028A58 File Offset: 0x00026C58
		private void simpleButton317_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2182822584U, new object[]
			{
				0,
				0,
				3,
				"default",
				0
			});
			this.ixboxConsole_0.CallVoid(2182822584U, new object[]
			{
				0,
				0,
				3,
				this.comboBoxEdit12.SelectedItem.ToString(),
				0
			});
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00028AF4 File Offset: 0x00026CF4
		private void simpleButton286_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184248664U, new object[]
			{
				0,
				"give " + this.comboBoxEdit9.SelectedItem.ToString()
			});
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00028B40 File Offset: 0x00026D40
		private void simpleButton287_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184248664U, new object[]
			{
				0,
				"give " + this.comboBoxEdit11.SelectedItem.ToString()
			});
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00028B8C File Offset: 0x00026D8C
		private void method_50(string string_3)
		{
			this.ixboxConsole_0.CallVoid(2184248664U, new object[]
			{
				0,
				string_3
			});
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00028BBC File Offset: 0x00026DBC
		private void simpleButton319_Click(object sender, EventArgs e)
		{
			if (this.simpleButton319.Text == "Super Speed [OFF]")
			{
				this.simpleButton319.Text = "Super Speed [ON]";
				this.method_50("g_speed 650");
			}
			else
			{
				this.simpleButton319.Text = "Super Speed [OFF]";
				this.method_50("g_speed 165");
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00028C18 File Offset: 0x00026E18
		private void simpleButton321_Click(object sender, EventArgs e)
		{
			if (this.simpleButton321.Text == "Low Gravity [OFF]")
			{
				this.simpleButton321.Text = "Low Gravity [ON]";
				this.method_50("seta bg_gravity 125");
			}
			else
			{
				this.simpleButton321.Text = "Low Gravity [OFF]";
				this.method_50("seta bg_gravity 650");
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00028C74 File Offset: 0x00026E74
		private void simpleButton322_Click(object sender, EventArgs e)
		{
			this.method_50("god");
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00028C8C File Offset: 0x00026E8C
		private void simpleButton295_Click(object sender, EventArgs e)
		{
			this.method_50("demigod");
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00028CA4 File Offset: 0x00026EA4
		private void simpleButton324_Click(object sender, EventArgs e)
		{
			this.method_50("take all");
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00028CBC File Offset: 0x00026EBC
		private void simpleButton329_Click(object sender, EventArgs e)
		{
			this.method_50("give ammo");
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00028A18 File Offset: 0x00026C18
		private void simpleButton320_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[4];
			array[0] = 96;
			this.ixboxConsole_0.SetMemory(2182364812U, array);
			this.ixboxConsole_0.XNotify("Unlimited Ammo Enabled! Relaunch Black Ops I to disable!");
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00028CD4 File Offset: 0x00026ED4
		private void simpleButton326_Click(object sender, EventArgs e)
		{
			this.method_50("noclip");
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00028CEC File Offset: 0x00026EEC
		private void simpleButton325_Click(object sender, EventArgs e)
		{
			this.method_50("ufo");
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00028D04 File Offset: 0x00026F04
		private void simpleButton323_Click(object sender, EventArgs e)
		{
			this.method_50("give all");
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00028D1C File Offset: 0x00026F1C
		private void simpleButton327_Click(object sender, EventArgs e)
		{
			this.method_50("ai axis delete");
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00028D34 File Offset: 0x00026F34
		private void simpleButton328_Click(object sender, EventArgs e)
		{
			this.method_50("fast_restart");
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00028D4C File Offset: 0x00026F4C
		private void simpleButton330_Click(object sender, EventArgs e)
		{
			this.method_50("cg_fov " + this.numericUpDown48.Value.ToString());
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00028D80 File Offset: 0x00026F80
		private void simpleButton318_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton318.Text == "Super Jump [OFF]"))
			{
				this.simpleButton318.Text = "Super Jump [OFF]";
				this.ixboxConsole_0.WriteFloat(2181049184U, 39f);
			}
			else
			{
				this.simpleButton318.Text = "Super Jump [ON]";
				this.ixboxConsole_0.WriteFloat(2181049184U, 35000f);
				this.ixboxConsole_0.WriteFloat(2181059808U, 35000f);
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00028E08 File Offset: 0x00027008
		private void simpleButton339_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2777333122U, Encoding.ASCII.GetBytes(this.textEdit_62.Text + "\0"));
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00028E44 File Offset: 0x00027044
		private void simpleButton340_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2777443643U, Encoding.ASCII.GetBytes(this.textEdit_58.Text + "\0"));
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00028E80 File Offset: 0x00027080
		private void simpleButton337_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2777433921U, Encoding.ASCII.GetBytes(this.textEdit_59.Text + "\0"));
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00028EBC File Offset: 0x000270BC
		private void simpleButton338_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2777478150U, Encoding.ASCII.GetBytes(this.textEdit_61.Text + "\0"));
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00028EF8 File Offset: 0x000270F8
		private void simpleButton336_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2777343148U, Encoding.ASCII.GetBytes(this.textEdit_60.Text + "\0"));
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00028F34 File Offset: 0x00027134
		private void simpleButton334_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2777373744U, Encoding.ASCII.GetBytes(this.textEdit_56.Text + "\0"));
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00028F70 File Offset: 0x00027170
		private void simpleButton335_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2777474427U, Encoding.ASCII.GetBytes(this.textEdit_57.Text + "\0"));
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00028FAC File Offset: 0x000271AC
		private void simpleButton332_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2777467581U, Encoding.ASCII.GetBytes(this.textEdit_55.Text + "\0"));
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00028FE8 File Offset: 0x000271E8
		private void simpleButton262_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				string.Concat(new string[]
				{
					"userinfo \"\\clanabbrev\\",
					this.textEdit_38.Text,
					"\\name\\",
					this.textEdit_39.Text,
					"\\xuid\\"
				})
			});
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00029058 File Offset: 0x00027258
		private void method_51(object sender, EventArgs e)
		{
			this.textEdit_38.Text = "";
			this.textEdit_39.Text = (Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "");
			this.simpleButton262_Click(sender, null);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000290C0 File Offset: 0x000272C0
		private void simpleButton281_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"statSetByName PLEVEL " + this.numericUpDown64.Value.ToString() + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00029114 File Offset: 0x00027314
		private void simpleButton283_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"statSetByName RANKXP " + this.numericUpDown65.Value.ToString() + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00029168 File Offset: 0x00027368
		private void simpleButton279_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"statSetByName SCORE " + this.numericUpDown62.Value.ToString() + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000291BC File Offset: 0x000273BC
		private void simpleButton280_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"statSetByName KILLS " + this.numericUpDown63.Value.ToString() + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00029210 File Offset: 0x00027410
		private void simpleButton277_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"statSetByName DEATHS " + this.numericUpDown60.Value.ToString() + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00029264 File Offset: 0x00027464
		private void simpleButton275_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"statSetByName WINS " + this.numericUpDown58.Value.ToString() + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000292B8 File Offset: 0x000274B8
		private void simpleButton276_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"statSetByName LOSSES " + this.numericUpDown59.Value.ToString() + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0002930C File Offset: 0x0002750C
		private void simpleButton264_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"statSetByName TIME_PLAYED_TOTAL " + this.numericUpDown47.Value.ToString() + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00029360 File Offset: 0x00027560
		private void simpleButton268_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown51.Text));
			this.ixboxConsole_0.SetMemory(2215175153U, bytes);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00029398 File Offset: 0x00027598
		private void simpleButton282_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"statSetByName PLEVEL " + this.numericUpDown64.Value.ToString() + ";updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"statSetByName RANKXP " + this.numericUpDown65.Value.ToString() + ";updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"statSetByName SCORE " + this.numericUpDown62.Value.ToString() + ";updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"statSetByName KILLS " + this.numericUpDown63.Value.ToString() + ";updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"statSetByName DEATHS " + this.numericUpDown60.Value.ToString() + ";updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"statSetByName WINS " + this.numericUpDown58.Value.ToString() + ";updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"statSetByName LOSSES " + this.numericUpDown59.Value.ToString() + ";updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"statSetByName TIME_PLAYED_TOTAL " + this.numericUpDown47.Value.ToString() + ";updategamerprofile;uploadstats"
			});
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown51.Text));
			this.ixboxConsole_0.SetMemory(2215175153U, bytes);
			this.ixboxConsole_0.XNotify("Set All Stats");
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00029608 File Offset: 0x00027808
		private void simpleButton267_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"resetstats;updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.XNotify("Reset Stats");
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0002964C File Offset: 0x0002784C
		private void simpleButton266_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"customclass1 " + this.textEdit_49.Text
			});
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"customclass2 " + this.textEdit_45.Text
			});
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"customclass3 " + this.textEdit_46.Text
			});
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"customclass4 " + this.textEdit_48.Text
			});
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"customclass5 " + this.textEdit_47.Text
			});
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"prestigeclass1 " + this.textEdit_44.Text
			});
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"prestigeclass2 " + this.textEdit_40.Text
			});
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"prestigeclass3 " + this.textEdit_41.Text
			});
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"prestigeclass4 " + this.textEdit_43.Text
			});
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"prestigeclass5 " + this.textEdit_42.Text
			});
			this.ixboxConsole_0.XNotify("Custom Class Names Set!");
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00029890 File Offset: 0x00027A90
		private void simpleButton265_Click(object sender, EventArgs e)
		{
			string str = Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "";
			this.textEdit_49.Text = "^1" + str;
			this.textEdit_45.Text = "^2" + str;
			this.textEdit_46.Text = "^3" + str;
			this.textEdit_48.Text = "^4" + str;
			this.textEdit_47.Text = "^5" + str;
			this.textEdit_44.Text = "^1" + str;
			this.textEdit_40.Text = "^2" + str;
			this.textEdit_41.Text = "^3" + str;
			this.textEdit_43.Text = "^4" + str;
			this.textEdit_42.Text = "^5" + str;
			this.simpleButton266_Click(sender, null);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000299C4 File Offset: 0x00027BC4
		private void simpleButton407_Click(object sender, EventArgs e)
		{
			if (this.simpleButton407.Text == "Aimbot [OFF]")
			{
				this.simpleButton407.Text = "Aimbot [ON]";
				this.ixboxConsole_0.WriteUInt32(2186136960U, 3223192332U);
				this.ixboxConsole_0.WriteUInt32(2186137008U, 3976790066U);
				this.ixboxConsole_0.WriteUInt32(2186136956U, 1029734913U);
			}
			else
			{
				this.simpleButton407.Text = "Aimbot [OFF]";
				this.ixboxConsole_0.WriteUInt32(2186136960U, 3223192328U);
				this.ixboxConsole_0.WriteUInt32(2186137008U, 3976790130U);
				this.ixboxConsole_0.WriteUInt32(2186136956U, 1029734914U);
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00029A88 File Offset: 0x00027C88
		private void simpleButton399_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton399.Text == "No Fall Damage [OFF]"))
			{
				this.simpleButton399.Text = "No Fall Damage [OFF]";
				this.ixboxConsole_0.SetMemory(2181260656U, new byte[]
				{
					55,
					39,
					197,
					172,
					byte.MaxValue,
					byte.MaxValue,
					byte.MaxValue,
					byte.MaxValue,
					127,
					127,
					byte.MaxValue,
					byte.MaxValue,
					64,
					201,
					15,
					219
				});
			}
			else
			{
				this.simpleButton399.Text = "No Fall Damage [ON]";
				this.ixboxConsole_0.SetMemory(2181260656U, new byte[]
				{
					65,
					16,
					0,
					0,
					byte.MaxValue,
					byte.MaxValue,
					byte.MaxValue,
					byte.MaxValue,
					127,
					127,
					byte.MaxValue,
					byte.MaxValue,
					64,
					201,
					15,
					219
				});
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00029B14 File Offset: 0x00027D14
		private void simpleButton400_Click(object sender, EventArgs e)
		{
			if (this.simpleButton400.Text == "Low Gravity [OFF]")
			{
				this.simpleButton400.Text = "Low Gravity [ON]";
				this.ixboxConsole_0.WriteFloat(2181282916U, 4.171259f);
			}
			else
			{
				this.simpleButton400.Text = "Low Gravity [OFF]";
				this.ixboxConsole_0.WriteFloat(2181282916U, 2.171259f);
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00029B84 File Offset: 0x00027D84
		private void simpleButton401_Click(object sender, EventArgs e)
		{
			if (this.simpleButton401.Text == "Super Jump [OFF]")
			{
				this.simpleButton401.Text = "Super Jump [ON]";
				this.ixboxConsole_0.WriteUInt32(2185337428U, 3288139096U);
			}
			else
			{
				this.simpleButton401.Text = "Super Jump [OFF]";
				this.ixboxConsole_0.WriteUInt32(2185337428U, 3288139068U);
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00029BF4 File Offset: 0x00027DF4
		private void simpleButton402_Click(object sender, EventArgs e)
		{
			if (this.simpleButton402.Text == "Super Speed [OFF]")
			{
				this.simpleButton402.Text = "Super Speed [ON]";
				this.ixboxConsole_0.WriteByte(2182338655U, 32);
			}
			else
			{
				this.simpleButton402.Text = "Super Speed [OFF]";
				this.ixboxConsole_0.WriteByte(2182338655U, 4);
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00029C60 File Offset: 0x00027E60
		private void simpleButton403_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton403.Text == "Rapidfire [OFF]"))
			{
				this.simpleButton403.Text = "Rapidfire [OFF]";
				this.ixboxConsole_0.WriteUInt32(2184944992U, 3249078316U);
			}
			else
			{
				this.simpleButton403.Text = "Rapidfire [ON]";
				this.ixboxConsole_0.WriteUInt32(2184944992U, 3245015208U);
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00029CD0 File Offset: 0x00027ED0
		private void simpleButton344_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2204623646U, new byte[]
			{
				1
			});
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00029CF8 File Offset: 0x00027EF8
		private void simpleButton387_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[4];
			array[0] = 1;
			this.ixboxConsole_0.SetMemory(2200104800U, array);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00029D24 File Offset: 0x00027F24
		private void simpleButton395_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[4];
			array[0] = 1;
			this.ixboxConsole_0.SetMemory(2204623645U, array);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00029D50 File Offset: 0x00027F50
		private void simpleButton396_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[4];
			array[0] = 1;
			this.ixboxConsole_0.SetMemory(2204623642U, array);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00029D24 File Offset: 0x00027F24
		private void method_52(object sender, ElapsedEventArgs e)
		{
			byte[] array = new byte[4];
			array[0] = 1;
			this.ixboxConsole_0.SetMemory(2204623645U, array);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00029D7C File Offset: 0x00027F7C
		private void simpleButton397_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton397.Text = (this.TimerEnabled ? "1 Minute Checkpoint Loop [ON]" : "1 Minute Checkpoint Loop [OFF]");
			Form1.halocheckpointloop.Elapsed += this.method_52;
			Form1.halocheckpointloop.AutoReset = true;
			Form1.halocheckpointloop.Enabled = this.TimerEnabled;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00029DE8 File Offset: 0x00027FE8
		private void simpleButton398_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2207620427U, new byte[]
			{
				27
			});
			this.ixboxConsole_0.SetMemory(2207620431U, new byte[]
			{
				27
			});
			this.ixboxConsole_0.SetMemory(2207620441U, new byte[]
			{
				27
			});
			this.ixboxConsole_0.SetMemory(2207620442U, new byte[]
			{
				27
			});
			this.ixboxConsole_0.SetMemory(2207620443U, new byte[]
			{
				27
			});
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00029E7C File Offset: 0x0002807C
		private void simpleButton408_Click(object sender, EventArgs e)
		{
			this.simpleButton407.Text = "Aimbot [ON]";
			this.ixboxConsole_0.WriteUInt32(2186136960U, 3223192332U);
			this.ixboxConsole_0.WriteUInt32(2186137008U, 3976790066U);
			this.ixboxConsole_0.WriteUInt32(2186136956U, 1029734913U);
			this.simpleButton403.Text = "Rapidfire [ON]";
			this.ixboxConsole_0.WriteUInt32(2184944992U, 3245015208U);
			this.simpleButton399.Text = "No Fall Damage [ON]";
			this.ixboxConsole_0.SetMemory(2181260656U, new byte[]
			{
				65,
				16,
				0,
				0,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				127,
				127,
				byte.MaxValue,
				byte.MaxValue,
				64,
				201,
				15,
				219
			});
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton397.Text = (this.TimerEnabled ? "1 Minute Checkpoint Loop [ON]" : "1 Minute Checkpoint Loop [OFF]");
			Form1.timer4.Elapsed += this.method_15;
			Form1.timer4.AutoReset = true;
			Form1.timer4.Enabled = this.TimerEnabled;
			this.ixboxConsole_0.XNotify("Prefered Modding Configuration set!");
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00029FA0 File Offset: 0x000281A0
		private void simpleButton378_Click(object sender, EventArgs e)
		{
			if (this.simpleButton378.Text == "No Recoil [OFF]")
			{
				this.simpleButton378.Text = "No Recoil [ON]";
				this.ixboxConsole_0.SetMemory(2205145800U, new byte[]
				{
					4
				});
			}
			else
			{
				this.simpleButton378.Text = "No Recoil [OFF]";
				this.ixboxConsole_0.SetMemory(2205145800U, new byte[]
				{
					78,
					128,
					4,
					33
				});
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0002A024 File Offset: 0x00028224
		private void simpleButton360_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton360.Text == "UAV [OFF]"))
			{
				this.simpleButton360.Text = "UAV [OFF]";
				byte[] array = new byte[4];
				array[0] = 57;
				array[1] = 96;
				this.ixboxConsole_0.SetMemory(2203038756U, array);
				array = new byte[4];
				array[0] = 56;
				array[1] = 96;
				this.ixboxConsole_0.SetMemory(2203038672U, array);
			}
			else
			{
				this.simpleButton360.Text = "UAV [ON]";
				this.ixboxConsole_0.SetMemory(2203038756U, new byte[]
				{
					57,
					96,
					0,
					1
				});
				this.ixboxConsole_0.SetMemory(2203038672U, new byte[]
				{
					57,
					96,
					0,
					1
				});
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0002A0F8 File Offset: 0x000282F8
		private void simpleButton359_Click(object sender, EventArgs e)
		{
			if (this.simpleButton359.Text == "Wallhack [OFF]")
			{
				this.simpleButton359.Text = "Wallhack [ON]";
				this.ixboxConsole_0.SetMemory(2199876656U, new byte[]
				{
					4
				});
			}
			else
			{
				this.simpleButton359.Text = "Wallhack [OFF]";
				this.ixboxConsole_0.SetMemory(2199876656U, new byte[]
				{
					72,
					11,
					156,
					129
				});
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0002A17C File Offset: 0x0002837C
		private void simpleButton362_Click(object sender, EventArgs e)
		{
			if (this.simpleButton362.Text == "ESP [OFF]")
			{
				this.simpleButton362.Text = "ESP [ON]";
				this.ixboxConsole_0.SetMemory(2203079272U, new byte[]
				{
					4
				});
				this.ixboxConsole_0.SetMemory(2203079872U, new byte[]
				{
					4
				});
				this.ixboxConsole_0.SetMemory(2203079932U, new byte[]
				{
					72,
					0,
					0,
					60
				});
				this.ixboxConsole_0.SetMemory(2203080368U, new byte[]
				{
					75,
					209,
					254,
					89
				});
				this.ixboxConsole_0.SetMemory(2200065288U, new byte[]
				{
					125,
					136,
					2,
					166
				});
				this.ixboxConsole_0.SetMemory(2200065292U, new byte[]
				{
					47,
					28,
					0,
					2
				});
				this.ixboxConsole_0.SetMemory(2200065296U, new byte[]
				{
					65,
					152,
					0,
					16
				});
				this.ixboxConsole_0.SetMemory(2200065300U, new byte[]
				{
					59,
					224,
					0,
					95
				});
				this.ixboxConsole_0.SetMemory(2200065304U, new byte[]
				{
					125,
					136,
					3,
					166
				});
				this.ixboxConsole_0.SetMemory(2200065308U, new byte[]
				{
					78,
					128,
					0,
					32
				});
				this.ixboxConsole_0.SetMemory(2200065312U, new byte[]
				{
					59,
					224,
					0,
					18
				});
				this.ixboxConsole_0.SetMemory(2200065316U, new byte[]
				{
					125,
					136,
					3,
					166
				});
				this.ixboxConsole_0.SetMemory(2200065320U, new byte[]
				{
					78,
					128,
					0,
					32
				});
				this.ixboxConsole_0.SetMemory(2203077556U, new byte[]
				{
					65,
					154,
					0,
					16
				});
				this.ixboxConsole_0.SetMemory(2203079272U, new byte[]
				{
					4
				});
				this.ixboxConsole_0.SetMemory(2201879208U, new byte[]
				{
					57,
					96
				});
				this.ixboxConsole_0.SetMemory(2203079872U, new byte[]
				{
					4
				});
				this.ixboxConsole_0.SetMemory(2203079932U, new byte[]
				{
					72,
					0,
					0,
					60
				});
			}
			else
			{
				this.simpleButton362.Text = "ESP [OFF]";
				this.ixboxConsole_0.SetMemory(2200065300U, new byte[]
				{
					59,
					224
				});
				this.ixboxConsole_0.SetMemory(2203079272U, new byte[]
				{
					64,
					154,
					13,
					164
				});
				this.ixboxConsole_0.SetMemory(2201879208U, new byte[]
				{
					57,
					96,
					0,
					1
				});
				this.ixboxConsole_0.SetMemory(2203079872U, new byte[]
				{
					65,
					154,
					11,
					56
				});
				this.ixboxConsole_0.SetMemory(2203079932U, new byte[]
				{
					65,
					154,
					0,
					60
				});
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0002A4A4 File Offset: 0x000286A4
		private void simpleButton361_Click(object sender, EventArgs e)
		{
			if (this.simpleButton361.Text == "One Hit Kill [OFF]")
			{
				this.simpleButton361.Text = "One Hit Kill [ON]";
				byte[] array = new byte[4];
				array[0] = 96;
				this.ixboxConsole_0.SetMemory(2204990560U, array);
				this.ixboxConsole_0.SetMemory(2204990516U, new byte[]
				{
					237,
					64,
					0,
					50
				});
				this.ixboxConsole_0.SetMemory(2204990520U, new byte[]
				{
					237,
					32,
					0,
					50
				});
			}
			else
			{
				this.simpleButton361.Text = "One Hit Kill [OFF]";
				this.ixboxConsole_0.SetMemory(2204990560U, new byte[]
				{
					64,
					152,
					0,
					12
				});
				this.ixboxConsole_0.SetMemory(2204990516U, new byte[]
				{
					237,
					64,
					2,
					50
				});
				this.ixboxConsole_0.SetMemory(2204990520U, new byte[]
				{
					237,
					44,
					2,
					50
				});
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0002A5B0 File Offset: 0x000287B0
		private void simpleButton341_Click(object sender, EventArgs e)
		{
			if (this.simpleButton341.Text == "No Sway [OFF]")
			{
				this.simpleButton341.Text = "No Sway [ON]";
				byte[] array = new byte[4];
				array[0] = 96;
				this.ixboxConsole_0.SetMemory(2200080864U, array);
			}
			else
			{
				this.simpleButton341.Text = "No Sway [OFF]";
				this.ixboxConsole_0.SetMemory(2200080864U, new byte[]
				{
					65,
					154,
					0,
					40
				});
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0002A638 File Offset: 0x00028838
		private void simpleButton333_Click(object sender, EventArgs e)
		{
			this.simpleButton378_Click(sender, null);
			this.simpleButton360_Click(sender, null);
			this.simpleButton359_Click(sender, null);
			this.simpleButton362_Click(sender, null);
			this.simpleButton361_Click(sender, null);
			this.simpleButton341_Click(sender, null);
			this.ixboxConsole_0.XNotify("Preset Cheats Set!");
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0002A688 File Offset: 0x00028888
		private void simpleButton394_Click(object sender, EventArgs e)
		{
			if (this.simpleButton394.Text == "No Recoil [OFF]")
			{
				this.simpleButton394.Text = "No Recoil [ON]";
				this.ixboxConsole_0.WriteUInt32(2294311764U, 1100611648U);
			}
			else
			{
				this.simpleButton394.Text = "No Recoil [OFF]";
				this.ixboxConsole_0.WriteUInt32(2294311764U, 1207959616U);
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0002A6F8 File Offset: 0x000288F8
		private void simpleButton391_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton391.Text == "UAV [OFF]"))
			{
				this.simpleButton391.Text = "UAV [OFF]";
				this.ixboxConsole_0.WriteByte(2288935484U, 65);
			}
			else
			{
				this.simpleButton391.Text = "UAV [ON]";
				this.ixboxConsole_0.WriteByte(2288935484U, 64);
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0002A764 File Offset: 0x00028964
		private void simpleButton390_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton390.Text == "Wallhack [OFF]"))
			{
				this.simpleButton390.Text = "Wallhack [OFF]";
				this.ixboxConsole_0.WriteByte(2299582212U, 65);
			}
			else
			{
				this.simpleButton390.Text = "Wallhack [ON]";
				this.ixboxConsole_0.WriteByte(2299582212U, 64);
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0002A7D0 File Offset: 0x000289D0
		private void simpleButton393_Click(object sender, EventArgs e)
		{
			if (this.simpleButton393.Text == "ESP [OFF]")
			{
				this.simpleButton393.Text = "ESP [ON]";
				this.ixboxConsole_0.WriteUInt32(2288936296U, 1083834408U);
				this.ixboxConsole_0.WriteUInt32(2288936308U, 1083834388U);
				this.ixboxConsole_0.WriteUInt32(2287124764U, 1610612736U);
				this.ixboxConsole_0.WriteUInt32(2288939380U, 1610612736U);
			}
			else
			{
				this.simpleButton393.Text = "ESP [OFF]";
				this.ixboxConsole_0.WriteUInt32(2288936296U, 1100611624U);
				this.ixboxConsole_0.WriteUInt32(2288936308U, 1100611604U);
				this.ixboxConsole_0.WriteUInt32(2287124764U, 1100612852U);
				this.ixboxConsole_0.WriteUInt32(2288939380U, 1100611624U);
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0002A8C0 File Offset: 0x00028AC0
		private void simpleButton392_Click(object sender, EventArgs e)
		{
			if (this.simpleButton392.Text == "Unlimited Breathe [OFF]")
			{
				this.simpleButton392.Text = "Unlimited Breathe [ON]";
				byte[] array = new byte[4];
				array[0] = 96;
				this.ixboxConsole_0.SetMemory(2299952888U, array);
			}
			else
			{
				this.simpleButton392.Text = "Unlimited Breathe [OFF]";
				byte[] data = new byte[]
				{
					195,
					231,
					12,
					36
				};
				this.ixboxConsole_0.SetMemory(2299952888U, data);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0002A94C File Offset: 0x00028B4C
		private void simpleButton389_Click(object sender, EventArgs e)
		{
			byte[] data = new byte[]
			{
				125,
				136,
				2,
				166,
				145,
				129,
				0,
				8,
				148,
				33,
				byte.MaxValue,
				144,
				127,
				71,
				211,
				120,
				252,
				32,
				240,
				144,
				127,
				102,
				219,
				120,
				127,
				164,
				235,
				120,
				61,
				192,
				137,
				124,
				97,
				206,
				28,
				16,
				144,
				110,
				0,
				0,
				129,
				206,
				0,
				0,
				129,
				206,
				5,
				68,
				129,
				206,
				0,
				0,
				129,
				206,
				0,
				12,
				61,
				224,
				137,
				124,
				97,
				239,
				28,
				24,
				129,
				239,
				0,
				0,
				145,
				238,
				0,
				48,
				145,
				238,
				0,
				52,
				145,
				238,
				0,
				56,
				145,
				238,
				0,
				64,
				145,
				238,
				0,
				68,
				145,
				238,
				0,
				72,
				61,
				224,
				137,
				124,
				97,
				239,
				28,
				28,
				129,
				239,
				0,
				0,
				145,
				238,
				0,
				244,
				145,
				238,
				0,
				248,
				145,
				238,
				0,
				252,
				61,
				224,
				137,
				124,
				97,
				239,
				28,
				32,
				129,
				239,
				0,
				0,
				145,
				238,
				0,
				212,
				57,
				224,
				0,
				0,
				57,
				192,
				0,
				0,
				56,
				33,
				0,
				112,
				129,
				129,
				0,
				8,
				125,
				136,
				3,
				166,
				78,
				128,
				0,
				32
			};
			byte[] data2 = new byte[]
			{
				61,
				192,
				137,
				124,
				97,
				206,
				26,
				16,
				125,
				201,
				3,
				166,
				78,
				128,
				4,
				33
			};
			this.ixboxConsole_0.WriteUInt32(2306612248U, 1167654912U);
			this.ixboxConsole_0.WriteUInt32(2306612252U, 1202702336U);
			this.ixboxConsole_0.WriteUInt32(2306612256U, 896636807U);
			this.ixboxConsole_0.SetMemory(2306611728U, data);
			this.ixboxConsole_0.SetMemory(2299541616U, data2);
			this.ixboxConsole_0.XNotify("Aimbot given, to disable restart Battlefield 4!");
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0002A9F8 File Offset: 0x00028BF8
		private void simpleButton388_Click(object sender, EventArgs e)
		{
			this.simpleButton394.Text = "No Recoil [ON]";
			this.ixboxConsole_0.WriteUInt32(2294311764U, 1100611648U);
			this.simpleButton393.Text = "ESP [ON]";
			this.ixboxConsole_0.WriteUInt32(2288936296U, 1083834408U);
			this.ixboxConsole_0.WriteUInt32(2288936308U, 1083834388U);
			this.ixboxConsole_0.WriteUInt32(2287124764U, 1610612736U);
			this.ixboxConsole_0.WriteUInt32(2288939380U, 1610612736U);
			this.simpleButton390.Text = "Wallhack [ON]";
			this.ixboxConsole_0.WriteByte(2299582212U, 64);
			this.simpleButton391.Text = "UAV [ON]";
			this.ixboxConsole_0.WriteByte(2288935484U, 64);
			this.simpleButton392.Text = "Unlimited Breathe [ON]";
			byte[] array = new byte[4];
			array[0] = 96;
			this.ixboxConsole_0.SetMemory(2299952888U, array);
			this.ixboxConsole_0.XNotify("All Cheats set!");
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0002AB14 File Offset: 0x00028D14
		private void simpleButton376_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.WriteFloat(2182679236U, float.Parse(this.textEdit_125.Text));
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0002AB44 File Offset: 0x00028D44
		private void simpleButton374_Click(object sender, EventArgs e)
		{
			this.textEdit_125.Text = "-2";
			this.ixboxConsole_0.WriteFloat(2182679236U, float.Parse(this.textEdit_125.Text));
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0002AB84 File Offset: 0x00028D84
		private void simpleButton373_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.WriteFloat(2182679224U, float.Parse(this.textEdit_124.Text));
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0002ABB4 File Offset: 0x00028DB4
		private void simpleButton372_Click(object sender, EventArgs e)
		{
			this.textEdit_124.Text = "255";
			this.ixboxConsole_0.WriteFloat(2182679224U, float.Parse(this.textEdit_124.Text));
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0002ABF4 File Offset: 0x00028DF4
		private void simpleButton375_Click(object sender, EventArgs e)
		{
			this.textEdit_125.Text = "-150";
			this.ixboxConsole_0.WriteFloat(2182679236U, float.Parse(this.textEdit_125.Text));
			this.textEdit_124.Text = "255";
			this.ixboxConsole_0.WriteFloat(2182679224U, float.Parse(this.textEdit_124.Text));
			this.ixboxConsole_0.XNotify("Prefered Modding Configuration set!");
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0002AC74 File Offset: 0x00028E74
		private void simpleButton371_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.WriteFloat(2183992152U, float.Parse(this.textEdit_123.Text));
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		private void simpleButton369_Click(object sender, EventArgs e)
		{
			this.textEdit_123.Text = "-9.8";
			this.ixboxConsole_0.WriteFloat(2183992152U, float.Parse(this.textEdit_123.Text));
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0002ACE4 File Offset: 0x00028EE4
		private void simpleButton368_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.WriteFloat(2181040476U, float.Parse(this.textEdit_122.Text));
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0002AD14 File Offset: 0x00028F14
		private void simpleButton367_Click(object sender, EventArgs e)
		{
			this.textEdit_122.Text = "255";
			this.ixboxConsole_0.WriteFloat(2181040476U, float.Parse(this.textEdit_122.Text));
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0002AD54 File Offset: 0x00028F54
		private void simpleButton366_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.WriteFloat(2181040736U, float.Parse(this.textEdit_121.Text));
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0002AD84 File Offset: 0x00028F84
		private void simpleButton365_Click(object sender, EventArgs e)
		{
			this.textEdit_121.Text = "-2";
			this.ixboxConsole_0.WriteFloat(2181040736U, float.Parse(this.textEdit_121.Text));
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0002ADC4 File Offset: 0x00028FC4
		private void simpleButton370_Click(object sender, EventArgs e)
		{
			float value = float.Parse("-150");
			this.ixboxConsole_0.WriteFloat(2183992152U, value);
			this.textEdit_123.Text = "-150";
			float value2 = float.Parse("250");
			this.ixboxConsole_0.WriteFloat(2181040736U, value2);
			this.textEdit_122.Text = "250";
			float value3 = float.Parse("255");
			this.ixboxConsole_0.WriteFloat(2181040476U, value3);
			this.textEdit_122.Text = "255";
			this.ixboxConsole_0.XNotify("Prefered Modding Configuration set!");
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0002AE6C File Offset: 0x0002906C
		private void simpleButton364_Click(object sender, EventArgs e)
		{
			float value = float.Parse(this.textEdit_120.Text);
			this.ixboxConsole_0.WriteFloat(2184153920U, value);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0002AEA0 File Offset: 0x000290A0
		private void simpleButton363_Click(object sender, EventArgs e)
		{
			this.textEdit_120.Text = "-9.8";
			this.ixboxConsole_0.WriteFloat(2184153920U, -9.8f);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0002AED4 File Offset: 0x000290D4
		private void simpleButton353_Click(object sender, EventArgs e)
		{
			float value = float.Parse(this.textEdit_119.Text);
			this.ixboxConsole_0.WriteFloat(2181812836U, value);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0002AF08 File Offset: 0x00029108
		private void simpleButton352_Click(object sender, EventArgs e)
		{
			this.textEdit_119.Text = "255";
			this.ixboxConsole_0.WriteFloat(2181812836U, 255f);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0002AF3C File Offset: 0x0002913C
		private void simpleButton351_Click(object sender, EventArgs e)
		{
			float value = float.Parse(this.textEdit_118.Text);
			this.ixboxConsole_0.WriteFloat(2184154064U, value);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0002AF70 File Offset: 0x00029170
		private void simpleButton350_Click(object sender, EventArgs e)
		{
			this.textEdit_118.Text = "19.6";
			this.ixboxConsole_0.WriteFloat(2184154064U, 19.6f);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0002AFA4 File Offset: 0x000291A4
		private void simpleButton347_Click(object sender, EventArgs e)
		{
			if (this.simpleButton347.Text == "Zoomed Out FOV [OFF]")
			{
				this.simpleButton347.Text = "Zoomed Out FOV [ON]";
				this.ixboxConsole_0.WriteFloat(2181484816U, 0.03f);
			}
			else
			{
				this.simpleButton347.Text = "Zoomed Out FOV [OFF]";
				this.ixboxConsole_0.WriteFloat(2181484816U, 0.01745329f);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0002B014 File Offset: 0x00029214
		private void simpleButton349_Click(object sender, EventArgs e)
		{
			if (this.simpleButton349.Text == "Zoomed In FOV [OFF]")
			{
				this.simpleButton349.Text = "Zoomed In FOV [ON]";
				this.ixboxConsole_0.WriteFloat(2181484816U, 0.01f);
			}
			else
			{
				this.simpleButton349.Text = "Zoomed In FOV [OFF]";
				this.ixboxConsole_0.WriteFloat(2181484816U, 0.01745329f);
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0002B084 File Offset: 0x00029284
		private void simpleButton348_Click(object sender, EventArgs e)
		{
			float value = float.Parse("-150");
			this.ixboxConsole_0.WriteFloat(2184153920U, value);
			this.textEdit_120.Text = "-150";
			float value2 = float.Parse("250");
			this.ixboxConsole_0.WriteFloat(2184154064U, value2);
			this.textEdit_119.Text = "250";
			float value3 = float.Parse("255");
			this.ixboxConsole_0.WriteFloat(2181812836U, value3);
			this.textEdit_118.Text = "255";
			this.simpleButton347.Text = "Zoomed Out FOV [ON]";
			this.ixboxConsole_0.WriteFloat(2181484816U, 0.03f);
			this.ixboxConsole_0.XNotify("Prefered Modding Configuration set!");
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0002B150 File Offset: 0x00029350
		private void simpleButton458_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185702272U, new object[]
			{
				0,
				"disconnect"
			});
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0002B184 File Offset: 0x00029384
		private void simpleButton457_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185702272U, new object[]
			{
				0,
				"set party_minplayers 1;xpartygo"
			});
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0002B1B8 File Offset: 0x000293B8
		private void simpleButton433_Click(object sender, EventArgs e)
		{
			if (this.simpleButton433.Text == "No Recoil [OFF]")
			{
				this.simpleButton433.Text = "No Recoil [ON]";
				IXboxConsole console = this.ixboxConsole_0;
				byte[] array = new byte[4];
				array[0] = 96;
				console.SetMemory(2187627756U, array);
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0002B210 File Offset: 0x00029410
		private void simpleButton434_Click(object sender, EventArgs e)
		{
			if (this.simpleButton434.Text == "ESP [OFF]")
			{
				this.simpleButton434.Text = "ESP [ON]";
				byte[] array = new byte[4];
				array[0] = 96;
				this.ixboxConsole_0.SetMemory(2187524876U, array);
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0002B264 File Offset: 0x00029464
		private void simpleButton435_Click(object sender, EventArgs e)
		{
			if (this.simpleButton435.Text == "UAV [OFF]")
			{
				this.simpleButton435.Text = "UAV [ON]";
				byte[] array = new byte[4];
				array[0] = 96;
				this.ixboxConsole_0.SetMemory(2187547300U, array);
				byte[] array2 = new byte[4];
				array2[0] = 96;
				this.ixboxConsole_0.SetMemory(2187547304U, array2);
				byte[] array3 = new byte[4];
				array3[0] = 96;
				this.ixboxConsole_0.SetMemory(2187547308U, array3);
				byte[] array4 = new byte[4];
				array4[0] = 96;
				this.ixboxConsole_0.SetMemory(2187547312U, array4);
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0002B31C File Offset: 0x0002951C
		private void simpleButton446_Click(object sender, EventArgs e)
		{
			this.simpleButton446.Text = "No Spread [ON]";
			byte[] array = new byte[4];
			array[0] = 96;
			this.ixboxConsole_0.SetMemory(2187622048U, array);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0002B35C File Offset: 0x0002955C
		private void simpleButton447_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185702272U, new object[]
			{
				0,
				this.textEdit_64.Text
			});
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0002B398 File Offset: 0x00029598
		private void simpleButton448_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185702272U, new object[]
			{
				0,
				"set cg_fov 90"
			});
			this.textEdit_64.Text = "set cg_fov 90";
			this.simpleButton433.Text = "No Recoil [ON]";
			IXboxConsole console = this.ixboxConsole_0;
			byte[] array = new byte[4];
			array[0] = 96;
			console.SetMemory(2187627756U, array);
			this.simpleButton434.Text = "ESP [ON]";
			byte[] array2 = new byte[4];
			array2[0] = 96;
			this.ixboxConsole_0.SetMemory(2187524876U, array2);
			this.simpleButton435.Text = "UAV [ON]";
			byte[] array3 = new byte[4];
			array3[0] = 96;
			this.ixboxConsole_0.SetMemory(2187547300U, array3);
			byte[] array4 = new byte[4];
			array4[0] = 96;
			this.ixboxConsole_0.SetMemory(2187547304U, array4);
			byte[] array5 = new byte[4];
			array5[0] = 96;
			this.ixboxConsole_0.SetMemory(2187547308U, array5);
			byte[] array6 = new byte[4];
			array6[0] = 96;
			this.ixboxConsole_0.SetMemory(2187547312U, array6);
			this.simpleButton446.Text = "No Spread [ON]";
			byte[] array7 = new byte[4];
			array7[0] = 96;
			this.ixboxConsole_0.SetMemory(2187622048U, array7);
			this.ixboxConsole_0.XNotify("All Offhost Cheats set!");
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0002B510 File Offset: 0x00029710
		private void simpleButton445_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton445.Text == "Super Jump [OFF]"))
			{
				this.simpleButton445.Text = "Super Jump [OFF]";
				this.ixboxConsole_0.WriteFloat(2181453472U, 39f);
			}
			else
			{
				this.simpleButton445.Text = "Super Jump [ON]";
				this.ixboxConsole_0.WriteFloat(2181453472U, 2999f);
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0002B580 File Offset: 0x00029780
		private void method_53(object sender, ElapsedEventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2206236630U, new byte[]
			{
				1
			});
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0002B5A8 File Offset: 0x000297A8
		private void simpleButton441_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton441.Text = ((!this.TimerEnabled) ? "Surf Around [OFF]" : "Surf Around [ON]");
			Form1.awsurftimer.Elapsed += this.method_53;
			Form1.awsurftimer.AutoReset = true;
			Form1.awsurftimer.Enabled = this.TimerEnabled;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0002B614 File Offset: 0x00029814
		private void simpleButton438_Click(object sender, EventArgs e)
		{
			if (this.simpleButton438.Text == "UFO [OFF]")
			{
				this.simpleButton438.Text = "UFO [ON]";
				this.ixboxConsole_0.SetMemory(2206250279U, new byte[]
				{
					1
				});
			}
			else
			{
				this.simpleButton438.Text = "UFO [OFF]";
				this.ixboxConsole_0.SetMemory(2206250279U, new byte[1]);
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0002B68C File Offset: 0x0002988C
		private void simpleButton436_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton436.Text == "Unlimited Ammo [OFF]"))
			{
				this.simpleButton436.Text = "Unlimited Ammo [OFF]";
				this.ixboxConsole_0.SetMemory(2206238222U, new byte[2]);
				this.ixboxConsole_0.SetMemory(2206238270U, new byte[2]);
				this.ixboxConsole_0.SetMemory(2206238246U, new byte[6]);
				this.ixboxConsole_0.SetMemory(2206238294U, new byte[6]);
			}
			else
			{
				this.simpleButton436.Text = "Unlimited Ammo [ON]";
				this.ixboxConsole_0.SetMemory(2206238222U, new byte[]
				{
					byte.MaxValue,
					byte.MaxValue
				});
				this.ixboxConsole_0.SetMemory(2206238270U, new byte[]
				{
					byte.MaxValue,
					byte.MaxValue
				});
				this.ixboxConsole_0.SetMemory(2206238246U, new byte[]
				{
					byte.MaxValue,
					byte.MaxValue,
					0,
					0,
					byte.MaxValue,
					byte.MaxValue
				});
				this.ixboxConsole_0.SetMemory(2206238294U, new byte[]
				{
					byte.MaxValue,
					byte.MaxValue,
					0,
					0,
					byte.MaxValue,
					byte.MaxValue
				});
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0002B7BC File Offset: 0x000299BC
		private void simpleButton437_Click(object sender, EventArgs e)
		{
			if (this.simpleButton437.Text == "Godmode [OFF]")
			{
				this.simpleButton437.Text = "Godmode [ON]";
				this.ixboxConsole_0.SetMemory(2206915244U, new byte[]
				{
					1
				});
			}
			else
			{
				this.simpleButton437.Text = "Godmode [OFF]";
				this.ixboxConsole_0.SetMemory(2206915244U, new byte[1]);
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0002B834 File Offset: 0x00029A34
		private void simpleButton410_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.WriteString(2218650804U, this.textEdit_68.Text);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0002B85C File Offset: 0x00029A5C
		private void simpleButton450_Click(object sender, EventArgs e)
		{
			this.textEdit_68.Text = (Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "");
			this.ixboxConsole_0.WriteString(2218650804U, this.textEdit_68.Text);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0002B8C4 File Offset: 0x00029AC4
		private void simpleButton409_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185702272U, new object[]
			{
				0,
				string.Concat(new string[]
				{
					"userinfo \"\\clanabbrev\\",
					this.textEdit_65.Text,
					"\\name\\",
					this.textEdit_66.Text,
					"\\xuid\\"
				})
			});
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0002B934 File Offset: 0x00029B34
		private void simpleButton449_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185702272U, new object[]
			{
				0,
				"userinfo \"\\name\\" + Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) + "\\xuid\\"
			});
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0002B9A0 File Offset: 0x00029BA0
		private void simpleButton430_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185545528U, new object[]
			{
				0,
				"disconnect"
			});
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0002B9D4 File Offset: 0x00029BD4
		private void simpleButton427_Click(object sender, EventArgs e)
		{
			if (this.simpleButton427.Text == "No Recoil [OFF]")
			{
				this.simpleButton427.Text = "No Recoil [ON]";
				byte[] array = new byte[4];
				array[0] = 96;
				this.ixboxConsole_0.SetMemory(2183959364U, array);
			}
			else
			{
				this.simpleButton427.Text = "No Recoil [OFF]";
				this.ixboxConsole_0.SetMemory(2183959364U, new byte[]
				{
					75,
					248,
					174,
					77
				});
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0002BA5C File Offset: 0x00029C5C
		private void simpleButton426_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton426.Text == "UAV [OFF]"))
			{
				this.simpleButton426.Text = "UAV [OFF]";
				this.ixboxConsole_0.SetMemory(2183549851U, new byte[1]);
				this.ixboxConsole_0.SetMemory(2183550867U, new byte[1]);
				this.ixboxConsole_0.SetMemory(2183550975U, new byte[1]);
			}
			else
			{
				this.simpleButton426.Text = "UAV [ON]";
				this.ixboxConsole_0.SetMemory(2183549851U, new byte[]
				{
					1
				});
				this.ixboxConsole_0.SetMemory(2183550867U, new byte[]
				{
					1
				});
				this.ixboxConsole_0.SetMemory(2183550975U, new byte[]
				{
					1
				});
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0002BB34 File Offset: 0x00029D34
		private void simpleButton424_Click(object sender, EventArgs e)
		{
			if (this.simpleButton424.Text == "Laser [OFF]")
			{
				this.simpleButton424.Text = "Laser [ON]";
				this.ixboxConsole_0.SetMemory(2183655832U, new byte[]
				{
					56,
					96,
					0,
					1
				});
			}
			else
			{
				this.simpleButton424.Text = "Laser [OFF]";
				byte[] array = new byte[4];
				array[0] = 56;
				array[1] = 96;
				this.ixboxConsole_0.SetMemory(2183655832U, array);
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0002BBC4 File Offset: 0x00029DC4
		private void simpleButton429_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[4];
			array[0] = 96;
			this.ixboxConsole_0.SetMemory(2184035040U, array);
			this.ixboxConsole_0.CallVoid(2185545528U, new object[]
			{
				0,
				"set party_minplayers 1;xpartygo"
			});
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0002BC18 File Offset: 0x00029E18
		private void simpleButton428_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton428.Text == "Force Host [OFF]"))
			{
				this.simpleButton428.Text = "Force Host [OFF]";
				this.ixboxConsole_0.CallVoid(2185545528U, new object[]
				{
					0,
					"set party_minplayers 8;set party_gamestarttimelength 10;set party_pregamestarttimerlength 10;set party_connectTimeout 2500"
				});
			}
			else
			{
				this.simpleButton428.Text = "Force Host [ON]";
				this.ixboxConsole_0.CallVoid(2185545528U, new object[]
				{
					0,
					"set party_connectToOthers 0;set party_minplayers 1;set party_gamestarttimelength 1;set party_pregamestarttimerlength 1;set party_connectTimeout 1"
				});
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0002BCAC File Offset: 0x00029EAC
		private void simpleButton425_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton425.Text == "ESP [OFF]"))
			{
				this.simpleButton425.Text = "ESP [OFF]";
				this.ixboxConsole_0.SetMemory(2183582388U, new byte[]
				{
					65,
					154,
					0,
					12
				});
			}
			else
			{
				this.simpleButton425.Text = "ESP [ON]";
				byte[] array = new byte[4];
				array[0] = 96;
				this.ixboxConsole_0.SetMemory(2183582388U, array);
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0002BD34 File Offset: 0x00029F34
		private void simpleButton406_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton406.Text == "Big Map [OFF]"))
			{
				this.simpleButton406.Text = "Big Map [OFF]";
				this.ixboxConsole_0.CallVoid(2185545528U, new object[]
				{
					0,
					"set compassSize 1\""
				});
			}
			else
			{
				this.simpleButton406.Text = "Big Map [ON]";
				this.ixboxConsole_0.CallVoid(2185545528U, new object[]
				{
					0,
					"set compassSize 1.5\""
				});
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0002BDC8 File Offset: 0x00029FC8
		private void simpleButton423_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185545528U, new object[]
			{
				0,
				this.textEdit_63.Text
			});
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0002BE04 File Offset: 0x0002A004
		private void simpleButton422_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185545528U, new object[]
			{
				0,
				"set cg_fov 90"
			});
			this.textEdit_63.Text = "set cg_fov 90";
			this.simpleButton427.Text = "No Recoil [ON]";
			byte[] array = new byte[4];
			array[0] = 96;
			this.ixboxConsole_0.SetMemory(2183959364U, array);
			this.simpleButton426.Text = "UAV [ON]";
			this.ixboxConsole_0.SetMemory(2183549851U, new byte[]
			{
				1
			});
			this.ixboxConsole_0.SetMemory(2183550867U, new byte[]
			{
				1
			});
			this.ixboxConsole_0.SetMemory(2183550975U, new byte[]
			{
				1
			});
			this.simpleButton425.Text = "ESP [ON]";
			byte[] array2 = new byte[4];
			array2[0] = 96;
			this.ixboxConsole_0.SetMemory(2183582388U, array2);
			this.simpleButton424.Text = "Laser [ON]";
			this.ixboxConsole_0.SetMemory(2183655832U, new byte[]
			{
				56,
				96,
				0,
				1
			});
			this.simpleButton406.Text = "Big Map [ON]";
			this.ixboxConsole_0.CallVoid(2185545528U, new object[]
			{
				0,
				"set compassSize 1.5\""
			});
			this.ixboxConsole_0.XNotify("All Offhost Cheats set!");
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0002BF80 File Offset: 0x0002A180
		private uint method_54(uint uint_0)
		{
			return 2200967552U + uint_0 * 14080U;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0002BFA0 File Offset: 0x0002A1A0
		public string ByteToStringGHOSTS(byte[] input)
		{
			UTF8Encoding utf8Encoding = new UTF8Encoding();
			return utf8Encoding.GetString(input);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0002BFC0 File Offset: 0x0002A1C0
		public string GetGamertagGHOSTS(uint cli)
		{
			byte[] array = new byte[20];
			uint num;
			this.ixboxConsole_0.DebugTarget.GetMemory(this.method_54(cli) + 12316U, 20U, array, out num);
			this.ixboxConsole_0.DebugTarget.InvalidateMemoryCache(true, this.method_54(cli) + 12316U, 20U);
			return this.ByteToStringGHOSTS(array);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0002C028 File Offset: 0x0002A228
		private void simpleButton443_Click(object sender, EventArgs e)
		{
			string[] array = new string[12];
			this.listBox3.Items.Clear();
			for (int i = 0; i < array.Length; i++)
			{
				this.listBox3.Items.Add(Convert.ToString(i) + " - " + this.GetGamertagGHOSTS(Convert.ToUInt32(i)));
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0002C094 File Offset: 0x0002A294
		private void simpleButton404_Click(object sender, EventArgs e)
		{
			if (this.simpleButton404.Text == "Super Jump [OFF]")
			{
				this.simpleButton404.Text = "Super Jump [ON]";
				this.ixboxConsole_0.WriteFloat(2181130408U, 1500f);
				byte[] array = new byte[2];
				array[0] = 72;
				this.ixboxConsole_0.SetMemory(2183335380U, array);
			}
			else
			{
				this.simpleButton404.Text = "Super Jump [OFF]";
				this.ixboxConsole_0.WriteFloat(2181130408U, 39f);
				this.ixboxConsole_0.SetMemory(2183335380U, new byte[]
				{
					65,
					152
				});
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0002C148 File Offset: 0x0002A348
		private void simpleButton405_Click(object sender, EventArgs e)
		{
			if (this.simpleButton405.Text == "Unlimited Ammo [OFF]")
			{
				this.simpleButton405.Text = "Unlimited Ammo [ON]";
				byte[] array = new byte[4];
				array[0] = 96;
				this.ixboxConsole_0.SetMemory(2183431696U, array);
			}
			else
			{
				this.simpleButton405.Text = "Unlimited Ammo [OFF]";
				this.ixboxConsole_0.SetMemory(2183431696U, new byte[]
				{
					125,
					75,
					24,
					46
				});
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0002C1D0 File Offset: 0x0002A3D0
		private void simpleButton442_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.WriteInt32(this.method_54(Convert.ToUInt32(this.numericUpDown74.Value)) + 13084U, 3);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0002C208 File Offset: 0x0002A408
		private uint method_55(uint uint_0)
		{
			return 2201466496U + uint_0 * 640U;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0002C228 File Offset: 0x0002A428
		private void simpleButton444_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.WriteInt32(this.method_55(Convert.ToUInt32(this.numericUpDown75.Value)) + 396U, 1);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0002C260 File Offset: 0x0002A460
		private void simpleButton440_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.WriteInt32(this.method_54(Convert.ToUInt32(this.numericUpDown72.Value)) + 13084U, 0);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0002C298 File Offset: 0x0002A498
		private void simpleButton439_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.WriteInt32(this.method_55(Convert.ToUInt32(this.numericUpDown66.Value)) + 396U, 0);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0002C2D0 File Offset: 0x0002A4D0
		private void simpleButton421_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185545528U, new object[]
			{
				0,
				string.Concat(new string[]
				{
					"userinfo \"\\clanabbrev\\",
					this.textEdit_73.Text,
					"\\name\\",
					this.textEdit_74.Text,
					"\\xuid\\"
				})
			});
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0002C340 File Offset: 0x0002A540
		private void simpleButton420_Click(object sender, EventArgs e)
		{
			this.textEdit_74.Text = (Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "");
			this.ixboxConsole_0.CallVoid(2185545528U, new object[]
			{
				0,
				"userinfo \"\\name\\" + this.textEdit_74.Text + "\\xuid\\"
			});
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0002C3CC File Offset: 0x0002A5CC
		private void simpleButton451_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187568800U, new object[]
			{
				0,
				"disconnect"
			});
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0002C400 File Offset: 0x0002A600
		private void simpleButton432_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187568800U, new object[]
			{
				0,
				"cmd sl"
			});
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0002C434 File Offset: 0x0002A634
		private void simpleButton452_Click(object sender, EventArgs e)
		{
			if (this.simpleButton452.Text == "Force Host [OFF]")
			{
				this.simpleButton452.Text = "Force Host [ON]";
				this.ixboxConsole_0.CallVoid(2187568800U, new object[]
				{
					0,
					"party_connectToOthers 0;allowAllNAT 1;party_minplayers 1;partyMigrate_disabled 1"
				});
			}
			else
			{
				this.simpleButton452.Text = "Force Host [OFF]";
				this.ixboxConsole_0.CallVoid(2187568800U, new object[]
				{
					0,
					"party_connectToOthers 1;allowAllNAT 0;party_minplayers 6;partyMigrate_disabled 0"
				});
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0002C4C8 File Offset: 0x0002A6C8
		private void simpleButton453_Click(object sender, EventArgs e)
		{
			if (this.simpleButton453.Text == "No Recoil [OFF]")
			{
				this.simpleButton453.Text = "No Recoil [ON]";
				this.ixboxConsole_0.SetMemory(2183634104U, new byte[]
				{
					56,
					96,
					0,
					1
				});
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0002C520 File Offset: 0x0002A720
		private void simpleButton454_Click(object sender, EventArgs e)
		{
			if (this.simpleButton454.Text == "UAV [OFF]")
			{
				this.simpleButton454.Text = "UAV [ON]";
				this.ixboxConsole_0.SetMemory(2183707768U, new byte[]
				{
					byte.MaxValue
				});
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0002C574 File Offset: 0x0002A774
		private void simpleButton455_Click(object sender, EventArgs e)
		{
			if (this.simpleButton455.Text == "ESP [OFF]")
			{
				this.simpleButton455.Text = "ESP [ON]";
				byte[] array = new byte[4];
				array[0] = 96;
				this.ixboxConsole_0.SetMemory(2187397408U, array);
				byte[] array2 = new byte[4];
				array2[0] = 96;
				this.ixboxConsole_0.SetMemory(2187397448U, array2);
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0002C5E8 File Offset: 0x0002A7E8
		private void simpleButton456_Click(object sender, EventArgs e)
		{
			if (this.simpleButton456.Text == "No Sway [OFF]")
			{
				this.simpleButton456.Text = "No Sway [ON]";
				byte[] array = new byte[4];
				array[0] = 96;
				this.ixboxConsole_0.SetMemory(2183139336U, array);
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0002C63C File Offset: 0x0002A83C
		private void simpleButton459_Click(object sender, EventArgs e)
		{
			if (this.simpleButton459.Text == "No Spread [OFF]")
			{
				this.simpleButton459.Text = "No Spread [ON]";
				this.ixboxConsole_0.WriteFloat(2181668776U, 0f);
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0002C688 File Offset: 0x0002A888
		private void simpleButton460_Click(object sender, EventArgs e)
		{
			if (this.simpleButton460.Text == "Wallhack [OFF]")
			{
				this.simpleButton460.Text = "Wallhack [ON]";
				this.ixboxConsole_0.SetMemory(2185955480U, new byte[]
				{
					50,
					0,
					byte.MaxValue,
					byte.MaxValue
				});
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0002C6E0 File Offset: 0x0002A8E0
		private void simpleButton461_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187568800U, new object[]
			{
				0,
				this.textEdit_75.Text
			});
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0002C71C File Offset: 0x0002A91C
		private void simpleButton462_Click(object sender, EventArgs e)
		{
			this.simpleButton453_Click(sender, null);
			this.simpleButton454_Click(sender, null);
			this.simpleButton455_Click(sender, null);
			this.simpleButton456_Click(sender, null);
			this.simpleButton459_Click(sender, null);
			this.simpleButton460_Click(sender, null);
			this.ixboxConsole_0.XNotify("All Offhost Cheats set!");
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0002C76C File Offset: 0x0002A96C
		private void simpleButton466_Click(object sender, EventArgs e)
		{
			if (this.simpleButton466.Text == "No Recoil [OFF]")
			{
				this.simpleButton466.Text = "No Recoil [ON]";
				byte[] array = new byte[4];
				array[0] = 96;
				this.ixboxConsole_0.SetMemory(2183628696U, array);
			}
			else
			{
				this.simpleButton466.Text = "No Recoil [OFF]";
				this.ixboxConsole_0.SetMemory(2183628696U, new byte[]
				{
					75,
					247,
					164,
					105
				});
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0002C7F4 File Offset: 0x0002A9F4
		private void simpleButton465_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton465.Text == "No Spread [OFF]"))
			{
				this.simpleButton465.Text = "No Spread [OFF]";
				this.ixboxConsole_0.WriteFloat(2181668552U, 240f);
			}
			else
			{
				this.simpleButton465.Text = "No Spread [ON]";
				this.ixboxConsole_0.WriteFloat(2181668552U, 1f);
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0002C864 File Offset: 0x0002AA64
		private void simpleButton463_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton463.Text == "Wallhack [OFF]"))
			{
				this.simpleButton463.Text = "Wallhack [OFF]";
				this.ixboxConsole_0.SetMemory(2185951376U, new byte[]
				{
					124,
					240,
					59,
					120
				});
			}
			else
			{
				this.simpleButton463.Text = "Wallhack [ON]";
				this.ixboxConsole_0.SetMemory(2185951376U, new byte[]
				{
					58,
					0,
					byte.MaxValue,
					byte.MaxValue
				});
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0002C8EC File Offset: 0x0002AAEC
		private void simpleButton464_Click(object sender, EventArgs e)
		{
			if (this.simpleButton464.Text == "ESP [OFF]")
			{
				byte[] array = new byte[4];
				array[0] = 96;
				this.ixboxConsole_0.SetMemory(2187360480U, array);
				this.ixboxConsole_0.SetMemory(2187360520U, array);
				this.simpleButton464.Text = "ESP [ON]";
			}
			else
			{
				this.simpleButton464.Text = "ESP [OFF]";
				this.ixboxConsole_0.SetMemory(2187360480U, new byte[]
				{
					65,
					130,
					0,
					220
				});
				this.ixboxConsole_0.SetMemory(2187360520U, new byte[]
				{
					65,
					130,
					0,
					180
				});
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0002C9A8 File Offset: 0x0002ABA8
		private void simpleButton467_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187531824U, new object[]
			{
				0,
				this.textEdit_76.Text
			});
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0002C9E4 File Offset: 0x0002ABE4
		private void simpleButton468_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(this.getZPS(this.listBox4.SelectedIndex) + 35U, new byte[]
			{
				5
			});
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0002CA1C File Offset: 0x0002AC1C
		public string GetGamertagZ(int cli)
		{
			byte[] input = new byte[15];
			input = this.ixboxConsole_0.GetMemory(this.getZPS(cli) + 23984U, 15U);
			return this.ByteToStringBO3(input);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0002CA5C File Offset: 0x0002AC5C
		public uint getZPS(int Client)
		{
			return (uint)(-2075041584 + Client * 25016);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0002CA7C File Offset: 0x0002AC7C
		public byte[] trimZeros(byte[] input)
		{
			int num = input.Length;
			while (num-- > 0 && input[num] == 0)
			{
			}
			byte[] array = new byte[num + 1];
			Array.Copy(input, array, num + 1);
			return array;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0002CAC8 File Offset: 0x0002ACC8
		public string ByteToStringBO3(byte[] input)
		{
			UTF8Encoding utf8Encoding = new UTF8Encoding();
			string result;
			if (input.Length == 0)
			{
				result = "";
			}
			else
			{
				input = this.trimZeros(input);
				result = utf8Encoding.GetString(input);
			}
			return result;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0002CB04 File Offset: 0x0002AD04
		private void simpleButton473_Click(object sender, EventArgs e)
		{
			this.listBox4.Items.Clear();
			for (int i = 0; i < 4; i++)
			{
				if (this.GetGamertagZ(i) != "")
				{
					this.listBox4.Items.Add(i.ToString() + "= " + this.GetGamertagZ(i));
				}
				else
				{
					this.listBox4.Items.Add(i.ToString() + "= ");
				}
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0002CB98 File Offset: 0x0002AD98
		private void simpleButton470_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(this.getZPS(this.listBox4.SelectedIndex) + 23811U, new byte[]
			{
				1
			});
			this.ixboxConsole_0.SetMemory(this.getZPS(this.listBox4.SelectedIndex) + 24042U, new byte[1]);
			Thread.Sleep(5000);
			this.ixboxConsole_0.SetMemory(this.getZPS(0) + 23811U, new byte[]
			{
				2
			});
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0002CC28 File Offset: 0x0002AE28
		private void simpleButton469_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(this.getZPS(this.listBox4.SelectedIndex) + 35U, new byte[]
			{
				4
			});
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0002CC60 File Offset: 0x0002AE60
		private void simpleButton471_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(this.getZPS(this.listBox4.SelectedIndex) + 23811U, new byte[]
			{
				1
			});
			this.ixboxConsole_0.SetMemory(this.getZPS(this.listBox4.SelectedIndex) + 24042U, new byte[]
			{
				128
			});
			this.ixboxConsole_0.SetMemory(this.getZPS(this.listBox4.SelectedIndex) + 23811U, new byte[1]);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0002CCF4 File Offset: 0x0002AEF4
		private void simpleButton472_Click(object sender, EventArgs e)
		{
			int num = this.listBox4.SelectedIndex * 4;
			this.ixboxConsole_0.SetMemory((uint)((ulong)(this.getZPS(this.listBox4.SelectedIndex) + 1340U) + (ulong)((long)num)), new byte[]
			{
				0,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0002CD4C File Offset: 0x0002AF4C
		private void simpleButton474_Click(object sender, EventArgs e)
		{
			if (!(this.textEdit_78.Text == ""))
			{
				int num = int.Parse(this.textEdit_78.Text);
				if (num < 0)
				{
					num = 0;
				}
				if (num > 999999)
				{
					num = 999999;
				}
				byte[] bytes = BitConverter.GetBytes(num);
				Array.Reverse(bytes);
				this.ixboxConsole_0.SetMemory(this.getZPS(this.listBox4.SelectedIndex) + 24204U, bytes);
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0002CDD4 File Offset: 0x0002AFD4
		private void simpleButton475_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(0);
			Array.Reverse(bytes);
			this.ixboxConsole_0.SetMemory(this.getZPS(this.listBox4.SelectedIndex) + 24204U, bytes);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0002CE14 File Offset: 0x0002B014
		private void simpleButton476_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[4];
			array[0] = 96;
			this.ixboxConsole_0.SetMemory(2188035252U, array);
			this.ixboxConsole_0.SetMemory(2188035320U, array);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0002CE54 File Offset: 0x0002B054
		private void simpleButton477_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187745640U, new object[]
			{
				-1,
				0,
				this.textEdit_77.Text
			});
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0002CE98 File Offset: 0x0002B098
		private void method_56()
		{
			this.ixboxConsole_0.CallVoid(2187568800U, new object[]
			{
				0,
				"uploadstats"
			});
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0002CECC File Offset: 0x0002B0CC
		private void simpleButton415_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187568800U, new object[]
			{
				0,
				"statsetbyname PLEVEL " + int.Parse(this.numericUpDown49.Text).ToString()
			});
			this.method_56();
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0002CF24 File Offset: 0x0002B124
		private void simpleButton418_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187568800U, new object[]
			{
				0,
				"statsetbyname RANKXP " + int.Parse(this.numericUpDown52.Text).ToString()
			});
			this.method_56();
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0002CF7C File Offset: 0x0002B17C
		private void simpleButton479_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187568800U, new object[]
			{
				0,
				"statsetbyname SCORE " + int.Parse(this.numericUpDown54.Text).ToString()
			});
			this.method_56();
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0002CFD4 File Offset: 0x0002B1D4
		private void simpleButton417_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187568800U, new object[]
			{
				0,
				"statsetbyname WINS " + int.Parse(this.numericUpDown53.Text).ToString()
			});
			this.method_56();
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0002D02C File Offset: 0x0002B22C
		private void simpleButton416_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187568800U, new object[]
			{
				0,
				"statsetbyname LOSSES " + int.Parse(this.numericUpDown50.Text).ToString()
			});
			this.method_56();
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0002D084 File Offset: 0x0002B284
		private void simpleButton480_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187568800U, new object[]
			{
				0,
				"statsetbyname KILLS " + int.Parse(this.numericUpDown56.Text).ToString()
			});
			this.method_56();
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0002D0DC File Offset: 0x0002B2DC
		private void simpleButton481_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187568800U, new object[]
			{
				0,
				"statsetbyname HEADSHOTS " + int.Parse(this.numericUpDown57.Text).ToString()
			});
			this.method_56();
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0002D134 File Offset: 0x0002B334
		private void simpleButton482_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187568800U, new object[]
			{
				0,
				"statsetbyname TIMEPLAYED " + int.Parse(this.numericUpDown61.Text).ToString()
			});
			this.method_56();
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0002D18C File Offset: 0x0002B38C
		private void simpleButton478_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187568800U, new object[]
			{
				0,
				"statsetbyname DEATHS " + int.Parse(this.numericUpDown55.Text).ToString()
			});
			this.method_56();
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0002D1E4 File Offset: 0x0002B3E4
		private void simpleButton483_Click(object sender, EventArgs e)
		{
			this.numericUpDown49.Text = "11";
			this.numericUpDown52.Text = "3000000";
			this.numericUpDown52.Text = "3000000";
			this.numericUpDown56.Text = "50000";
			this.numericUpDown61.Text = "500";
			this.numericUpDown53.Text = "50000";
			this.numericUpDown50.Text = "2500";
			this.numericUpDown55.Text = "1500";
			this.numericUpDown57.Text = "50000";
			this.simpleButton415_Click(sender, null);
			Thread.Sleep(100);
			this.simpleButton418_Click(sender, null);
			Thread.Sleep(100);
			this.simpleButton418_Click(sender, null);
			Thread.Sleep(100);
			this.simpleButton478_Click(sender, null);
			Thread.Sleep(100);
			this.simpleButton482_Click(sender, null);
			Thread.Sleep(100);
			this.simpleButton481_Click(sender, null);
			Thread.Sleep(100);
			this.simpleButton480_Click(sender, null);
			Thread.Sleep(100);
			this.simpleButton416_Click(sender, null);
			Thread.Sleep(100);
			this.simpleButton417_Click(sender, null);
			Thread.Sleep(100);
			this.ixboxConsole_0.XNotify("Quick Stats Set!");
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0002D318 File Offset: 0x0002B518
		private void simpleButton484_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.XNotify("Unlock All Started, This May Take A While!");
			Random random = new Random();
			this.method_57(string.Concat(new object[]
			{
				"statwriteddl playerstatslist 28 challengevalue ",
				random.Next(250, 999),
				";statwriteddl playerstatslist 29 challengevalue ",
				random.Next(250, 999)
			}));
			this.method_57(string.Concat(new object[]
			{
				"statwriteddl playerstatslist 30 challengevalue ",
				random.Next(250, 999),
				";statwriteddl playerstatslist 31 challengevalue ",
				random.Next(250, 999)
			}));
			for (int i = 0; i < 100; i++)
			{
				this.method_57(string.Concat(new object[]
				{
					"statwriteddl itemstats ",
					i,
					" stats headshots challengevalue ",
					random.Next(250, 999),
					";statwriteddl itemstats ",
					i,
					" stats challenge1 challengevalue ",
					random.Next(250, 999),
					";statwriteddl itemstats ",
					i,
					" stats challenge2 challengevalue ",
					random.Next(250, 999)
				}));
				this.method_57(string.Concat(new object[]
				{
					"statwriteddl itemstats ",
					i,
					" stats challenge3 challengevalue ",
					random.Next(250, 999),
					";statwriteddl itemstats ",
					i,
					" stats challenge4 challengevalue ",
					random.Next(250, 999),
					";statwriteddl itemstats ",
					i,
					" stats challenge5 challengevalue ",
					random.Next(250, 999)
				}));
				this.method_57(string.Concat(new object[]
				{
					"statwriteddl itemstats ",
					i,
					" stats challenge6 challengevalue ",
					random.Next(12, 22),
					";statwriteddl itemstats ",
					i,
					" stats kills challengevalue ",
					random.Next(12, 22),
					";statwriteddl itemstats ",
					i,
					" stats challenge7 challengevalue ",
					random.Next(12, 22)
				}));
				this.method_57(string.Concat(new object[]
				{
					"statwriteddl itemstats ",
					i,
					" plevel 2;statwriteddl itemstats ",
					i,
					" xp 133337"
				}));
				this.method_57(string.Concat(new object[]
				{
					"statwriteddl itemstats ",
					i,
					" stats kills statvalue ",
					random.Next(12, 22),
					";statwriteddl itemstats ",
					i,
					" stats challenges challengevalue ",
					random.Next(250, 999)
				}));
			}
			this.method_57(string.Concat(new object[]
			{
				"statwriteddl playerstatslist 32 challengevalue ",
				random.Next(250, 999),
				";statwriteddl playerstatslist 33 challengevalue ",
				random.Next(250, 999),
				";statwriteddl playerstatslist 34 challengevalue ",
				random.Next(250, 999)
			}));
			this.method_57(string.Concat(new object[]
			{
				"statwriteddl playerstatslist 35 challengevalue ",
				random.Next(250, 999),
				";statwriteddl playerstatslist 36 challengevalue ",
				random.Next(250, 999),
				";statwriteddl playerstatslist 37 challengevalue ",
				random.Next(250, 999)
			}));
			for (int j = 0; j < 596; j += 2)
			{
				this.method_57(string.Concat(new object[]
				{
					"statwriteddl playerstatslist ",
					this.string_2[j],
					" challengevalue ",
					random.Next(12, 22),
					";statwriteddl playerstatslist ",
					this.string_2[j + 1],
					" challengevalue ",
					random.Next(12, 22)
				}));
			}
			this.method_57(string.Concat(new object[]
			{
				"statwriteddl playerstatsbygametype tdm wins challengevalue ",
				random.Next(400, 501),
				";statwriteddl playerstatsbygametype hctdm wins challengevalue ",
				random.Next(400, 501),
				";statwriteddl playerstatsbygametype dm wins challengevalue ",
				random.Next(400, 501)
			}));
			this.method_57(string.Concat(new object[]
			{
				"statwriteddl playerstatsbygametype hcsd wins challengevalue ",
				random.Next(400, 501),
				";statwriteddl playerstatsbygametype sd wins challengevalue ",
				random.Next(400, 501),
				";statwriteddl playerstatsbygametype hcdem wins challengevalue ",
				random.Next(400, 501)
			}));
			this.method_57(string.Concat(new object[]
			{
				"statwriteddl playerstatsbygametype dom wins challengevalue ",
				random.Next(400, 501),
				";statwriteddl playerstatsbygametype hcdom wins challengevalue ",
				random.Next(400, 501),
				";statwriteddl playerstatsbygametype dem wins challengevalue ",
				random.Next(400, 501)
			}));
			this.method_57(string.Concat(new object[]
			{
				"statwriteddl playerstatsbygametype hckoth wins challengevalue ",
				random.Next(400, 501),
				";statwriteddl playerstatsbygametype koth wins challengevalue ",
				random.Next(400, 501),
				";statwriteddl playerstatsbygametype hcconf wins challengevalue ",
				random.Next(400, 501)
			}));
			this.method_57(string.Concat(new object[]
			{
				"statwriteddl playerstatsbygametype gun wins challengevalue ",
				random.Next(300, 501),
				";statwriteddl playerstatsbygametype ball wins challengevalue ",
				random.Next(400, 501),
				";statwriteddl playerstatsbygametype ctf wins challengevalue ",
				random.Next(300, 501)
			}));
			this.method_57(string.Concat(new object[]
			{
				"statwriteddl playerstatsbygametype sr wins challengevalue ",
				random.Next(400, 501),
				";statwriteddl playerstatsbygametype conf wins challengevalue ",
				random.Next(300, 510),
				";statwriteddl playerstatsbygametype fr wins challengevalue ",
				random.Next(400, 501)
			}));
			this.method_57(string.Concat(new object[]
			{
				"statwriteddl playerstatsbygametype oic wins challengevalue ",
				random.Next(300, 510),
				";statwriteddl playerstatsbygametype escort wins challengevalue ",
				random.Next(400, 501)
			}));
			this.ixboxConsole_0.XNotify("Unlock All Finished");
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0002DB30 File Offset: 0x0002BD30
		private void method_57(string string_3)
		{
			this.ixboxConsole_0.CallVoid(2187568800U, new object[]
			{
				0,
				string_3.ToString()
			});
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0002DB68 File Offset: 0x0002BD68
		private void simpleButton485_Click(object sender, EventArgs e)
		{
			this.method_57("resetstats;");
			this.method_56();
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0002DB88 File Offset: 0x0002BD88
		private void method_58()
		{
			this.ixboxConsole_0.CallVoid(2187531824U, new object[]
			{
				0,
				"uploadstats"
			});
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0002DBBC File Offset: 0x0002BDBC
		private void simpleButton486_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187531824U, new object[]
			{
				0,
				"statsetbyname PLEVEL " + int.Parse(this.numericUpDown73.Text).ToString()
			});
			this.method_58();
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0002DC14 File Offset: 0x0002BE14
		private void simpleButton487_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187531824U, new object[]
			{
				0,
				"statsetbyname RANKXP " + int.Parse(this.numericUpDown76.Text).ToString()
			});
			this.method_58();
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0002DC6C File Offset: 0x0002BE6C
		private void simpleButton488_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187531824U, new object[]
			{
				0,
				"statsetbyname SCORE " + int.Parse(this.numericUpDown77.Text).ToString()
			});
			this.method_58();
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0002DCC4 File Offset: 0x0002BEC4
		private void simpleButton490_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187531824U, new object[]
			{
				0,
				"statsetbyname KILLS " + int.Parse(this.numericUpDown79.Text).ToString()
			});
			this.method_58();
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0002DD1C File Offset: 0x0002BF1C
		private void simpleButton493_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187531824U, new object[]
			{
				0,
				"statsetbyname TOTAL_ROUNDS_SURVIVED " + int.Parse(this.numericUpDown82.Text).ToString()
			});
			this.method_58();
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0002DD74 File Offset: 0x0002BF74
		private void simpleButton494_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187531824U, new object[]
			{
				0,
				"statsetbyname PERKS_DRANK " + int.Parse(this.numericUpDown83.Text).ToString()
			});
			this.method_58();
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0002DDCC File Offset: 0x0002BFCC
		private void simpleButton496_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187531824U, new object[]
			{
				0,
				"statsetbyname RANK " + int.Parse(this.numericUpDown85.Text).ToString()
			});
			this.method_58();
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0002DE24 File Offset: 0x0002C024
		private void simpleButton489_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187531824U, new object[]
			{
				0,
				"statsetbyname DEATHS " + int.Parse(this.numericUpDown78.Text).ToString()
			});
			this.method_58();
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0002DE7C File Offset: 0x0002C07C
		private void simpleButton491_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187531824U, new object[]
			{
				0,
				"statsetbyname HEADSHOTS " + int.Parse(this.numericUpDown80.Text).ToString()
			});
			this.method_58();
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0002DED4 File Offset: 0x0002C0D4
		private void simpleButton492_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187531824U, new object[]
			{
				0,
				"statsetbyname TIMEPLAYED " + int.Parse(this.numericUpDown81.Text).ToString()
			});
			this.method_58();
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0002DF2C File Offset: 0x0002C12C
		private void simpleButton495_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187531824U, new object[]
			{
				0,
				"resetstats"
			});
			this.method_58();
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0002DF68 File Offset: 0x0002C168
		private void simpleButton498_Click(object sender, EventArgs e)
		{
			this.numericUpDown73.Text = "11";
			this.numericUpDown76.Text = "3000000";
			this.numericUpDown77.Text = "3000000";
			this.numericUpDown79.Text = "50000";
			this.numericUpDown81.Text = "500";
			this.numericUpDown78.Text = "1500";
			this.numericUpDown80.Text = "50000";
			this.numericUpDown85.Text = "34";
			this.numericUpDown83.Text = "2500";
			this.numericUpDown82.Text = "5000";
			this.simpleButton486_Click(sender, null);
			Thread.Sleep(100);
			this.simpleButton487_Click(sender, null);
			Thread.Sleep(100);
			this.simpleButton488_Click(sender, null);
			Thread.Sleep(100);
			this.simpleButton490_Click(sender, null);
			Thread.Sleep(100);
			this.simpleButton493_Click(sender, null);
			Thread.Sleep(100);
			this.simpleButton494_Click(sender, null);
			Thread.Sleep(100);
			this.simpleButton496_Click(sender, null);
			Thread.Sleep(100);
			this.simpleButton489_Click(sender, null);
			Thread.Sleep(100);
			this.simpleButton491_Click(sender, null);
			Thread.Sleep(100);
			this.simpleButton492_Click(sender, null);
			Thread.Sleep(100);
			this.ixboxConsole_0.XNotify("Quick Stats Set!");
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0002E0BC File Offset: 0x0002C2BC
		private void simpleButton507_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statSetByName PLEVEL " + this.numericUpDown92.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0002E108 File Offset: 0x0002C308
		private void simpleButton508_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statSetByName RANKXP " + this.numericUpDown93.Text + ";updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statsetbyname RANK 55; updategamerprofile;uploadstats"
			});
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0002E178 File Offset: 0x0002C378
		private void simpleButton505_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statSetByName SCORE " + this.numericUpDown90.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0002E1C4 File Offset: 0x0002C3C4
		private void simpleButton506_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statSetByName KILLS " + this.numericUpDown91.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0002E210 File Offset: 0x0002C410
		private void simpleButton504_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statSetByName DEATHS " + this.numericUpDown89.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0002E25C File Offset: 0x0002C45C
		private void simpleButton502_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statSetByName WINS " + this.numericUpDown87.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0002E2A8 File Offset: 0x0002C4A8
		private void simpleButton503_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statSetByName LOSSES " + this.numericUpDown88.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0002E2F4 File Offset: 0x0002C4F4
		private void simpleButton499_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statSetByName TIME_PLAYED_TOTAL " + this.numericUpDown84.Text + ";updategamerprofile;uploadstats"
			});
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0002E340 File Offset: 0x0002C540
		private void simpleButton501_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[4];
			array[0] = 192;
			array[1] = 63;
			this.ixboxConsole_0.SetMemory(2218076872U, array);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0002E378 File Offset: 0x0002C578
		private void simpleButton509_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2218080848U, new byte[]
			{
				82,
				1
			});
			this.ixboxConsole_0.SetMemory(2218080862U, new byte[]
			{
				168
			});
			this.ixboxConsole_0.SetMemory(2218080901U, new byte[]
			{
				21
			});
			this.ixboxConsole_0.SetMemory(2218080914U, new byte[]
			{
				128,
				10
			});
			this.ixboxConsole_0.SetMemory(2218080953U, new byte[]
			{
				80,
				1
			});
			this.ixboxConsole_0.SetMemory(2218080967U, new byte[]
			{
				168
			});
			this.ixboxConsole_0.SetMemory(2218081006U, new byte[]
			{
				21
			});
			this.ixboxConsole_0.SetMemory(2218081019U, new byte[]
			{
				128,
				10
			});
			this.ixboxConsole_0.SetMemory(2218081058U, new byte[]
			{
				80,
				1
			});
			this.ixboxConsole_0.SetMemory(2218081072U, new byte[]
			{
				168
			});
			this.ixboxConsole_0.SetMemory(2218081111U, new byte[]
			{
				21
			});
			this.ixboxConsole_0.SetMemory(2218081124U, new byte[]
			{
				128,
				10
			});
			this.ixboxConsole_0.SetMemory(2218081163U, new byte[]
			{
				80,
				1
			});
			this.ixboxConsole_0.SetMemory(2218081177U, new byte[]
			{
				168
			});
			this.ixboxConsole_0.SetMemory(2218081216U, new byte[]
			{
				21
			});
			this.ixboxConsole_0.SetMemory(2218081229U, new byte[]
			{
				128,
				10
			});
			this.ixboxConsole_0.SetMemory(2218081268U, new byte[]
			{
				80,
				1
			});
			this.ixboxConsole_0.SetMemory(2218081282U, new byte[]
			{
				168
			});
			this.ixboxConsole_0.SetMemory(2218081321U, new byte[]
			{
				21
			});
			this.ixboxConsole_0.SetMemory(2218081334U, new byte[]
			{
				128,
				10
			});
			this.ixboxConsole_0.XNotify("Ghost Camo Applied To All Classes!");
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0002E5FC File Offset: 0x0002C7FC
		private void simpleButton500_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statSetByName PLEVEL " + this.numericUpDown92.Text
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statSetByName RANKXP " + this.numericUpDown93.Text
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statSetByName SCORE " + this.numericUpDown90.Text
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statSetByName KILLS " + this.numericUpDown91.Text
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statSetByName DEATHS " + this.numericUpDown89.Text
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statSetByName WINS " + this.numericUpDown87.Text
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statSetByName LOSSES " + this.numericUpDown88.Text
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statSetByName TIME_PLAYED_TOTAL " + this.numericUpDown84.Text
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statSetByName RANK 55"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.XNotify("All stats set!");
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0002E820 File Offset: 0x0002CA20
		private void simpleButton497_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"resetstats;updategamerprofile;uploadstats"
			});
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0002E854 File Offset: 0x0002CA54
		private void simpleButton510_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 0 " + this.textEdit_88.Text.Replace(" ", "_") + "\0"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 1 " + this.textEdit_84.Text.Replace(" ", "_") + "\0"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 2 " + this.textEdit_85.Text.Replace(" ", "_") + "\0"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 3 " + this.textEdit_87.Text.Replace(" ", "_") + "\0"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 4 " + this.textEdit_86.Text.Replace(" ", "_") + "\0"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 5 " + this.textEdit_83.Text.Replace(" ", "_") + "\0"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 6 " + this.textEdit_79.Text.Replace(" ", "_") + "\0"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 7 " + this.textEdit_80.Text.Replace(" ", "_") + "\0"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 8 " + this.textEdit_82.Text.Replace(" ", "_") + "\0"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"setStatFromLocString cacloadouts customclassname 9 " + this.textEdit_81.Text.Replace(" ", "_") + "\0"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 0 " + this.textEdit_88.Text.Replace(" ", "_") + "\0"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 1 " + this.textEdit_84.Text.Replace(" ", "_") + "\0"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 2 " + this.textEdit_85.Text.Replace(" ", "_") + "\0"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 3 " + this.textEdit_87.Text.Replace(" ", "_") + "\0"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"setStatFromLocString custommatchcacloadouts customclassname 4 " + this.textEdit_86.Text.Replace(" ", "_") + "\0"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"updatestats"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"updategamerprofile"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"updatestats"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"updategamerprofile"
			});
			this.ixboxConsole_0.XNotify("Custom Class Names Set!");
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0002ED74 File Offset: 0x0002CF74
		private void simpleButton511_Click(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				string str = Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "";
				this.textEdit_88.Text = "^1" + str;
				this.textEdit_84.Text = "^2" + str;
				this.textEdit_85.Text = "^3" + str;
				this.textEdit_87.Text = "^4" + str;
				this.textEdit_86.Text = "^5" + str;
				this.textEdit_83.Text = "^1" + str;
				this.textEdit_79.Text = "^2" + str;
				this.textEdit_80.Text = "^3" + str;
				this.textEdit_82.Text = "^4" + str;
				this.textEdit_81.Text = "^5" + str;
				this.simpleButton510_Click(sender, null);
			}
			else
			{
				string text = this.textEdit_158.Text;
				this.textEdit_88.Text = "^1" + text;
				this.textEdit_84.Text = "^2" + text;
				this.textEdit_85.Text = "^3" + text;
				this.textEdit_87.Text = "^4" + text;
				this.textEdit_86.Text = "^5" + text;
				this.textEdit_83.Text = "^1" + text;
				this.textEdit_79.Text = "^2" + text;
				this.textEdit_80.Text = "^3" + text;
				this.textEdit_82.Text = "^4" + text;
				this.textEdit_81.Text = "^5" + text;
				this.simpleButton510_Click(sender, null);
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0002EFB4 File Offset: 0x0002D1B4
		private void simpleButton546_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"fast_restart"
			});
			this.ixboxConsole_0.XNotify("Restarting Game!");
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0002EFF8 File Offset: 0x0002D1F8
		private void simpleButton541_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"cmd mr " + this.ixboxConsole_0.ReadUInt32(2193708888U).ToString() + " -1 changeteam;"
			});
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0002F050 File Offset: 0x0002D250
		private void simpleButton545_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton545.Text == "Super Jump [OFF]"))
			{
				this.simpleButton545.Text = "Super Jump [OFF]";
				this.ixboxConsole_0.WriteFloat(2181584468U, 39f);
			}
			else
			{
				this.simpleButton545.Text = "Super Jump [ON]";
				this.ixboxConsole_0.WriteFloat(2181584468U, 29999f);
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0002F0C0 File Offset: 0x0002D2C0
		private void simpleButton542_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185427824U, new object[]
			{
				-1,
				0,
				"< \"^H\""
			});
			this.ixboxConsole_0.CallVoid(2185427824U, new object[]
			{
				-1,
				0,
				"O \"^H\""
			});
			Thread.Sleep(1000);
			this.ixboxConsole_0.CallVoid(2185427824U, new object[]
			{
				-1,
				0,
				"< \"^H\""
			});
			this.ixboxConsole_0.CallVoid(2185427824U, new object[]
			{
				-1,
				0,
				"O \"^H\""
			});
			Thread.Sleep(1000);
			this.ixboxConsole_0.CallVoid(2185427824U, new object[]
			{
				-1,
				0,
				"< \"^H\""
			});
			this.ixboxConsole_0.CallVoid(2185427824U, new object[]
			{
				-1,
				0,
				"O \"^H\""
			});
			Thread.Sleep(1000);
			this.ixboxConsole_0.CallVoid(2185427824U, new object[]
			{
				-1,
				0,
				"< \"^H\""
			});
			this.ixboxConsole_0.CallVoid(2185427824U, new object[]
			{
				-1,
				0,
				"O \"^H\""
			});
			Thread.Sleep(1000);
			this.ixboxConsole_0.CallVoid(2185427824U, new object[]
			{
				-1,
				0,
				"< \"^H\""
			});
			this.ixboxConsole_0.CallVoid(2185427824U, new object[]
			{
				-1,
				0,
				"O \"^H\""
			});
			Thread.Sleep(1000);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0002F2E0 File Offset: 0x0002D4E0
		private void simpleButton539_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton539.Text == "Super Speed [OFF]"))
			{
				this.simpleButton539.Text = "Super Speed [OFF]";
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"seta g_speed 165"
				});
			}
			else
			{
				this.simpleButton539.Text = "Super Speed [ON]";
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"seta g_speed 650"
				});
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0002F374 File Offset: 0x0002D574
		private void simpleButton543_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[4];
			array[0] = 96;
			this.ixboxConsole_0.SetMemory(2188109596U, array);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0002F3A4 File Offset: 0x0002D5A4
		private void simpleButton540_Click(object sender, EventArgs e)
		{
			if (this.simpleButton540.Text == "Low Gravity [OFF]")
			{
				this.simpleButton540.Text = "Low Gravity [ON]";
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"seta bg_gravity \"125\""
				});
			}
			else
			{
				this.simpleButton540.Text = "Low Gravity [OFF]";
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"seta bg_gravity \"800\""
				});
			}
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0002F438 File Offset: 0x0002D638
		private void simpleButton557_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"set party_maxplayers 18;set party_minplayers 12"
			});
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0002F46C File Offset: 0x0002D66C
		private void simpleButton544_Click(object sender, EventArgs e)
		{
			string[] array = new string[]
			{
				"# ZM_DLC2_TRAPPED_IN_TIME",
				"# ZM_DLC2_POP_GOES_THE_WEASEL",
				"# ZM_DLC2_FULL_LOCKDOWN",
				"# ZM_DLC2_GG_BRIDGE",
				"# ZM_DLC2_PARANORMAL_PROGRESS",
				"# ZM_DLC2_A_BURST_OF_FLAVOR",
				"# ZM_DLC2_FEED_THE_BEAST",
				"# ZM_DLC2_ACID_DRIP",
				"# ZM_DLC2_MAKING_THE_ROUNDS",
				"# ZM_DLC1_MONKEY_SEE_MONKEY_DOOM",
				"# ZM_DLC2_PRISON_SIDEQUEST",
				"# ZM_DLC1_I_SEE_LIVE_PEOPLE",
				"# ZM_DLC1_FACING_THE_DRAGON",
				"# ZM_DLC1_POLYARMORY",
				"# ZM_DLC1_IM_MY_OWN_BEST_FRIEND",
				"# ZM_DLC1_MAD_WITHOUT_POWER",
				"# ZM_DLC1_SLIPPERY_WHEN_UNDEAD",
				"# ZM_DLC1_SHAFTED",
				"# ZM_HAPPY_HOUR",
				"# ZM_DLC1_VERTIGONER",
				"# ZM_DLC1_HIGHRISE_SIDEQUEST",
				"# ZM_YOU_HAVE_NO_POWER_OVER_ME",
				"# ZM_FUEL_EFFICIENT",
				"# ZM_I_DONT_THINK_THEY_EXIST",
				"# ZM_UNDEAD_MANS_PARTY_BUS",
				"# ZM_STANDARD_EQUIPMENT_MAY_VARY",
				"# ZM_DANCE_ON_MY_GRAVE",
				"# ZM_TRANSIT_SIDEQUEST",
				"# ZM_THE_LIGHTS_OF_THEIR_EYES",
				"# ZM_DONT_FIRE_UNTIL_YOU_SEE",
				"# MP_MISC_3",
				"# MP_MISC_5",
				"# MP_MISC_4",
				"# SP_MISC_10K_SCORE_ALL",
				"# MP_MISC_2",
				"# MP_MISC_1",
				"# SP_BACK_TO_FUTURE",
				"# SP_MISC_WEAPONS",
				"# SP_STORY_99PERCENT",
				"# SP_STORY_CHLOE_LIVES",
				"# SP_MISC_ALL_INTEL",
				"# SP_STORY_MENENDEZ_CAPTURED",
				"# SP_STORY_HARPER_LIVES",
				"# SP_STORY_LINK_CIA",
				"# SP_STORY_OBAMA_SURVIVES",
				"# ZM_DLC3_WHEN_THE_REVOLUTION_COMES",
				"# SP_STORY_FARID_DUEL",
				"# SP_STORY_HARPER_FACE",
				"# SP_STORY_MASON_LIVES",
				"# SP_RTS_SOCOTRA",
				"# SP_RTS_PAKISTAN",
				"# SP_RTS_CARRIER",
				"# SP_RTS_DRONE",
				"# SP_RTS_AFGHANISTAN",
				"# SP_RTS_DOCKSIDE",
				"# SP_ONE_CHALLENGE",
				"# SP_ALL_CHALLENGES_IN_LEVEL",
				"# SP_ALL_CHALLENGES_IN_GAME",
				"# SP_VETERAN_FUTURE",
				"# SP_VETERAN_PAST",
				"# SP_COMPLETE_HAITI",
				"# SP_COMPLETE_LA",
				"# SP_COMPLETE_BLACKOUT",
				"# SP_COMPLETE_YEMEN",
				"# SP_COMPLETE_PANAMA",
				"# SP_COMPLETE_KARMA",
				"# SP_COMPLETE_PAKISTAN",
				"# SP_COMPLETE_NICARAGUA",
				"# SP_COMPLETE_AFGHANISTAN",
				"# SP_COMPLETE_MONSOON",
				"# SP_COMPLETE_ANGOLA",
				"# ZM_DLC3_FSIRT_AGAINST_THE_WALL",
				"# ZM_DLC3_AWAKEN_THE_GAZEBO",
				"# ZM_DLC3_MAZED_AND_CONFUSED",
				"# ZM_DLC3_BURIED_SIDEQUEST",
				"# ZM_DLC3_IM_YOUR_HUCKLEBERRY",
				"# ZM_DLC3_ECTOPLASMIC_RESIDUE",
				"# ZM_DLC3_DEATH_FROM_BELOW",
				"# ZM_DLC3_CANDYGRAM",
				"# ZM_DLC3_REVISIONIST_HISTORIAN"
			};
			for (int i = 0; i < 81; i++)
			{
				Thread.Sleep(25);
				try
				{
					this.ixboxConsole_0.CallVoid(2185427824U, new object[]
					{
						-1,
						0,
						array[i]
					});
				}
				catch (Exception)
				{
				}
				Thread.Sleep(75);
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0002F7B0 File Offset: 0x0002D9B0
		private void simpleButton548_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit18.SelectedIndex == 0)
			{
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"map mp_la"
				});
			}
			if (this.comboBoxEdit18.SelectedIndex == 1)
			{
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"map mp_dockside"
				});
			}
			if (this.comboBoxEdit18.SelectedIndex == 2)
			{
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"map mp_carrier"
				});
			}
			if (this.comboBoxEdit18.SelectedIndex == 3)
			{
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"map mp_drone"
				});
			}
			if (this.comboBoxEdit18.SelectedIndex == 4)
			{
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"map mp_express"
				});
			}
			if (this.comboBoxEdit18.SelectedIndex == 5)
			{
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"map mp_hijacked"
				});
			}
			if (this.comboBoxEdit18.SelectedIndex == 6)
			{
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"map mp_meltdown"
				});
			}
			if (this.comboBoxEdit18.SelectedIndex == 7)
			{
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"map mp_nuketown_2020"
				});
			}
			if (this.comboBoxEdit18.SelectedIndex == 8)
			{
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"map mp_overflow"
				});
			}
			if (this.comboBoxEdit18.SelectedIndex == 9)
			{
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"map mp_nightclub"
				});
			}
			if (this.comboBoxEdit18.SelectedIndex == 10)
			{
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"map mp_raid"
				});
			}
			if (this.comboBoxEdit18.SelectedIndex == 11)
			{
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"map mp_slums"
				});
			}
			if (this.comboBoxEdit18.SelectedIndex == 12)
			{
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"map mp_village"
				});
			}
			if (this.comboBoxEdit18.SelectedIndex == 13)
			{
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"map mp_turbine"
				});
			}
			if (this.comboBoxEdit18.SelectedIndex == 14)
			{
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"map mp_socotra"
				});
			}
			this.ixboxConsole_0.XNotify("Changed map to : " + this.comboBoxEdit18.SelectedItem.ToString());
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0002FB24 File Offset: 0x0002DD24
		private void simpleButton549_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185427824U, new object[]
			{
				-1,
				0,
				this.textEdit_93.Text
			});
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0002FB68 File Offset: 0x0002DD68
		private void simpleButton550_Click(object sender, EventArgs e)
		{
			this.listBox5.Items.Clear();
			this.listBox5.Items.Add("0= " + this.ixboxConsole_0.ReadString(2203414204U, 16U));
			this.listBox5.Items.Add("1= " + this.ixboxConsole_0.ReadString(2203436724U, 16U));
			this.listBox5.Items.Add("2= " + this.ixboxConsole_0.ReadString(2203459244U, 16U));
			this.listBox5.Items.Add("3= " + this.ixboxConsole_0.ReadString(2203481764U, 16U));
			this.listBox5.Items.Add("4= " + this.ixboxConsole_0.ReadString(2203504284U, 16U));
			this.listBox5.Items.Add("5= " + this.ixboxConsole_0.ReadString(2203526804U, 16U));
			this.listBox5.Items.Add("6= " + this.ixboxConsole_0.ReadString(2203549324U, 16U));
			this.listBox5.Items.Add("7= " + this.ixboxConsole_0.ReadString(2203571844U, 16U));
			this.listBox5.Items.Add("8= " + this.ixboxConsole_0.ReadString(2203594364U, 16U));
			this.listBox5.Items.Add("9= " + this.ixboxConsole_0.ReadString(2203616884U, 16U));
			this.listBox5.Items.Add("10= " + this.ixboxConsole_0.ReadString(2203639404U, 16U));
			this.listBox5.Items.Add("11= " + this.ixboxConsole_0.ReadString(2203661924U, 16U));
			this.listBox5.Items.Add("12= " + this.ixboxConsole_0.ReadString(2203684444U, 16U));
			this.listBox5.Items.Add("13= " + this.ixboxConsole_0.ReadString(2203706964U, 16U));
			this.listBox5.Items.Add("14= " + this.ixboxConsole_0.ReadString(2203729484U, 16U));
			this.listBox5.Items.Add("15= " + this.ixboxConsole_0.ReadString(2203752004U, 16U));
			this.listBox5.Items.Add("16= " + this.ixboxConsole_0.ReadString(2203774524U, 16U));
			this.listBox5.Items.Add("17= " + this.ixboxConsole_0.ReadString(2203797044U, 16U));
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0002FEB0 File Offset: 0x0002E0B0
		private void simpleButton551_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory((uint)(this.listBox5.SelectedIndex * 22520 - 2091574768 + 27), new byte[]
			{
				5
			});
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0002FEEC File Offset: 0x0002E0EC
		private void simpleButton552_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory((uint)(this.listBox5.SelectedIndex * 22520 - 2091574768 + 27), new byte[]
			{
				4
			});
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0002FF28 File Offset: 0x0002E128
		private void simpleButton553_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185427824U, new object[]
			{
				this.listBox5.SelectedIndex,
				0,
				"5 \"" + this.textEdit_92.Text + "\""
			});
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0002FF84 File Offset: 0x0002E184
		private void simpleButton556_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185427824U, new object[]
			{
				-1,
				0,
				"5 \"" + this.textEdit_91.Text + "\""
			});
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0002FFD8 File Offset: 0x0002E1D8
		private void simpleButton554_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185427824U, new object[]
			{
				this.listBox5.SelectedIndex,
				0,
				"5 ^H^H^H"
			});
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00030020 File Offset: 0x0002E220
		private void simpleButton555_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185427824U, new object[]
			{
				this.listBox5.SelectedIndex,
				0,
				"7 30 90"
			});
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00030068 File Offset: 0x0002E268
		private void simpleButton547_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit17.SelectedIndex == 0)
			{
				this.ixboxConsole_0.CallVoid(2185427824U, new object[]
				{
					this.listBox5.SelectedIndex,
					0,
					"^ 5 1"
				});
			}
			if (this.comboBoxEdit17.SelectedIndex == 1)
			{
				this.ixboxConsole_0.CallVoid(2185427824U, new object[]
				{
					this.listBox5.SelectedIndex,
					0,
					"^ 5 150"
				});
			}
			if (this.comboBoxEdit17.SelectedIndex == 2)
			{
				this.ixboxConsole_0.CallVoid(2185427824U, new object[]
				{
					this.listBox5.SelectedIndex,
					0,
					"^ 12 1"
				});
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00030154 File Offset: 0x0002E354
		private void simpleButton558_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185427824U, new object[]
			{
				-1,
				0,
				"< \"" + this.textEdit_94.Text + "\""
			});
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000301A8 File Offset: 0x0002E3A8
		private void simpleButton559_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185427824U, new object[]
			{
				-1,
				0,
				"O \"" + this.textEdit_94.Text + "\""
			});
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000301FC File Offset: 0x0002E3FC
		private void simpleButton512_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"disconnect"
			});
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00030230 File Offset: 0x0002E430
		private void simpleButton515_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"cmd mr " + this.ixboxConsole_0.ReadInt32(2193708888U).ToString() + " -1 endround"
			});
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00030288 File Offset: 0x0002E488
		private void simpleButton516_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				string.Format("cmd mr {0} -1 killserverpc", this.ixboxConsole_0.ReadInt32(2193708888U))
			});
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000302D8 File Offset: 0x0002E4D8
		private void simpleButton517_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"cmd sl"
			});
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0003030C File Offset: 0x0002E50C
		private void simpleButton519_Click(object sender, EventArgs e)
		{
			IXboxConsole console = this.ixboxConsole_0;
			byte[] array = new byte[4];
			array[0] = 96;
			console.SetMemory(2183636224U, array);
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"set party_minplayers 1;xpartygo"
			});
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00030364 File Offset: 0x0002E564
		private void simpleButton518_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"set party_minplayers 1"
			});
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00030398 File Offset: 0x0002E598
		private void simpleButton520_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton520.Text == "Force Host [OFF]"))
			{
				this.simpleButton520.Text = "Force Host [OFF]";
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"party_connectToOthers 1;partyMigrate_disabled 0;set party_minplayers 1"
				});
			}
			else
			{
				this.simpleButton520.Text = "Force Host [ON]";
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"party_connectToOthers 0;partyMigrate_disabled 1;sv_endGameIfISuck 0;badhost_endgameifisuck 0​;set allowAllNAT 1;set party_minplayers 1"
				});
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0003042C File Offset: 0x0002E62C
		private void simpleButton521_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"xstartparty"
			});
			this.ixboxConsole_0.XNotify("Searching For Match!\nThis May Take A While...");
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00030470 File Offset: 0x0002E670
		private void simpleButton522_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit14.SelectedIndex == 0)
			{
				DialogResult dialogResult = XtraMessageBox.Show("Are you sure you want to switch to Zombies?", "Warning", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					this.ixboxConsole_0.CallVoid(2185237984U, new object[]
					{
						0,
						"StartZombies"
					});
				}
				else if (dialogResult == DialogResult.No)
				{
				}
			}
			if (this.comboBoxEdit14.SelectedIndex == 1)
			{
				DialogResult dialogResult2 = XtraMessageBox.Show("Are you sure you want to switch to Campaign?", "Warning", MessageBoxButtons.YesNo);
				if (dialogResult2 == DialogResult.Yes)
				{
					this.ixboxConsole_0.CallVoid(2185237984U, new object[]
					{
						0,
						"StartSingleplayer"
					});
				}
				else if (dialogResult2 != DialogResult.No)
				{
				}
			}
			if (this.comboBoxEdit14.SelectedIndex == 2)
			{
				DialogResult dialogResult3 = XtraMessageBox.Show("Are you sure you want to switch to Multiplayer?", "Warning", MessageBoxButtons.YesNo);
				if (dialogResult3 != DialogResult.Yes)
				{
					if (dialogResult3 != DialogResult.No)
					{
					}
				}
				else
				{
					this.ixboxConsole_0.CallVoid(2185237984U, new object[]
					{
						0,
						"StartMultiplayer"
					});
				}
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00030588 File Offset: 0x0002E788
		private void method_59(string string_3)
		{
			this.ixboxConsole_0.SetMemory(2193972480U, new byte[]
			{
				124,
				131,
				35,
				120,
				61,
				96,
				130,
				197,
				56,
				139,
				93,
				96,
				61,
				96,
				130,
				74,
				57,
				107,
				220,
				160,
				56,
				160,
				0,
				32,
				125,
				105,
				3,
				166,
				78,
				128,
				4,
				32
			});
			this.ixboxConsole_0.SetMemory(2190726948U, new byte[]
			{
				61,
				96,
				130,
				197,
				57,
				107,
				93,
				0,
				125,
				105,
				3,
				166,
				78,
				128,
				4,
				32
			});
			this.ixboxConsole_0.SetMemory(2186917543U, new byte[1]);
			this.ixboxConsole_0.SetMemory(2183991568U, new byte[]
			{
				64
			});
			this.ixboxConsole_0.SetMemory(2193972576U, Encoding.UTF8.GetBytes(string_3 + "\0"));
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00030630 File Offset: 0x0002E830
		private void simpleButton535_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("To use callvote exploits you have to be in a lobby with only the victim, chosen exploit will be executed and you will leave the match after callvote.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00030650 File Offset: 0x0002E850
		private void simpleButton534_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit16.SelectedIndex == 0)
			{
				this.ixboxConsole_0.CallVoid(2183628512U, new object[]
				{
					0,
					"callvote map \"mp_hijacked\rresetstats\r\""
				});
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"disconnect"
				});
				this.ixboxConsole_0.XNotify("Successfully deranked user!");
			}
			if (this.comboBoxEdit16.SelectedIndex == 1)
			{
				this.ixboxConsole_0.CallVoid(2183628512U, new object[]
				{
					0,
					"callvote map \"mp_hijacked\rquit\r\""
				});
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"disconnect"
				});
				this.ixboxConsole_0.XNotify("Successfully sent user to dashboard!");
			}
			if (this.comboBoxEdit16.SelectedIndex == 2)
			{
				this.ixboxConsole_0.CallVoid(2183628512U, new object[]
				{
					0,
					"callvote map \"mp_hijacked\rstartZombies\r\""
				});
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"disconnect"
				});
				this.ixboxConsole_0.XNotify("Successfully sent user to zombies!");
			}
			if (this.comboBoxEdit16.SelectedIndex == 3)
			{
				this.ixboxConsole_0.CallVoid(2183628512U, new object[]
				{
					0,
					"callvote map \"mp_hijacked\rstartSingleplayer\r\""
				});
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"disconnect"
				});
				this.ixboxConsole_0.XNotify("Successfully sent user to campaign!");
			}
			if (this.comboBoxEdit16.SelectedIndex == 4)
			{
				this.ixboxConsole_0.CallVoid(2183628512U, new object[]
				{
					0,
					"callvote map \"mp_hijacked\rn遻g_fov 90\r\""
				});
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"disconnect"
				});
				this.ixboxConsole_0.XNotify("Successfully crashed user console!");
			}
			if (this.comboBoxEdit16.SelectedIndex == 5)
			{
				this.ixboxConsole_0.CallVoid(2183628512U, new object[]
				{
					0,
					"callvote map \"mp_hijacked\rsetStatFromLocString cacloadouts customclassname 0 ^H^H\0\r\""
				});
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"disconnect"
				});
				this.ixboxConsole_0.XNotify("Successfully froze user classes!");
			}
			if (this.comboBoxEdit16.SelectedIndex == 6)
			{
				this.ixboxConsole_0.CallVoid(2183628512U, new object[]
				{
					0,
					"callvote map \"mp_hijacked\rstatSetByName PLEVEL -1\r\""
				});
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"disconnect"
				});
				this.ixboxConsole_0.XNotify("Successfully temporary broke user account!");
			}
			if (this.comboBoxEdit16.SelectedIndex == 7)
			{
				this.ixboxConsole_0.CallVoid(2183628512U, new object[]
				{
					0,
					"callvote map \"mp_hijacked\rstatSetByName RANKXP 10000000\r\""
				});
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"disconnect"
				});
				this.ixboxConsole_0.XNotify("Successfully map looped user account!");
			}
			if (this.comboBoxEdit16.SelectedIndex == 8)
			{
				this.ixboxConsole_0.CallVoid(2183628512U, new object[]
				{
					0,
					"callvote map \"mp_hijacked\rxshowfriendslist\r\""
				});
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"disconnect"
				});
				this.ixboxConsole_0.XNotify("Successfully sent user to friends list!");
			}
			if (this.comboBoxEdit16.SelectedIndex == 9)
			{
				this.ixboxConsole_0.CallVoid(2183628512U, new object[]
				{
					0,
					"callvote map \"mp_hijacked\rxshowmarketplace\r\""
				});
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"disconnect"
				});
				this.ixboxConsole_0.XNotify("Successfully sent user to marketplace!");
			}
			if (this.comboBoxEdit16.SelectedIndex == 10)
			{
				this.ixboxConsole_0.CallVoid(2183628512U, new object[]
				{
					0,
					"callvote map \"mp_hijacked\rxsigninlocal\r\""
				});
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"disconnect"
				});
				this.ixboxConsole_0.XNotify("Successfully sent user to sign in screen!");
			}
			if (this.comboBoxEdit16.SelectedIndex == 11)
			{
				this.ixboxConsole_0.CallVoid(2183628512U, new object[]
				{
					0,
					"callvote map \"mp_hijacked\rsignclientout\r\""
				});
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"disconnect"
				});
				this.ixboxConsole_0.XNotify("Successfully signed user out!");
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00030B88 File Offset: 0x0002ED88
		private void simpleButton537_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				this.textEdit_90.Text
			});
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00030BC4 File Offset: 0x0002EDC4
		private void method_60(object sender, ElapsedEventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"cg_fov " + this.textEdit_89.Text
			});
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00030C08 File Offset: 0x0002EE08
		private void simpleButton538_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton538.Text = ((!this.TimerEnabled) ? "Loop FOV [OFF]" : "Loop FOV [ON]");
			Form1.timer17.Elapsed += this.method_60;
			Form1.timer17.AutoReset = true;
			Form1.timer17.Enabled = this.TimerEnabled;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00030C74 File Offset: 0x0002EE74
		private void simpleButton523_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton523.Text == "No Recoil [OFF]"))
			{
				this.simpleButton523.Text = "No Recoil [OFF]";
				this.ixboxConsole_0.SetMemory(2183502792U, new byte[]
				{
					72,
					70,
					19,
					65
				});
			}
			else
			{
				this.simpleButton523.Text = "No Recoil [ON]";
				IXboxConsole console = this.ixboxConsole_0;
				byte[] array = new byte[4];
				array[0] = 96;
				console.SetMemory(2183502792U, array);
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00030D00 File Offset: 0x0002EF00
		private void simpleButton525_Click(object sender, EventArgs e)
		{
			if (this.simpleButton525.Text == "ESP [OFF]")
			{
				this.simpleButton525.Text = "ESP [ON]";
				this.ixboxConsole_0.WriteByte(2183093119U, 1);
			}
			else
			{
				this.simpleButton525.Text = "ESP [OFF]";
				this.ixboxConsole_0.WriteByte(2183093119U, 0);
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00030D68 File Offset: 0x0002EF68
		private void simpleButton531_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton531.Text == "Spoof Mic [OFF]"))
			{
				this.simpleButton531.Text = "Spoof Mic [OFF]";
				this.ixboxConsole_0.WriteUInt32(2183713032U, 945815552U);
			}
			else
			{
				this.simpleButton531.Text = "Spoof Mic [ON]";
				this.ixboxConsole_0.WriteUInt32(2183713032U, 945815553U);
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00030DD8 File Offset: 0x0002EFD8
		private void simpleButton526_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton526.Text == "No Sway [OFF]"))
			{
				this.simpleButton526.Text = "No Sway [OFF]";
				this.ixboxConsole_0.SetMemory(2188144236U, new byte[]
				{
					75,
					byte.MaxValue,
					233,
					117
				});
			}
			else
			{
				this.simpleButton526.Text = "No Sway [ON]";
				IXboxConsole console = this.ixboxConsole_0;
				byte[] array = new byte[4];
				array[0] = 96;
				console.SetMemory(2188144236U, array);
			}
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00030E64 File Offset: 0x0002F064
		private void simpleButton524_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton524.Text == "UAV [OFF]"))
			{
				this.simpleButton524.Text = "UAV [OFF]";
				this.ixboxConsole_0.SetMemory(2182844371U, new byte[1]);
			}
			else
			{
				this.simpleButton524.Text = "UAV [ON]";
				this.ixboxConsole_0.SetMemory(2182844371U, new byte[]
				{
					1
				});
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00030EDC File Offset: 0x0002F0DC
		private void simpleButton529_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.XNotify("No Spread enabled, to disable relaunch Black Ops II!");
			this.ixboxConsole_0.WriteUInt32(2188097220U, 1610612736U);
			this.ixboxConsole_0.WriteUInt32(2181041612U, 962592768U);
			this.ixboxConsole_0.WriteUInt32(2188097220U, 962592768U);
			this.ixboxConsole_0.WriteUInt32(2188096780U, 962592770U);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00030F50 File Offset: 0x0002F150
		private void simpleButton530_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.XNotify("Unlimited class items is enabled!");
			byte[] data = new byte[]
			{
				59,
				85,
				85,
				85
			};
			this.ixboxConsole_0.SetMemory(2188009404U, data);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00030F94 File Offset: 0x0002F194
		private void simpleButton532_Click(object sender, EventArgs e)
		{
			if (this.simpleButton532.Text == "Wallhack [OFF]")
			{
				this.simpleButton532.Text = "Wallhack [ON]";
				this.ixboxConsole_0.SetMemory(2183118924U, new byte[]
				{
					56,
					192,
					byte.MaxValue,
					byte.MaxValue
				});
			}
			else
			{
				this.simpleButton532.Text = "Wallhack [OFF]";
				this.ixboxConsole_0.SetMemory(2183118924U, new byte[]
				{
					127,
					166,
					235,
					120
				});
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0003101C File Offset: 0x0002F21C
		private void simpleButton527_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton527.Text == "Laser [OFF]"))
			{
				this.simpleButton527.Text = "Laser [OFF]";
				IXboxConsole console = this.ixboxConsole_0;
				byte[] array = new byte[4];
				array[0] = 43;
				array[1] = 11;
				console.SetMemory(2183487004U, array);
			}
			else
			{
				this.simpleButton527.Text = "Laser [ON]";
				this.ixboxConsole_0.SetMemory(2183487004U, new byte[]
				{
					43,
					11,
					0,
					1
				});
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000310B0 File Offset: 0x0002F2B0
		private void simpleButton528_Click(object sender, EventArgs e)
		{
			if (this.simpleButton528.Text == "Show Host [OFF]")
			{
				this.simpleButton528.Text = "Show Host [ON]";
				byte[] array = new byte[4];
				array[0] = 18;
				this.ixboxConsole_0.SetMemory(2181054320U, array);
				this.ixboxConsole_0.WriteBool(2210767803U, true);
			}
			else
			{
				this.simpleButton528.Text = "Show Host [OFF]";
				byte[] array2 = new byte[4];
				array2[0] = 18;
				this.ixboxConsole_0.SetMemory(2181054320U, array2);
				this.ixboxConsole_0.WriteBool(2210767803U, false);
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00031158 File Offset: 0x0002F358
		private void simpleButton536_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183628512U, new object[]
			{
				0,
				"userinfo \"\\name\\^6GCT\\clanabbrev\\^1\\xuid\\1E0200F003F252F7\\invited\\1\""
			});
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0003118C File Offset: 0x0002F38C
		private void simpleButton346_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"set cg_fov 90"
			});
			this.textEdit_90.Text = "set cg_fov 90";
			this.simpleButton523.Text = "No Recoil [ON]";
			IXboxConsole console = this.ixboxConsole_0;
			byte[] array = new byte[4];
			array[0] = 96;
			console.SetMemory(2183502792U, array);
			this.simpleButton524.Text = "UAV [ON]";
			this.ixboxConsole_0.SetMemory(2182844371U, new byte[]
			{
				1
			});
			this.simpleButton525.Text = "ESP [ON]";
			this.ixboxConsole_0.WriteByte(2183093119U, 1);
			this.simpleButton526.Text = "No Sway [ON]";
			IXboxConsole console2 = this.ixboxConsole_0;
			byte[] array2 = new byte[4];
			array2[0] = 96;
			console2.SetMemory(2188144236U, array2);
			this.simpleButton527.Text = "Laser [ON]";
			this.ixboxConsole_0.SetMemory(2183487004U, new byte[]
			{
				43,
				11,
				0,
				1
			});
			this.simpleButton528.Text = "Show Host [ON]";
			byte[] array3 = new byte[4];
			array3[0] = 18;
			this.ixboxConsole_0.SetMemory(2181054320U, array3);
			this.ixboxConsole_0.WriteBool(2210767803U, true);
			this.ixboxConsole_0.WriteUInt32(2188097220U, 1610612736U);
			this.ixboxConsole_0.WriteUInt32(2181041612U, 962592768U);
			this.ixboxConsole_0.WriteUInt32(2188097220U, 962592768U);
			this.ixboxConsole_0.WriteUInt32(2188096780U, 962592770U);
			byte[] data = new byte[]
			{
				59,
				85,
				85,
				85
			};
			this.ixboxConsole_0.SetMemory(2188009404U, data);
			this.ixboxConsole_0.XNotify("All Offhost Cheats set!");
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00031380 File Offset: 0x0002F580
		private void simpleButton560_Click(object sender, EventArgs e)
		{
			if (this.simpleButton560.Text == "Force Host [OFF]")
			{
				this.simpleButton560.Text = "Force Host [ON]";
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"party_connectToOthers 00; partyMigrate_disabled 01; sv_endGameIfISuck 0; badhost_endgameifisuck 0​; set allowAllNAT 1"
				});
			}
			else
			{
				this.simpleButton560.Text = "Force Host [OFF]";
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"party_connectToOthers 01; partyMigrate_disabled 00"
				});
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00031414 File Offset: 0x0002F614
		private void simpleButton564_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"wait 320; fast_restart"
			});
			this.ixboxConsole_0.XNotify("Restarting Game!");
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00031458 File Offset: 0x0002F658
		private void simpleButton568_Click(object sender, EventArgs e)
		{
			if (this.simpleButton568.Text == "Godmode [OFF]")
			{
				this.simpleButton568.Text = "Godmode [ON]";
				for (int i = 0; i < 4; i++)
				{
					this.ixboxConsole_0.SetMemory((uint)(i * 22520 - 2091574768 + 27), new byte[]
					{
						5
					});
				}
			}
			else
			{
				this.simpleButton568.Text = "Godmode [OFF]";
				for (int j = 0; j < 4; j++)
				{
					this.ixboxConsole_0.SetMemory((uint)(j * 22520 - 2091574768 + 27), new byte[]
					{
						4
					});
				}
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00031510 File Offset: 0x0002F710
		private void simpleButton561_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"xpartygo"
			});
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00031544 File Offset: 0x0002F744
		private void simpleButton565_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"set party_maxplayers 8;set party_minplayers 6"
			});
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00031578 File Offset: 0x0002F778
		private void simpleButton569_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"perk_weapReloadMultiplier 0.01"
			});
			this.ixboxConsole_0.XNotify("Instant Reload Given! Requires Speed Cola perk.");
		}

		// Token: 0x0600032F RID: 815 RVA: 0x000301FC File Offset: 0x0002E3FC
		private void simpleButton562_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"disconnect"
			});
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000315BC File Offset: 0x0002F7BC
		private void simpleButton566_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton566.Text == "Super Speed [OFF]"))
			{
				this.simpleButton566.Text = "Super Speed [OFF]";
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"seta g_speed 165"
				});
			}
			else
			{
				this.simpleButton566.Text = "Super Speed [ON]";
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"seta g_speed 650"
				});
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00031650 File Offset: 0x0002F850
		private void simpleButton563_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"cmd mr " + this.ixboxConsole_0.ReadInt32(2193708888U).ToString() + " -1 endround"
			});
		}

		// Token: 0x06000332 RID: 818 RVA: 0x000316A8 File Offset: 0x0002F8A8
		private void simpleButton567_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton567.Text == "Unlimited Ammo [OFF]"))
			{
				this.simpleButton567.Text = "Unlimited Ammo [OFF]";
				byte[] array = new byte[4];
				array[0] = 144;
				array[0] = 227;
				this.ixboxConsole_0.SetMemory(2188109596U, array);
			}
			else
			{
				this.simpleButton567.Text = "Unlimited Ammo [ON]";
				byte[] array2 = new byte[4];
				array2[0] = 96;
				this.ixboxConsole_0.SetMemory(2188109596U, array2);
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0003173C File Offset: 0x0002F93C
		private void simpleButton570_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185427824U, new object[]
			{
				-1,
				0,
				this.textEdit_96.Text
			});
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00030EDC File Offset: 0x0002F0DC
		private void simpleButton572_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.XNotify("No Spread enabled, to disable relaunch Black Ops II!");
			this.ixboxConsole_0.WriteUInt32(2188097220U, 1610612736U);
			this.ixboxConsole_0.WriteUInt32(2181041612U, 962592768U);
			this.ixboxConsole_0.WriteUInt32(2188097220U, 962592768U);
			this.ixboxConsole_0.WriteUInt32(2188096780U, 962592770U);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00031780 File Offset: 0x0002F980
		private void simpleButton571_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton571.Text == "No Recoil [OFF]"))
			{
				this.simpleButton571.Text = "No Recoil [OFF]";
				this.ixboxConsole_0.SetMemory(2183502792U, new byte[]
				{
					72,
					70,
					19,
					65
				});
			}
			else
			{
				this.simpleButton571.Text = "No Recoil [ON]";
				IXboxConsole console = this.ixboxConsole_0;
				byte[] array = new byte[4];
				array[0] = 96;
				console.SetMemory(2183502792U, array);
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0003180C File Offset: 0x0002FA0C
		private void simpleButton573_Click(object sender, EventArgs e)
		{
			if (this.simpleButton573.Text == "Laser [OFF]")
			{
				this.simpleButton573.Text = "Laser [ON]";
				this.ixboxConsole_0.SetMemory(2183487004U, new byte[]
				{
					43,
					11,
					0,
					1
				});
			}
			else
			{
				this.simpleButton573.Text = "Laser [OFF]";
				IXboxConsole console = this.ixboxConsole_0;
				byte[] array = new byte[4];
				array[0] = 43;
				array[1] = 11;
				console.SetMemory(2183487004U, array);
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x000318A0 File Offset: 0x0002FAA0
		private void simpleButton574_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				this.textEdit_95.Text
			});
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000318DC File Offset: 0x0002FADC
		private void method_61(string string_3, string string_4)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				string.Concat(new string[]
				{
					"statSetByName ",
					string_3,
					" ",
					string_4,
					";updategamerprofile;uploadstats"
				})
			});
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00031938 File Offset: 0x0002FB38
		private void simpleButton585_Click(object sender, EventArgs e)
		{
			this.method_61("KILLS", this.numericUpDown101.Text);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0003195C File Offset: 0x0002FB5C
		private void simpleButton580_Click(object sender, EventArgs e)
		{
			this.method_61("DEATHS", this.numericUpDown96.Text);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00031980 File Offset: 0x0002FB80
		private void simpleButton586_Click(object sender, EventArgs e)
		{
			this.method_61("DOWNS", this.numericUpDown102.Text);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000319A4 File Offset: 0x0002FBA4
		private void simpleButton581_Click(object sender, EventArgs e)
		{
			this.method_61("REVIVES", this.numericUpDown97.Text);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x000319C8 File Offset: 0x0002FBC8
		private void simpleButton577_Click(object sender, EventArgs e)
		{
			this.method_61("HITS", this.numericUpDown94.Text);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x000319EC File Offset: 0x0002FBEC
		private void simpleButton584_Click(object sender, EventArgs e)
		{
			this.method_61("GRENADE_KILLS", this.numericUpDown100.Text);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00031A10 File Offset: 0x0002FC10
		private void simpleButton582_Click(object sender, EventArgs e)
		{
			this.method_61("PERKS_DRANK", this.numericUpDown98.Text);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00031A34 File Offset: 0x0002FC34
		private void simpleButton587_Click(object sender, EventArgs e)
		{
			this.method_61("GIBS", this.numericUpDown95.Text);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00031A58 File Offset: 0x0002FC58
		private void simpleButton583_Click(object sender, EventArgs e)
		{
			this.method_61("HEADSHOTS", this.numericUpDown99.Text);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00031A7C File Offset: 0x0002FC7C
		private void simpleButton578_Click(object sender, EventArgs e)
		{
			this.method_61("KILLS", this.numericUpDown101.Text);
			this.method_61("DEATHS", this.numericUpDown96.Text);
			this.method_61("DOWNS", this.numericUpDown102.Text);
			this.method_61("REVIVES", this.numericUpDown97.Text);
			this.method_61("HITS", this.numericUpDown94.Text);
			this.method_61("GIBS", this.numericUpDown95.Text);
			this.method_61("HEADSHOTS", this.numericUpDown99.Text);
			this.method_61("GRENADE_KILLS", this.numericUpDown100.Text);
			this.method_61("PERKS_DRANK", this.numericUpDown98.Text);
			this.ixboxConsole_0.XNotify("All Stats Set");
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0002E820 File Offset: 0x0002CA20
		private void simpleButton576_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"resetstats;updategamerprofile;uploadstats"
			});
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00031B60 File Offset: 0x0002FD60
		private void simpleButton575_Click(object sender, EventArgs e)
		{
			this.numericUpDown101.Text = "10000";
			this.numericUpDown96.Text = "500";
			this.numericUpDown102.Text = "800";
			this.numericUpDown97.Text = "1500";
			this.numericUpDown94.Text = "2500";
			this.numericUpDown95.Text = "1500";
			this.numericUpDown99.Text = "2500";
			this.numericUpDown100.Text = "500";
			this.numericUpDown98.Text = "750";
			this.simpleButton578_Click(sender, null);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00031C08 File Offset: 0x0002FE08
		public static byte[] Reverse(byte[] sArray)
		{
			for (int i = 0; i < sArray.Length / 2; i++)
			{
				byte b = sArray[i];
				sArray[i] = sArray[sArray.Length - 1 - i];
				sArray[sArray.Length - 1 - i] = b;
			}
			return sArray;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00031C50 File Offset: 0x0002FE50
		private void simpleButton594_Click(object sender, EventArgs e)
		{
			this.listBox6.Items.Clear();
			this.dataGridView1.Rows.Clear();
			for (int i = 0; i < 18; i++)
			{
				string text = Encoding.ASCII.GetString(this.ixboxConsole_0.GetMemory((uint)(-1006386264 + 328 * i), 15U)).TrimEnd(new char[1]);
				string text2 = new IPAddress(this.ixboxConsole_0.GetMemory((uint)(-1006386148 + 328 * i), 4U)).ToString();
				string text3 = int.Parse(BitConverter.ToString(this.ixboxConsole_0.GetMemory((uint)(-1006386145 + 328 * i), 2U)).Replace("-", ""), NumberStyles.HexNumber).ToString();
				string text4 = BitConverter.ToString(this.ixboxConsole_0.GetMemory((uint)(-1006386272 + 328 * i), 8U)).Replace("-", "");
				string text5 = new IPAddress(this.ixboxConsole_0.GetMemory((uint)(-1006386152 + 328 * i), 4U)).ToString();
				string text6 = BitConverter.ToString(this.ixboxConsole_0.GetMemory((uint)(-1006386142 + 328 * i), 6U)).Replace("-", "");
				string text7 = BitConverter.ToString(Form1.Reverse(this.ixboxConsole_0.GetMemory((uint)(3288581168L + 328L * (long)i), 8U))).Replace("-", null);
				string text8 = "False";
				if (!(text == ""))
				{
					uint address = this.ixboxConsole_0.ReadUInt32(2210837880U);
					string text9 = this.ixboxConsole_0.ReadString(address, 4095U);
					if (text9.Contains(text))
					{
						text += " (HOST)";
					}
					string text10;
					if (!text7.Contains("FA0000000"))
					{
						text10 = "Xbox One";
					}
					else
					{
						text10 = "Xbox 360";
					}
					if (text6.StartsWith("0022"))
					{
						text8 = "True";
					}
					DataGridViewRowCollection rows = this.dataGridView1.Rows;
					rows.Add(new object[]
					{
						text,
						text4,
						text2,
						text3,
						text5,
						text10,
						text8,
						text6
					});
					this.dataGridView1.ForeColor = System.Drawing.Color.Black;
					this.listBox6.Items.Add(text.Replace(" (HOST)", "") + " : " + text2);
					if (this.simpleButton596.Text == "IP Logging [ON]")
					{
						File.AppendAllText("IPLog.txt", string.Concat(new string[]
						{
							DateTime.Now.ToString(),
							" || ",
							text,
							" = ",
							text2,
							" || Port : ",
							text3,
							" || XUID : ",
							text4,
							Environment.NewLine
						}));
					}
				}
			}
			if (this.simpleButton596.Text == "IP Logging [ON]")
			{
				File.AppendAllText("IPLog.txt", Environment.NewLine);
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00031FAC File Offset: 0x000301AC
		private void simpleButton595_Click(object sender, EventArgs e)
		{
			this.dataGridView1.Rows.Clear();
			this.listBox6.Items.Clear();
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00031FDC File Offset: 0x000301DC
		private void simpleButton596_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton596.Text == "IP Logging [OFF]"))
			{
				this.simpleButton596.Text = "IP Logging [OFF]";
			}
			else
			{
				this.simpleButton596.Text = "IP Logging [ON]";
				XtraMessageBox.Show("Gamertags with their corresponding ip addresses, ports and xuids will now be written to IPLog.txt in your tool directory every time you pull lobby info.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00032038 File Offset: 0x00030238
		private void simpleButton597_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.listBox6.SelectedItem.ToString());
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0003205C File Offset: 0x0003025C
		private void simpleButton598_Click(object sender, EventArgs e)
		{
			if (!(this.listBox6.SelectedItem.ToString() == ""))
			{
				string text = this.listBox6.SelectedItem.ToString().Split(new char[]
				{
					" ".Last<char>()
				}).First<string>();
				string text2 = this.listBox6.SelectedItem.ToString().Split(new char[]
				{
					text.Last<char>()
				}).Last<string>();
				string text3 = text2.Split(new char[]
				{
					" : ".Last<char>()
				}).Last<string>();
				this.ixboxConsole_0.CallVoid(2183628512U, new object[]
				{
					0,
					string.Concat(new string[]
					{
						"userinfo \"\\name\\",
						text,
						" = ",
						text3,
						"\\xuid\\"
					})
				});
				this.method_59(text + " = " + text3);
				this.textEdit_72.Text = text + " = " + text3;
				this.textEdit_70.Text = text + " = " + text3;
			}
			else
			{
				XtraMessageBox.Show("No Client Selected", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000321B0 File Offset: 0x000303B0
		private void simpleButton599_Click(object sender, EventArgs e)
		{
			this.textEdit_98.Text = this.dataGridView1.CurrentCell.Value.ToString();
			this.simpleButton588_Click(sender, null);
		}

        // Token: 0x0600034C RID: 844 RVA: 0x000321E8 File Offset: 0x000303E8
        public static byte[] hexString(string HexString)
        {
            int length = HexString.Length;
            byte[] array = new byte[length / 2];
            for (int i = 0; i < length; i += 2)
            {
                array[i / 2] = Convert.ToByte(HexString.Substring(i, 2), 16);
            }
            return array;
        }

        // Token: 0x0600034D RID: 845 RVA: 0x00032258 File Offset: 0x00030458
        public static string ConvertStringToHex(string asciiString)
		{
			string text = "";
			foreach (int num in asciiString)
			{
				if (num == 0)
				{
					return text;
				}
				text += string.Format("{0:x2}", Convert.ToUInt32(num.ToString()));
			}
			return text;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000322C8 File Offset: 0x000304C8
		public static byte[] reverseBytes(string gamertag)
		{
			byte[] array = new byte[gamertag.Length * 2 + 2];
			array[0] = 0;
			uint num = 1U;
			for (int i = 0; i < gamertag.Length; i++)
			{
				array[(int)num] = (byte)gamertag[i];
				uint num2 = num + 1U;
				array[(int)num2] = 0;
				num = num2 + 1U;
			}
			array[(int)num] = 0;
			return array;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00032334 File Offset: 0x00030534
		private void simpleButton588_Click(object sender, EventArgs e)
		{
			string text = this.method_73(this.textEdit_98.Text);
			this.ixboxConsole_0.SetMemory(2216565552U, Encoding.UTF8.GetBytes(this.textEdit_98.Text + "\0"));
			this.ixboxConsole_0.SetMemory(2216565584U, Form1.hexString(text));
			this.ixboxConsole_0.SetMemory(2216565596U, Form1.hexString(Form1.ConvertStringToHex(text)));
			this.ixboxConsole_0.SetMemory(2216565552U, new byte[]
			{
				32
			});
			this.ixboxConsole_0.SetMemory(2216565552U, Encoding.ASCII.GetBytes(this.textEdit_98.Text));
			this.ixboxConsole_0.SetMemory(2175412476U, Form1.reverseBytes(this.textEdit_98.Text));
			this.textEdit_97.Text = text;
			this.ixboxConsole_0.XNotify("Successfully spoofed to : " + this.textEdit_98.Text);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00032444 File Offset: 0x00030644
		private void method_62(object sender, ElapsedEventArgs e)
		{
			this.ixboxConsole_0.WriteByte(3241246944U, this.IPAddressBytes(this.textEdit_117.Text));
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00032474 File Offset: 0x00030674
		public byte[] IPAddressBytes(string ip)
		{
			int num = 0;
			string value = "0";
			string value2 = "0";
			string value3 = "0";
			string value4 = "0";
			foreach (string text in this.textEdit_117.Text.Split(new char[]
			{
				'.'
			}).ToArray<string>())
			{
				switch (num)
				{
				case 0:
					value = text;
					break;
				case 1:
					value2 = text;
					break;
				case 2:
					value3 = text;
					break;
				case 3:
					value4 = text;
					break;
				}
				num++;
			}
			return new byte[]
			{
				Convert.ToByte(value),
				Convert.ToByte(value2),
				Convert.ToByte(value3),
				Convert.ToByte(value4)
			};
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0003254C File Offset: 0x0003074C
		private void simpleButton616_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton616.Text = ((!this.TimerEnabled) ? "Spoof IP Address [OFF]" : "Spoof IP Address [ON]");
			Form1.timer16.Elapsed += this.method_62;
			Form1.timer16.AutoReset = true;
			Form1.timer16.Enabled = this.TimerEnabled;
			if (this.simpleButton616.Text == "Spoof IP Address [OFF]")
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://ipv4.icanhazip.com/");
				this.textEdit_117.Text = text;
				this.simpleButton616.Text = "Spoof IP Address [OFF]";
				this.ixboxConsole_0.WriteByte(3241246944U, this.IPAddressBytes(this.textEdit_117.Text));
				this.textEdit_117.Text = "";
				this.ixboxConsole_0.XNotify("Successfully Disabled IP Address Spoof");
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00032644 File Offset: 0x00030844
		private void simpleButton606_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2792842450U, Encoding.ASCII.GetBytes(this.textEdit_116.Text + "\0"));
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00032680 File Offset: 0x00030880
		private void simpleButton607_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2793000498U, Encoding.ASCII.GetBytes(this.textEdit_112.Text + "\0"));
		}

		// Token: 0x06000355 RID: 853 RVA: 0x000326BC File Offset: 0x000308BC
		private void simpleButton604_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2793175320U, Encoding.ASCII.GetBytes(this.textEdit_113.Text + "\0"));
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000326F8 File Offset: 0x000308F8
		private void simpleButton605_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2793066770U, Encoding.ASCII.GetBytes(this.textEdit_115.Text + "\0"));
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00032734 File Offset: 0x00030934
		private void simpleButton603_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2793024692U, Encoding.ASCII.GetBytes(this.textEdit_114.Text + "\0"));
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00032770 File Offset: 0x00030970
		private void simpleButton601_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2793014864U, Encoding.ASCII.GetBytes(this.textEdit_110.Text + "\0"));
		}

		// Token: 0x06000359 RID: 857 RVA: 0x000327AC File Offset: 0x000309AC
		private void simpleButton602_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2793140019U, Encoding.ASCII.GetBytes(this.textEdit_111.Text + "\0"));
		}

		// Token: 0x0600035A RID: 858 RVA: 0x000327E8 File Offset: 0x000309E8
		private void simpleButton600_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2793202160U, Encoding.ASCII.GetBytes(this.textEdit_109.Text + "\0"));
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00032824 File Offset: 0x00030A24
		private void simpleButton610_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2792817654U, Encoding.ASCII.GetBytes(this.textEdit_108.Text + "\0"));
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00032860 File Offset: 0x00030A60
		private void simpleButton611_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2793055438U, Encoding.ASCII.GetBytes(this.textEdit_105.Text + "\0"));
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0003289C File Offset: 0x00030A9C
		private void simpleButton608_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2792955692U, Encoding.ASCII.GetBytes(this.textEdit_106.Text + "\0"));
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000077B0 File Offset: 0x000059B0
		private void xtraTabPage48_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600035F RID: 863 RVA: 0x000328D8 File Offset: 0x00030AD8
		private void simpleButton609_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2792956305U, Encoding.ASCII.GetBytes(this.textEdit_107.Text + "\0"));
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00032914 File Offset: 0x00030B14
		private void simpleButton614_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2793181806U, Encoding.ASCII.GetBytes(this.textEdit_104.Text + "\0"));
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00032950 File Offset: 0x00030B50
		private void simpleButton615_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2792853398U, Encoding.ASCII.GetBytes(this.textEdit_101.Text + "\0"));
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0003298C File Offset: 0x00030B8C
		private void simpleButton612_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2793002652U, Encoding.ASCII.GetBytes(this.textEdit_102.Text + "\0"));
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000329C8 File Offset: 0x00030BC8
		private void simpleButton613_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2792995775U, Encoding.ASCII.GetBytes(this.textEdit_103.Text + "\0"));
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00032A04 File Offset: 0x00030C04
		private void simpleButton414_Click(object sender, EventArgs e)
		{
			this.method_59(this.textEdit_72.Text);
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				";statwriteddl clantagstats clanname " + this.textEdit_71.Text + ";"
			});
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00032A60 File Offset: 0x00030C60
		private void simpleButton411_Click(object sender, EventArgs e)
		{
			this.method_59(Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "");
			this.textEdit_72.Text = (Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "");
			this.textEdit_71.Text = "\"\"";
			this.simpleButton414_Click(sender, null);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00032B00 File Offset: 0x00030D00
		private void simpleButton413_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183628512U, new object[]
			{
				0,
				string.Concat(new string[]
				{
					"userinfo \"\\clanabbrev\\",
					this.textEdit_69.Text,
					"\\name\\",
					this.textEdit_70.Text,
					"\\xuid\\"
				})
			});
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00032B70 File Offset: 0x00030D70
		private void simpleButton412_Click(object sender, EventArgs e)
		{
			this.textEdit_70.Text = (Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "");
			this.textEdit_69.Text = "";
			this.ixboxConsole_0.CallVoid(2183628512U, new object[]
			{
				0,
				string.Concat(new string[]
				{
					"userinfo \"\\clanabbrev\\",
					this.textEdit_69.Text,
					"\\name\\",
					this.textEdit_70.Text,
					"\\xuid\\"
				})
			});
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00032C30 File Offset: 0x00030E30
		private void method_63(object sender, ElapsedEventArgs e)
		{
			this.method_59(this.textEdit_72.Text);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00032C50 File Offset: 0x00030E50
		private void method_64(object sender, ElapsedEventArgs e)
		{
			this.SetGamertag_BO1(this.textEdit_152.Text);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00032C70 File Offset: 0x00030E70
		private void checkEdit_0_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkEdit_0.Checked)
			{
				Form1.rtetimerbo2.Elapsed += this.method_63;
				Form1.rtetimerbo2.AutoReset = true;
				Form1.rtetimerbo2.Enabled = true;
			}
			else
			{
				Form1.rtetimerbo2.Enabled = false;
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00032CC4 File Offset: 0x00030EC4
		private void method_65(object sender, ElapsedEventArgs e)
		{
			string string_ = Form1.RandomShitGamertag(32);
			this.method_59(string_);
			Thread.Sleep(20);
			if (!this.checkEdit9.Checked)
			{
				this.method_59(this.textEdit_72.Text);
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00032D0C File Offset: 0x00030F0C
		private void method_66(object sender, ElapsedEventArgs e)
		{
			string string_ = Form1.RandomShitGamertag(32);
			this.SetGamertag_BO1(string_);
			Thread.Sleep(20);
			if (!this.checkEdit_2.Checked)
			{
				this.SetGamertag_BO1(this.textEdit_152.Text);
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00032D54 File Offset: 0x00030F54
		private void checkEdit9_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.checkEdit9.Checked)
			{
				Form1.randomgtbo2timer.Enabled = false;
			}
			else
			{
				Form1.randomgtbo2timer.Elapsed += this.method_65;
				Form1.randomgtbo2timer.AutoReset = true;
				Form1.randomgtbo2timer.Enabled = true;
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00032DA8 File Offset: 0x00030FA8
		private void method_67(object sender, ElapsedEventArgs e)
		{
			this.method_59("");
			Thread.Sleep(125);
			this.method_59(this.textEdit_72.Text);
			if (!this.checkEdit8.Checked)
			{
				this.method_59(this.textEdit_72.Text);
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00032DFC File Offset: 0x00030FFC
		private void method_68(object sender, ElapsedEventArgs e)
		{
			this.SetGamertag_BO1("");
			Thread.Sleep(125);
			this.SetGamertag_BO1(this.textEdit_152.Text);
			if (!this.checkEdit_1.Checked)
			{
				this.SetGamertag_BO1(this.textEdit_152.Text);
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00032E50 File Offset: 0x00031050
		private void checkEdit8_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkEdit8.Checked)
			{
				Form1.flashtimerbo2.Elapsed += this.method_67;
				Form1.flashtimerbo2.AutoReset = true;
				Form1.flashtimerbo2.Enabled = true;
			}
			else
			{
				Form1.flashtimerbo2.Enabled = false;
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00032EA4 File Offset: 0x000310A4
		private void method_69(object sender, ElapsedEventArgs e)
		{
			int num = new Random().Next(1, 9);
			if (Form1.rainbowgt("^" + num.ToString() + this.textEdit_72.Text) < 31)
			{
				this.method_59("^" + num.ToString() + this.textEdit_72.Text);
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00032F10 File Offset: 0x00031110
		private void method_70(object sender, ElapsedEventArgs e)
		{
			int num = new Random().Next(1, 9);
			if (Form1.rainbowgt("^" + num.ToString() + this.textEdit_152.Text) < 31)
			{
				this.SetGamertag_BO1("^" + num.ToString() + this.textEdit_152.Text);
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00032F7C File Offset: 0x0003117C
		private void simpleButton514_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton514.Text = (this.TimerEnabled ? "Rainbow GT Pregame [ON]" : "Rainbow GT Pregame [OFF]");
			Form1.rainbowgtpregametimer.Elapsed += this.method_69;
			Form1.rainbowgtpregametimer.AutoReset = true;
			Form1.rainbowgtpregametimer.Enabled = this.TimerEnabled;
			if (this.simpleButton514.Text == "Rainbow GT Pregame [OFF]")
			{
				this.method_59(this.textEdit_72.Text);
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00033010 File Offset: 0x00031210
		private void method_71(object sender, ElapsedEventArgs e)
		{
			int num = new Random().Next(1, 9);
			if (Form1.rainbowgt("^" + num.ToString() + this.textEdit_70.Text) < 31)
			{
				object[] array = new object[2];
				array[0] = 0;
				object[] array2 = array;
				array2[1] = string.Concat(new string[]
				{
					"userinfo \"\\clanabbrev\\",
					"^" + num.ToString(),
					"\\name\\",
					this.textEdit_70.Text,
					"\\invited\\1\""
				});
				this.ixboxConsole_0.CallVoid(2183628512U, array2);
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x000330C8 File Offset: 0x000312C8
		private void method_72(object sender, ElapsedEventArgs e)
		{
			int num = new Random().Next(1, 9);
			if (Form1.rainbowgt("^" + num.ToString() + this.textEdit_39.Text) < 31)
			{
				this.ixboxConsole_0.CallVoid(2184440024U, new object[]
				{
					0,
					string.Concat(new string[]
					{
						"userinfo \"\\clanabbrev\\^",
						num.ToString(),
						"\\name\\",
						this.textEdit_39.Text,
						"\\xuid\\"
					})
				});
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00033170 File Offset: 0x00031370
		private void simpleButton513_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton513.Text = (this.TimerEnabled ? "Rainbow GT Ingame [ON]" : "Rainbow GT Ingame [OFF]");
			Form1.rainbowgtingametimer.Elapsed += this.method_71;
			Form1.rainbowgtingametimer.AutoReset = true;
			Form1.rainbowgtingametimer.Enabled = this.TimerEnabled;
			if (this.simpleButton513.Text == "Rainbow GT Ingame [OFF]")
			{
				object[] array = new object[2];
				array[0] = 0;
				object[] array2 = array;
				array2[1] = string.Concat(new string[]
				{
					"userinfo \"\\clanabbrev\\",
					"",
					"\\name\\",
					this.textEdit_70.Text,
					"\\invited\\1\""
				});
				this.ixboxConsole_0.CallVoid(2183628512U, array2);
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00033254 File Offset: 0x00031454
		private string method_73(string string_3)
		{
			byte[] data = new byte[8];
			this.ixboxConsole_0.SetMemory(2175409456U, data);
			this.ixboxConsole_0.CallVoid(2172820832U, new object[]
			{
				2533274907391075L,
				0,
				string_3,
				24,
				2175409456U,
				0
			});
			Thread.Sleep(1000);
			string result = BitConverter.ToString(this.ixboxConsole_0.GetMemory(2175409456U, 8U)).Replace("-", "");
			this.ixboxConsole_0.SetMemory(2175409456U, data);
			return result;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00033318 File Offset: 0x00031518
		private void simpleButton579_Click(object sender, EventArgs e)
		{
			string text = this.method_73(this.textEdit_100.Text);
			Thread.Sleep(200);
			this.textEdit_99.Text = text;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00033350 File Offset: 0x00031550
		private void simpleButton593_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("Only works if enabled before joining the lobby, or in case of Search and Destroy it will work next round.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00033370 File Offset: 0x00031570
		private void simpleButton589_Click(object sender, EventArgs e)
		{
			this.textEdit_98.Text = "J1GY";
			this.simpleButton588_Click(sender, null);
			this.textEdit_98.Text = "";
			this.textEdit_97.Text = "";
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000333B8 File Offset: 0x000315B8
		private void simpleButton590_Click(object sender, EventArgs e)
		{
			this.textEdit_98.Text = "xLukzy";
			this.simpleButton588_Click(sender, null);
			this.textEdit_98.Text = "";
			this.textEdit_97.Text = "";
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00033400 File Offset: 0x00031600
		private void simpleButton591_Click(object sender, EventArgs e)
		{
			this.textEdit_98.Text = "Bossam";
			this.simpleButton588_Click(sender, null);
			this.textEdit_98.Text = "";
			this.textEdit_97.Text = "";
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00033448 File Offset: 0x00031648
		private void simpleButton592_Click(object sender, EventArgs e)
		{
			this.textEdit_98.Text = "MatrixNotMods";
			this.simpleButton588_Click(sender, null);
			this.textEdit_98.Text = "";
			this.textEdit_97.Text = "";
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00033490 File Offset: 0x00031690
		private void method_74(object sender, ElapsedEventArgs e)
		{
			Random random = new Random();
			char[] array = this.textEdit_72.Text.ToCharArray();
			this.method_59(string.Concat(new string[]
			{
				"^",
				random.Next(1, 9).ToString(),
				array[0].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[1].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[2].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[3].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[4].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[5].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[6].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[7].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[8].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[9].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[10].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[11].ToString()
			}));
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00033710 File Offset: 0x00031910
		private void method_75(object sender, ElapsedEventArgs e)
		{
			Random random = new Random();
			char[] array = this.textEdit_152.Text.ToCharArray();
			this.SetGamertag_BO1(string.Concat(new string[]
			{
				"^",
				random.Next(1, 9).ToString(),
				array[0].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[1].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[2].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[3].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[4].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[5].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[6].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[7].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[8].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[9].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[10].ToString(),
				"^",
				random.Next(1, 9).ToString(),
				array[11].ToString()
			}));
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00033990 File Offset: 0x00031B90
		private void checkEdit5_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.checkEdit5.Checked)
			{
				Form1.coloredgtbo2timer.Enabled = false;
				this.simpleButton411_Click(sender, null);
				this.method_59(this.textEdit_72.Text);
			}
			else if (this.textEdit_72.Text.Length > 12)
			{
				this.checkEdit5.Checked = false;
				XtraMessageBox.Show("Gamertag can't be longer than 12 chars.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				Form1.coloredgtbo2timer.Enabled = true;
				Form1.coloredgtbo2timer.AutoReset = true;
				Form1.coloredgtbo2timer.Elapsed += this.method_74;
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00033A34 File Offset: 0x00031C34
		private void simpleButton185_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183628512U, new object[]
			{
				0,
				"userinfo \"\\clanabbrev\\{+}\\name\\[{+}][{+}][{+}][{+}][{+}][{+}][[S]\\xuid\\"
			});
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00033A68 File Offset: 0x00031C68
		public void NopIt(uint address)
		{
			byte[] array = new byte[4];
			array[0] = 96;
			this.ixboxConsole_0.SetMemory(address, array);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00033A94 File Offset: 0x00031C94
		private void method_76(string string_3)
		{
			this.ixboxConsole_0.WriteInt32(2185854736U, 962592768);
			this.NopIt(2185854640U);
			this.NopIt(2185854664U);
			this.NopIt(2185854752U);
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				string_3
			});
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00033AFC File Offset: 0x00031CFC
		private void simpleButton263_Click(object sender, EventArgs e)
		{
			this.method_76("setStatFromLocString cacloadouts customclassname 0 \"[{+gostand}]\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 1 \"[{+usereload}]\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 2 \"[{+stance}]\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 3 \"[{+attack}]\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 4 \"[{+melee}]\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 5 \"[{+gostand}]\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 6 \"[{+usereload}]\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 7 \"[{+stance}]\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 8 \"[{+attack}]\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 9 \"[{+melee}]\"");
			this.method_76("updategamerprofile;uploadstats");
			this.ixboxConsole_0.XNotify("Set Class Names To Buttons!");
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00033B94 File Offset: 0x00031D94
		private void simpleButton301_Click(object sender, EventArgs e)
		{
			this.method_76("setStatFromLocString cacloadouts customclassname 0 \"Custom 1\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 1 \"Custom 2\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 2 \"Custom 3\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 3 \"Custom 4\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 4 \"Custom 5\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 5 \"Custom 6\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 6 \"Custom 7\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 7 \"Custom 8\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 8 \"Custom 9\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 9 \"Custom 10\"");
			this.method_76("updategamerprofile;uploadstats");
			this.ixboxConsole_0.XNotify("Undid Button Class Names!");
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00033C2C File Offset: 0x00031E2C
		private void simpleButton260_Click(object sender, EventArgs e)
		{
			this.method_76("setStatFromLocString cacloadouts customclassname 0 \"^H^H\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 1 \"^H^H\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 2 \"^H^H\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 3 \"^H^H\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 4 \"^H^H\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 5 \"^H^H\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 6 \"^H^H\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 7 \"^H^H\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 8 \"^H^H\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 9 \"^H^H\"");
			this.method_76("updategamerprofile;uploadstats");
			this.ixboxConsole_0.XNotify("Froze Classes!");
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00033CC4 File Offset: 0x00031EC4
		private void simpleButton261_Click(object sender, EventArgs e)
		{
			this.method_76("setStatFromLocString cacloadouts customclassname 0 \"Custom 1\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 1 \"Custom 2\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 2 \"Custom 3\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 3 \"Custom 4\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 4 \"Custom 5\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 5 \"Custom 6\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 6 \"Custom 7\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 7 \"Custom 8\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 8 \"Custom 9\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 9 \"Custom 10\"");
			this.method_76("updategamerprofile;uploadstats");
			this.ixboxConsole_0.XNotify("Unfroze Classes!");
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00033D5C File Offset: 0x00031F5C
		private void simpleButton419_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists("ClassSave"))
			{
				Directory.CreateDirectory("./ClassSave");
			}
			if (File.Exists("./ClassSave\\\\ClassBackupLoadouts.bin"))
			{
				DialogResult dialogResult = XtraMessageBox.Show("There has been an already existing backup found, do you want to delete this one?", "Warning", MessageBoxButtons.YesNo);
				if (dialogResult != DialogResult.Yes)
				{
					return;
				}
				try
				{
					File.Delete("./ClassSave\\\\ClassBackupLoadouts.bin");
					File.WriteAllBytes("./ClassSave\\\\ClassBackupLoadouts.bin", this.ixboxConsole_0.GetMemory(2218080837U, 534U));
					this.ixboxConsole_0.XNotify("Classes Saved!");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
			File.WriteAllBytes("./ClassSave\\\\ClassBackupLoadouts.bin", this.ixboxConsole_0.GetMemory(2218080837U, 534U));
			this.ixboxConsole_0.XNotify("Classes Saved!");
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00033E28 File Offset: 0x00032028
		private void simpleButton431_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists("ClassSave"))
			{
				Directory.CreateDirectory("./ClassSave");
			}
			if (File.Exists("./ClassSave\\\\ClassBackupLoadouts.bin"))
			{
				this.ixboxConsole_0.SetMemory(2218080837U, File.ReadAllBytes("./ClassSave\\\\ClassBackupLoadouts.bin"));
				this.ixboxConsole_0.XNotify("Class Backup Loaded!");
			}
			else
			{
				DialogResult dialogResult = XtraMessageBox.Show("No Backup Was Found, do you want to create one?", "Warning", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					File.WriteAllBytes("./ClassSave\\\\ClassBackupLoadouts.bin", this.ixboxConsole_0.GetMemory(2218080837U, 534U));
					this.ixboxConsole_0.XNotify("Classes Saved!");
				}
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00033ED4 File Offset: 0x000320D4
		private void simpleButton629_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit13.SelectedIndex == 0)
			{
				this.method_59("^H\u007f\u007f\u0004logo");
			}
			if (this.comboBoxEdit13.SelectedIndex == 1)
			{
				this.method_59("^H\u007f\u007f\u0010dualoptic_down_9");
			}
			if (this.comboBoxEdit13.SelectedIndex == 2)
			{
				this.method_59("^H\u007f\u007f\breflex_8");
			}
			if (this.comboBoxEdit13.SelectedIndex == 3)
			{
				this.method_59("^H\u007f\u007f\u0013compass_map_flicker");
			}
			if (this.comboBoxEdit13.SelectedIndex == 4)
			{
				this.method_59("^H\u007f\u007f\u0019menu_codtv_icon_mychannel");
			}
			if (this.comboBoxEdit13.SelectedIndex == 5)
			{
				this.method_59("^H\u007f\u007f\u0017menu_lobby_icon_twitter");
			}
			if (this.comboBoxEdit13.SelectedIndex == 6)
			{
				this.method_59("^H\u007f\u007f\fyoutube_logo");
			}
			if (this.comboBoxEdit13.SelectedIndex == 7)
			{
				this.method_59("^H\u007f\u007f\u000ehud_anim_cobra");
			}
			if (this.comboBoxEdit13.SelectedIndex == 8)
			{
				this.method_59("^H\u007f\u007f\vping_bar_04");
			}
			if (this.comboBoxEdit13.SelectedIndex == 9)
			{
				this.method_59("^H\u007f\u007f\vping_bar_01");
			}
			if (this.comboBoxEdit13.SelectedIndex == 10)
			{
				this.method_59("^H\u007f\u007f\u0011net_new_animation");
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0003400C File Offset: 0x0003220C
		private void method_77(object sender, EventArgs e)
		{
			byte[] data = new byte[]
			{
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				140,
				141,
				4,
				0,
				0,
				0,
				128,
				222,
				0,
				0,
				0,
				0,
				0,
				94,
				1,
				0,
				0,
				0,
				128,
				163,
				52,
				0,
				0,
				0,
				127,
				8,
				12,
				0,
				0,
				0,
				0,
				108,
				0,
				0,
				0,
				50,
				128,
				158,
				67,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				32,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				7,
				0,
				0,
				128,
				7,
				0,
				134,
				0,
				0,
				0,
				15,
				128,
				72,
				1,
				0,
				0,
				75,
				128,
				108,
				0,
				0,
				0,
				75,
				128,
				159,
				0,
				0,
				0,
				10,
				128,
				70,
				0,
				0,
				0,
				5,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				29,
				1,
				36,
				133,
				132,
				55,
				32,
				131,
				53,
				1,
				0,
				0,
				0,
				96,
				35,
				0,
				0,
				0,
				0,
				0,
				94,
				0,
				0,
				0,
				0,
				96,
				135,
				9,
				0,
				0,
				0,
				30,
				157,
				2,
				0,
				0,
				0,
				96,
				31,
				0,
				0,
				128,
				12,
				160,
				204,
				16,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				9,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				224,
				1,
				0,
				0,
				224,
				1,
				32,
				36,
				0,
				0,
				192,
				3,
				32,
				41,
				0,
				0,
				192,
				18,
				64,
				30,
				0,
				0,
				192,
				18,
				32,
				39,
				0,
				0,
				128,
				2,
				0,
				18,
				0,
				0,
				64,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				64,
				71,
				0,
				73,
				101,
				210,
				15,
				200,
				32,
				71,
				0,
				0,
				0,
				0,
				8,
				17,
				0,
				0,
				0,
				0,
				176,
				21,
				0,
				0,
				0,
				0,
				208,
				98,
				3,
				0,
				0,
				0,
				175,
				194,
				0,
				0,
				0,
				0,
				88,
				7,
				0,
				0,
				32,
				3,
				248,
				178,
				3,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				80,
				2,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				120,
				0,
				0,
				0,
				120,
				0,
				104,
				8,
				0,
				0,
				240,
				0,
				144,
				13,
				0,
				0,
				176,
				4,
				128,
				8,
				0,
				0,
				176,
				4,
				112,
				8,
				0,
				0,
				160,
				0,
				144,
				3,
				0,
				0,
				80,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				208,
				17,
				64,
				82,
				21,
				216,
				3,
				50,
				252,
				14,
				0,
				0,
				0,
				0,
				248,
				0,
				0,
				0,
				0,
				0,
				232,
				7,
				0,
				0,
				0,
				0,
				178,
				61,
				0,
				0,
				0,
				0,
				57,
				6,
				0,
				0,
				0,
				0,
				172,
				1,
				0,
				0,
				200,
				0,
				218,
				250,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				188,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				30,
				0,
				174,
				1,
				0,
				0,
				60,
				0,
				108,
				1,
				0,
				0,
				44,
				1,
				80,
				2,
				0,
				0,
				44,
				1,
				114,
				1,
				0,
				0,
				40,
				0,
				198,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				52,
				4,
				144,
				212,
				56,
				202,
				128,
				8,
				165,
				4,
				0,
				0,
				0,
				128,
				115,
				0,
				0,
				0,
				0,
				0,
				91,
				1,
				0,
				0,
				0,
				0,
				227,
				48,
				0,
				0,
				0,
				184,
				78,
				11,
				0,
				0,
				0,
				128,
				123,
				0,
				0,
				0,
				50,
				128,
				126,
				57,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				41,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				7,
				0,
				0,
				128,
				7,
				128,
				139,
				0,
				0,
				0,
				15,
				128,
				155,
				0,
				0,
				0,
				75,
				0,
				133,
				0,
				0,
				0,
				75,
				0,
				158,
				0,
				0,
				0,
				10,
				128,
				66,
				0,
				0,
				0,
				5,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				29,
				1,
				36,
				53,
				170,
				62,
				32,
				192,
				8,
				0,
				0,
				0,
				0,
				224,
				1,
				0,
				0,
				0,
				0,
				128,
				2,
				0,
				0,
				0,
				0,
				224,
				128,
				0,
				0,
				0,
				0,
				0,
				27,
				0,
				0,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				64,
				120,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				32,
				0,
				0,
				0,
				32,
				0,
				192,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				3,
				0,
				0,
				0,
				0,
				32,
				1,
				0,
				0,
				0,
				0,
				160,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				80,
				145,
				0,
				0,
				248,
				1,
				0,
				0,
				0,
				0,
				32,
				0,
				0,
				0,
				0,
				0,
				200,
				0,
				0,
				0,
				0,
				0,
				96,
				21,
				0,
				0,
				0,
				0,
				72,
				4,
				0,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				40,
				0,
				120,
				26,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				8,
				0,
				0,
				0,
				8,
				0,
				64,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				112,
				0,
				0,
				0,
				0,
				0,
				72,
				0,
				0,
				0,
				0,
				0,
				32,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				228,
				37,
				0,
				0,
				122,
				0,
				0,
				0,
				0,
				0,
				6,
				0,
				0,
				0,
				0,
				0,
				36,
				0,
				0,
				0,
				0,
				0,
				18,
				6,
				0,
				0,
				0,
				0,
				34,
				1,
				0,
				0,
				0,
				0,
				14,
				0,
				0,
				0,
				14,
				0,
				242,
				3,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				2,
				0,
				0,
				0,
				2,
				0,
				16,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				6,
				0,
				0,
				0,
				0,
				0,
				12,
				0,
				0,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				246,
				9,
				0,
				128,
				7,
				0,
				0,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				0,
				128,
				1,
				0,
				0,
				0,
				0,
				128,
				35,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				128,
				146,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				0,
				0,
				0,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				125,
				0,
				0,
				128,
				4,
				0,
				0,
				0,
				0,
				160,
				0,
				0,
				0,
				0,
				0,
				96,
				1,
				0,
				0,
				0,
				0,
				96,
				79,
				0,
				0,
				0,
				0,
				0,
				15,
				0,
				0,
				0,
				0,
				64,
				0,
				0,
				0,
				64,
				0,
				160,
				49,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				96,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				192,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				0,
				0,
				0,
				0,
				0,
				128,
				0,
				0,
				0,
				0,
				0,
				64,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				64,
				106,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				32,
				98,
				22,
				0,
				0,
				0,
				0,
				180,
				18,
				0,
				0,
				0,
				0,
				106,
				7,
				0,
				0,
				0,
				0,
				78,
				204,
				1,
				0,
				0,
				0,
				172,
				98,
				0,
				0,
				0,
				0,
				192,
				1,
				0,
				0,
				200,
				0,
				48,
				99,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				144,
				2,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				30,
				0,
				246,
				1,
				0,
				0,
				60,
				0,
				124,
				2,
				0,
				0,
				44,
				1,
				234,
				1,
				0,
				0,
				44,
				1,
				90,
				3,
				0,
				0,
				40,
				0,
				160,
				1,
				0,
				0,
				20,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				100,
				53,
				252,
				6,
				222,
				250,
				128,
				12,
				102,
				5,
				0,
				0,
				0,
				128,
				26,
				2,
				0,
				0,
				0,
				128,
				13,
				2,
				0,
				0,
				0,
				0,
				197,
				111,
				0,
				0,
				0,
				0,
				77,
				26,
				0,
				0,
				0,
				128,
				112,
				0,
				0,
				0,
				50,
				128,
				140,
				90,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				135,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				7,
				0,
				0,
				128,
				7,
				0,
				147,
				0,
				0,
				0,
				15,
				0,
				110,
				0,
				0,
				0,
				75,
				0,
				117,
				0,
				0,
				0,
				75,
				0,
				171,
				0,
				0,
				0,
				10,
				128,
				80,
				0,
				0,
				0,
				5,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				89,
				13,
				191,
				1,
				213,
				52,
				32,
				195,
				143,
				3,
				0,
				0,
				0,
				32,
				100,
				1,
				0,
				0,
				0,
				0,
				163,
				1,
				0,
				0,
				0,
				224,
				120,
				27,
				0,
				0,
				0,
				153,
				216,
				4,
				0,
				0,
				0,
				224,
				84,
				0,
				0,
				128,
				12,
				64,
				185,
				22,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				42,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				224,
				1,
				0,
				0,
				224,
				1,
				160,
				34,
				0,
				0,
				192,
				3,
				224,
				25,
				0,
				0,
				192,
				18,
				64,
				24,
				0,
				0,
				192,
				18,
				64,
				55,
				0,
				0,
				128,
				2,
				224,
				21,
				0,
				0,
				64,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				64,
				86,
				195,
				111,
				12,
				127,
				16,
				200,
				0,
				98,
				0,
				0,
				0,
				0,
				8,
				15,
				0,
				0,
				0,
				0,
				40,
				32,
				0,
				0,
				0,
				0,
				8,
				172,
				7,
				0,
				0,
				0,
				168,
				209,
				1,
				0,
				0,
				0,
				40,
				8,
				0,
				0,
				32,
				3,
				224,
				62,
				6,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				16,
				9,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				120,
				0,
				0,
				0,
				120,
				0,
				232,
				10,
				0,
				0,
				240,
				0,
				168,
				7,
				0,
				0,
				176,
				4,
				176,
				7,
				0,
				0,
				176,
				4,
				88,
				12,
				0,
				0,
				160,
				0,
				96,
				6,
				0,
				0,
				80,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				144,
				213,
				240,
				27,
				242,
				225,
				3,
				34,
				72,
				30,
				0,
				0,
				0,
				0,
				126,
				19,
				0,
				0,
				0,
				0,
				250,
				13,
				0,
				0,
				0,
				0,
				224,
				147,
				1,
				0,
				0,
				0,
				184,
				87,
				0,
				0,
				0,
				0,
				180,
				2,
				0,
				0,
				200,
				0,
				60,
				112,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				112,
				2,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				30,
				0,
				100,
				2,
				0,
				0,
				60,
				0,
				78,
				2,
				0,
				0,
				44,
				1,
				16,
				2,
				0,
				0,
				44,
				1,
				42,
				3,
				0,
				0,
				40,
				0,
				52,
				1,
				0,
				0,
				20,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				100,
				53,
				252,
				134,
				120,
				207,
				128,
				12,
				147,
				7,
				0,
				0,
				0,
				0,
				52,
				2,
				0,
				0,
				0,
				128,
				126,
				3,
				0,
				0,
				0,
				128,
				87,
				167,
				0,
				0,
				0,
				128,
				247,
				35,
				0,
				0,
				0,
				0,
				173,
				0,
				0,
				0,
				50,
				0,
				53,
				152,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				221,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				7,
				0,
				0,
				128,
				7,
				0,
				202,
				0,
				0,
				0,
				15,
				0,
				118,
				0,
				0,
				0,
				75,
				0,
				91,
				0,
				0,
				0,
				75,
				0,
				251,
				0,
				0,
				0,
				10,
				128,
				120,
				0,
				0,
				0,
				5,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				89,
				13,
				191,
				225,
				44,
				117,
				32,
				226,
				163,
				1,
				0,
				0,
				0,
				224,
				88,
				0,
				0,
				0,
				0,
				96,
				197,
				0,
				0,
				0,
				0,
				192,
				48,
				28,
				0,
				0,
				0,
				251,
				247,
				6,
				0,
				0,
				0,
				128,
				50,
				0,
				0,
				128,
				12,
				32,
				108,
				22,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				192,
				48,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				224,
				1,
				0,
				0,
				224,
				1,
				192,
				36,
				0,
				0,
				192,
				3,
				192,
				28,
				0,
				0,
				192,
				18,
				96,
				20,
				0,
				0,
				192,
				18,
				64,
				65,
				0,
				0,
				128,
				2,
				160,
				33,
				0,
				0,
				64,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				64,
				86,
				195,
				111,
				172,
				208,
				30,
				8,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				8,
				132,
				0,
				0,
				0,
				0,
				248,
				9,
				0,
				0,
				0,
				0,
				72,
				62,
				0,
				0,
				0,
				0,
				200,
				216,
				3,
				0,
				0,
				0,
				88,
				249,
				0,
				0,
				0,
				0,
				224,
				14,
				0,
				0,
				32,
				3,
				232,
				6,
				4,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				88,
				6,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				120,
				0,
				0,
				0,
				120,
				0,
				40,
				3,
				0,
				0,
				80,
				0,
				128,
				5,
				0,
				0,
				176,
				4,
				136,
				6,
				0,
				0,
				176,
				4,
				192,
				9,
				0,
				0,
				160,
				0,
				96,
				5,
				0,
				0,
				80,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				56,
				245,
				112,
				27,
				162,
				61,
				2,
				34,
				108,
				76,
				0,
				0,
				0,
				0,
				150,
				5,
				0,
				0,
				0,
				0,
				200,
				33,
				0,
				0,
				0,
				0,
				62,
				117,
				1,
				0,
				0,
				0,
				89,
				74,
				0,
				0,
				0,
				0,
				82,
				10,
				0,
				0,
				200,
				0,
				4,
				205,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				96,
				2,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				30,
				0,
				86,
				0,
				0,
				0,
				20,
				0,
				144,
				1,
				0,
				0,
				44,
				1,
				98,
				1,
				0,
				0,
				44,
				1,
				114,
				3,
				0,
				0,
				40,
				0,
				208,
				1,
				0,
				0,
				20,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				78,
				61,
				220,
				198,
				173,
				189,
				129,
				136,
				228,
				15,
				0,
				0,
				0,
				0,
				175,
				2,
				0,
				0,
				0,
				128,
				114,
				7,
				0,
				0,
				0,
				0,
				68,
				97,
				0,
				0,
				0,
				58,
				176,
				20,
				0,
				0,
				0,
				0,
				206,
				1,
				0,
				0,
				50,
				0,
				230,
				92,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				153,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				7,
				0,
				0,
				128,
				7,
				0,
				23,
				0,
				0,
				0,
				5,
				128,
				99,
				0,
				0,
				0,
				75,
				128,
				113,
				0,
				0,
				0,
				75,
				0,
				225,
				0,
				0,
				0,
				10,
				128,
				99,
				0,
				0,
				0,
				5,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				83,
				15,
				183,
				129,
				147,
				65,
				32,
				67,
				23,
				1,
				0,
				0,
				0,
				96,
				46,
				0,
				0,
				0,
				0,
				64,
				69,
				0,
				0,
				0,
				0,
				224,
				155,
				14,
				0,
				0,
				0,
				64,
				216,
				3,
				0,
				0,
				0,
				96,
				29,
				0,
				0,
				128,
				12,
				32,
				36,
				17,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				160,
				26,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				224,
				1,
				0,
				0,
				224,
				1,
				64,
				17,
				0,
				0,
				64,
				1,
				224,
				24,
				0,
				0,
				192,
				18,
				32,
				23,
				0,
				0,
				192,
				18,
				192,
				42,
				0,
				0,
				128,
				2,
				64,
				22,
				0,
				0,
				64,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				224,
				212,
				195,
				109,
				240,
				250,
				10,
				200,
				168,
				197,
				0,
				0,
				0,
				0,
				208,
				33,
				0,
				0,
				0,
				0,
				72,
				93,
				0,
				0,
				0,
				0,
				144,
				byte.MaxValue,
				6,
				0,
				0,
				0,
				249,
				118,
				1,
				0,
				0,
				0,
				136,
				21,
				0,
				0,
				32,
				3,
				112,
				237,
				5,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				136,
				9,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				120,
				0,
				0,
				0,
				120,
				0,
				48,
				1,
				0,
				0,
				80,
				0,
				168,
				6,
				0,
				0,
				176,
				4,
				240,
				5,
				0,
				0,
				176,
				4,
				152,
				11,
				0,
				0,
				160,
				0,
				24,
				6,
				0,
				0,
				80,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				56,
				245,
				112,
				27,
				105,
				71,
				4,
				50,
				36,
				22,
				0,
				0,
				0,
				0,
				8,
				6,
				0,
				0,
				0,
				0,
				216,
				10,
				0,
				0,
				0,
				0,
				60,
				139,
				0,
				0,
				0,
				0,
				42,
				38,
				0,
				0,
				0,
				0,
				70,
				2,
				0,
				0,
				200,
				0,
				250,
				218,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				36,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				30,
				0,
				6,
				1,
				0,
				0,
				20,
				0,
				64,
				1,
				0,
				0,
				44,
				1,
				124,
				1,
				0,
				0,
				44,
				1,
				30,
				2,
				0,
				0,
				40,
				0,
				40,
				1,
				0,
				0,
				20,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				78,
				61,
				220,
				70,
				218,
				123,
				128,
				140,
				171,
				4,
				0,
				0,
				0,
				0,
				108,
				0,
				0,
				0,
				0,
				128,
				217,
				0,
				0,
				0,
				0,
				0,
				40,
				40,
				0,
				0,
				0,
				0,
				221,
				10,
				0,
				0,
				0,
				128,
				129,
				0,
				0,
				0,
				50,
				128,
				229,
				77,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				85,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				7,
				0,
				0,
				128,
				7,
				0,
				65,
				0,
				0,
				0,
				5,
				0,
				77,
				0,
				0,
				0,
				75,
				0,
				99,
				0,
				0,
				0,
				75,
				128,
				175,
				0,
				0,
				0,
				10,
				0,
				87,
				0,
				0,
				0,
				5,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				83,
				15,
				183,
				97,
				176,
				43,
				32,
				163,
				111,
				1,
				0,
				0,
				0,
				64,
				141,
				0,
				0,
				0,
				0,
				224,
				117,
				0,
				0,
				0,
				0,
				64,
				30,
				27,
				0,
				0,
				0,
				224,
				58,
				6,
				0,
				0,
				0,
				160,
				30,
				0,
				0,
				128,
				12,
				64,
				90,
				23,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				192,
				44,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				224,
				1,
				0,
				0,
				224,
				1,
				192,
				7,
				0,
				0,
				64,
				1,
				32,
				30,
				0,
				0,
				192,
				18,
				160,
				31,
				0,
				0,
				192,
				18,
				0,
				52,
				0,
				0,
				128,
				2,
				96,
				23,
				0,
				0,
				64,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				224,
				212,
				195,
				109,
				140,
				14,
				16,
				136,
				224,
				87,
				0,
				0,
				0,
				0,
				96,
				36,
				0,
				0,
				0,
				0,
				200,
				25,
				0,
				0,
				0,
				0,
				200,
				18,
				6,
				0,
				0,
				0,
				195,
				80,
				1,
				0,
				0,
				0,
				136,
				7,
				0,
				0,
				32,
				3,
				176,
				121,
				5,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				192,
				8,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				120,
				0,
				0,
				0,
				120,
				0,
				72,
				1,
				0,
				0,
				80,
				0,
				248,
				7,
				0,
				0,
				176,
				4,
				56,
				6,
				0,
				0,
				176,
				4,
				240,
				11,
				0,
				0,
				160,
				0,
				16,
				7,
				0,
				0,
				80,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				56,
				245,
				112,
				27,
				3,
				238,
				3,
				2,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				144,
				66,
				0,
				0,
				0,
				0,
				48,
				13,
				0,
				0,
				0,
				0,
				112,
				16,
				0,
				0,
				0,
				0,
				8,
				122,
				4,
				0,
				0,
				0,
				188,
				213,
				0,
				0,
				0,
				0,
				224,
				7,
				0,
				0,
				32,
				3,
				240,
				136,
				3,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				112,
				5,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				120,
				0,
				0,
				0,
				120,
				0,
				176,
				5,
				0,
				0,
				80,
				0,
				96,
				6,
				0,
				0,
				176,
				4,
				232,
				7,
				0,
				0,
				176,
				4,
				24,
				11,
				0,
				0,
				160,
				0,
				240,
				4,
				0,
				0,
				80,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				40,
				213,
				225,
				154,
				133,
				170,
				2,
				50,
				28,
				25,
				0,
				0,
				0,
				0,
				114,
				1,
				0,
				0,
				0,
				0,
				168,
				13,
				0,
				0,
				0,
				0,
				218,
				33,
				1,
				0,
				0,
				0,
				203,
				61,
				0,
				0,
				0,
				0,
				34,
				2,
				0,
				0,
				200,
				0,
				102,
				196,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				108,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				30,
				0,
				128,
				0,
				0,
				0,
				20,
				0,
				98,
				1,
				0,
				0,
				44,
				1,
				148,
				1,
				0,
				0,
				44,
				1,
				70,
				2,
				0,
				0,
				40,
				0,
				48,
				1,
				0,
				0,
				20,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				74,
				117,
				184,
				102,
				112,
				149,
				128,
				140,
				211,
				6,
				0,
				0,
				0,
				0,
				220,
				0,
				0,
				0,
				0,
				0,
				114,
				3,
				0,
				0,
				0,
				128,
				182,
				75,
				0,
				0,
				0,
				53,
				118,
				13,
				0,
				0,
				0,
				0,
				167,
				0,
				0,
				0,
				50,
				128,
				205,
				50,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				88,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				7,
				0,
				0,
				128,
				7,
				0,
				62,
				0,
				0,
				0,
				5,
				0,
				86,
				0,
				0,
				0,
				75,
				0,
				102,
				0,
				0,
				0,
				75,
				128,
				185,
				0,
				0,
				0,
				10,
				128,
				77,
				0,
				0,
				0,
				5,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				82,
				29,
				174,
				41,
				200,
				38,
				32,
				195,
				26,
				1,
				0,
				0,
				0,
				96,
				30,
				0,
				0,
				0,
				0,
				160,
				129,
				0,
				0,
				0,
				0,
				96,
				22,
				17,
				0,
				0,
				0,
				242,
				46,
				3,
				0,
				0,
				0,
				224,
				32,
				0,
				0,
				128,
				12,
				192,
				201,
				13,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				22,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				224,
				1,
				0,
				0,
				224,
				1,
				0,
				11,
				0,
				0,
				64,
				1,
				160,
				22,
				0,
				0,
				192,
				18,
				32,
				22,
				0,
				0,
				192,
				18,
				128,
				33,
				0,
				0,
				128,
				2,
				96,
				16,
				0,
				0,
				64,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				160,
				84,
				135,
				107,
				130,
				133,
				9,
				8,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				140,
				211,
				5,
				0,
				0,
				0,
				128,
				160,
				0,
				0,
				0,
				0,
				128,
				13,
				3,
				0,
				0,
				0,
				128,
				170,
				11,
				0,
				0,
				0,
				155,
				89,
				5,
				0,
				0,
				0,
				128,
				222,
				0,
				0,
				0,
				0,
				128,
				130,
				110,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				55,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				7,
				0,
				0,
				128,
				7,
				128,
				6,
				5,
				0,
				0,
				125,
				128,
				177,
				0,
				0,
				0,
				5,
				0,
				130,
				0,
				0,
				0,
				25,
				0,
				39,
				0,
				0,
				0,
				25,
				0,
				173,
				0,
				0,
				128,
				2,
				0,
				97,
				0,
				0,
				0,
				5,
				128,
				17,
				49,
				32,
				75,
				24,
				72,
				32,
				2,
				215,
				0,
				0,
				0,
				0,
				192,
				36,
				0,
				0,
				0,
				0,
				0,
				52,
				0,
				0,
				0,
				0,
				0,
				185,
				3,
				0,
				0,
				0,
				160,
				138,
				1,
				0,
				0,
				0,
				128,
				35,
				0,
				0,
				0,
				0,
				64,
				39,
				14,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				192,
				11,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				224,
				1,
				0,
				0,
				224,
				1,
				160,
				59,
				0,
				0,
				64,
				31,
				64,
				19,
				0,
				0,
				64,
				1,
				128,
				11,
				0,
				0,
				64,
				6,
				192,
				18,
				0,
				0,
				64,
				6,
				128,
				30,
				0,
				0,
				160,
				0,
				64,
				15,
				0,
				0,
				64,
				1,
				96,
				68,
				4,
				200,
				186,
				26,
				10,
				200,
				0,
				108,
				0,
				0,
				0,
				0,
				24,
				32,
				0,
				0,
				0,
				0,
				8,
				52,
				0,
				0,
				0,
				0,
				248,
				192,
				0,
				0,
				0,
				0,
				246,
				100,
				0,
				0,
				0,
				0,
				248,
				12,
				0,
				0,
				0,
				0,
				192,
				120,
				7,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				120,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				120,
				0,
				0,
				0,
				120,
				0,
				96,
				97,
				0,
				0,
				208,
				7,
				248,
				14,
				0,
				0,
				80,
				0,
				184,
				13,
				0,
				0,
				144,
				1,
				112,
				3,
				0,
				0,
				144,
				1,
				144,
				13,
				0,
				0,
				40,
				0,
				24,
				7,
				0,
				0,
				80,
				0,
				24,
				17,
				1,
				178,
				202,
				178,
				5,
				50,
				80,
				16,
				0,
				0,
				0,
				0,
				16,
				1,
				0,
				0,
				0,
				0,
				50,
				3,
				0,
				0,
				0,
				0,
				252,
				38,
				0,
				0,
				0,
				0,
				216,
				19,
				0,
				0,
				0,
				0,
				220,
				2,
				0,
				0,
				0,
				0,
				158,
				13,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				98,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				30,
				0,
				130,
				12,
				0,
				0,
				244,
				1,
				22,
				2,
				0,
				0,
				20,
				0,
				142,
				0,
				0,
				0,
				100,
				0,
				146,
				0,
				0,
				0,
				100,
				0,
				52,
				2,
				0,
				0,
				10,
				0,
				50,
				1,
				0,
				0,
				20,
				0,
				70,
				68,
				128,
				236,
				163,
				205,
				128,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				66,
				117,
				1,
				0,
				0,
				0,
				128,
				167,
				0,
				0,
				0,
				0,
				32,
				118,
				0,
				0,
				0,
				0,
				192,
				63,
				2,
				0,
				0,
				0,
				224,
				202,
				1,
				0,
				0,
				0,
				192,
				20,
				0,
				0,
				0,
				0,
				96,
				164,
				20,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				96,
				11,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				224,
				1,
				0,
				0,
				224,
				1,
				0,
				30,
				1,
				0,
				64,
				31,
				0,
				34,
				0,
				0,
				192,
				3,
				96,
				14,
				0,
				0,
				64,
				6,
				96,
				18,
				0,
				0,
				64,
				6,
				128,
				60,
				0,
				0,
				160,
				0,
				64,
				26,
				0,
				0,
				64,
				1,
				64,
				22,
				64,
				105,
				200,
				229,
				16,
				200,
				184,
				100,
				0,
				0,
				0,
				0,
				72,
				4,
				0,
				0,
				0,
				0,
				40,
				36,
				0,
				0,
				0,
				0,
				56,
				8,
				2,
				0,
				0,
				0,
				224,
				227,
				0,
				0,
				0,
				0,
				120,
				7,
				0,
				0,
				0,
				0,
				168,
				156,
				6,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				192,
				3,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				120,
				0,
				0,
				0,
				120,
				0,
				8,
				30,
				0,
				0,
				208,
				7,
				224,
				9,
				0,
				0,
				240,
				0,
				32,
				2,
				0,
				0,
				144,
				1,
				24,
				2,
				0,
				0,
				144,
				1,
				192,
				12,
				0,
				0,
				40,
				0,
				80,
				7,
				0,
				0,
				80,
				0,
				144,
				5,
				80,
				26,
				228,
				7,
				5,
				50,
				40,
				27,
				0,
				0,
				0,
				0,
				90,
				2,
				0,
				0,
				0,
				0,
				60,
				9,
				0,
				0,
				0,
				0,
				20,
				119,
				0,
				0,
				0,
				0,
				190,
				59,
				0,
				0,
				0,
				0,
				228,
				1,
				0,
				0,
				0,
				0,
				28,
				164,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				156,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				30,
				0,
				222,
				8,
				0,
				0,
				244,
				1,
				210,
				2,
				0,
				0,
				60,
				0,
				242,
				0,
				0,
				0,
				100,
				0,
				190,
				0,
				0,
				0,
				100,
				0,
				238,
				3,
				0,
				0,
				10,
				0,
				2,
				2,
				0,
				0,
				20,
				0,
				100,
				1,
				148,
				198,
				207,
				74,
				129,
				12,
				204,
				5,
				0,
				0,
				0,
				128,
				163,
				0,
				0,
				0,
				0,
				128,
				193,
				1,
				0,
				0,
				0,
				128,
				121,
				10,
				0,
				0,
				0,
				0,
				137,
				6,
				0,
				0,
				0,
				0,
				82,
				0,
				0,
				0,
				0,
				0,
				163,
				82,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				29,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				7,
				0,
				0,
				128,
				7,
				0,
				165,
				4,
				0,
				0,
				125,
				128,
				145,
				0,
				0,
				0,
				15,
				0,
				67,
				0,
				0,
				0,
				25,
				0,
				36,
				0,
				0,
				0,
				25,
				0,
				230,
				0,
				0,
				128,
				2,
				0,
				113,
				0,
				0,
				0,
				5,
				0,
				89,
				0,
				165,
				17,
				82,
				72,
				32,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				32,
				172,
				1,
				0,
				0,
				0,
				0,
				234,
				0,
				0,
				0,
				0,
				0,
				248,
				0,
				0,
				0,
				0,
				0,
				138,
				6,
				0,
				0,
				0,
				0,
				56,
				3,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				118,
				37,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				8,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				30,
				0,
				48,
				1,
				0,
				0,
				200,
				0,
				110,
				0,
				0,
				0,
				20,
				0,
				18,
				0,
				0,
				0,
				2,
				0,
				6,
				0,
				0,
				0,
				2,
				0,
				106,
				0,
				0,
				0,
				10,
				0,
				6,
				0,
				0,
				0,
				2,
				0,
				0,
				0,
				0,
				0,
				97,
				38,
				128,
				12,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				35,
				0,
				0,
				0,
				0,
				0,
				14,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				124,
				6,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				7,
				0,
				0,
				128,
				7,
				0,
				192,
				0,
				0,
				0,
				50,
				128,
				169,
				0,
				0,
				0,
				5,
				128,
				8,
				0,
				0,
				128,
				0,
				0,
				8,
				0,
				0,
				128,
				0,
				0,
				9,
				0,
				0,
				0,
				5,
				128,
				1,
				0,
				0,
				128,
				0,
				0,
				0,
				0,
				0,
				96,
				148,
				6,
				32,
				35,
				41,
				0,
				0,
				128,
				12,
				32,
				10,
				0,
				0,
				0,
				0,
				32,
				12,
				0,
				0,
				0,
				0,
				192,
				107,
				0,
				0,
				0,
				0,
				160,
				52,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				96,
				166,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				96,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				224,
				1,
				0,
				0,
				224,
				1,
				64,
				7,
				0,
				0,
				64,
				1,
				32,
				0,
				0,
				0,
				32,
				0,
				0,
				1,
				0,
				0,
				32,
				0,
				0,
				5,
				0,
				0,
				160,
				0,
				0,
				2,
				0,
				0,
				32,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				80,
				245,
				0,
				8,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				48,
				156,
				3,
				0,
				0,
				200,
				0,
				28,
				0,
				0,
				0,
				0,
				0,
				72,
				4,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				34,
				164,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				26,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				30,
				0,
				146,
				69,
				0,
				0,
				248,
				7,
				154,
				1,
				0,
				0,
				50,
				0,
				180,
				1,
				0,
				0,
				50,
				0,
				160,
				0,
				0,
				0,
				50,
				0,
				52,
				0,
				0,
				0,
				50,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				64,
				115,
				11,
				128,
				140,
				236,
				1,
				0,
				0,
				150,
				0,
				55,
				0,
				0,
				0,
				0,
				0,
				61,
				1,
				0,
				0,
				0,
				0,
				112,
				8,
				0,
				0,
				0,
				102,
				6,
				2,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				38,
				30,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				23,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				7,
				0,
				0,
				128,
				7,
				128,
				33,
				0,
				0,
				128,
				0,
				128,
				56,
				0,
				0,
				128,
				2,
				0,
				6,
				0,
				0,
				128,
				0,
				128,
				4,
				0,
				0,
				128,
				0,
				128,
				21,
				0,
				0,
				128,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				0,
				16,
				68,
				184,
				153,
				21,
				32,
				35,
				105,
				0,
				0,
				0,
				0,
				96,
				19,
				0,
				0,
				0,
				0,
				0,
				65,
				0,
				0,
				0,
				0,
				32,
				151,
				0,
				0,
				0,
				0,
				63,
				33,
				0,
				0,
				0,
				0,
				224,
				3,
				0,
				0,
				0,
				0,
				192,
				176,
				7,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				224,
				1,
				0,
				0,
				224,
				1,
				160,
				106,
				0,
				0,
				128,
				37,
				128,
				12,
				0,
				0,
				160,
				0,
				160,
				17,
				0,
				0,
				32,
				3,
				64,
				63,
				0,
				0,
				32,
				3,
				128,
				12,
				0,
				0,
				32,
				0,
				0,
				5,
				0,
				0,
				64,
				0,
				0,
				0,
				0,
				0,
				176,
				55,
				4,
				8,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				86,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				220,
				0,
				0,
				0,
				0,
				0,
				144,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				188,
				25,
				0,
				0,
				0,
				0,
				16,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				2,
				43,
				0,
				0,
				128,
				37,
				32,
				25,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				246,
				0,
				0,
				0,
				0,
				160,
				81,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				160,
				144,
				207,
				0,
				0,
				0,
				192,
				241,
				0,
				0,
				0,
				0,
				0,
				6,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				48,
				155,
				2,
				192,
				24,
				21,
				0,
				0,
				96,
				9,
				184,
				2,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				240,
				80,
				0,
				0,
				0,
				0,
				80,
				21,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				248,
				17,
				5,
				0,
				0,
				0,
				248,
				76,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				16,
				8,
				1,
				48,
				92,
				3,
				0,
				0,
				88,
				2,
				132,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				94,
				26,
				0,
				0,
				0,
				0,
				164,
				8,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				72,
				6,
				5,
				0,
				0,
				0,
				98,
				25,
				0,
				0,
				0,
				0,
				194,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				155,
				47,
				0,
				12,
				16,
				3,
				0,
				0,
				150,
				0,
				44,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				62,
				9,
				0,
				0,
				0,
				128,
				157,
				4,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				151,
				102,
				1,
				0,
				0,
				0,
				11,
				9,
				0,
				0,
				0,
				128,
				43,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				32,
				77,
				46,
				0,
				35,
				165,
				0,
				0,
				128,
				37,
				64,
				18,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				32,
				117,
				2,
				0,
				0,
				0,
				96,
				235,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				83,
				110,
				0,
				0,
				0,
				192,
				238,
				2,
				0,
				0,
				0,
				160,
				7,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				84,
				113,
				8,
				192,
				88,
				51,
				0,
				0,
				96,
				9,
				32,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				136,
				244,
				0,
				0,
				0,
				0,
				48,
				72,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				160,
				122,
				57,
				0,
				0,
				0,
				176,
				244,
				0,
				0,
				0,
				0,
				80,
				3,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				45,
				193,
				2,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				12,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				133,
				0,
				0,
				0,
				0,
				0,
				6,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				74,
				56,
				0,
				0,
				0,
				0,
				133,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				66,
				1,
				0,
				0,
				0,
				0,
				96,
				2,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				96,
				252,
				0,
				0,
				0,
				0,
				32,
				140,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				96,
				220,
				35,
				0,
				0,
				0,
				32,
				140,
				0,
				0,
				0,
				0,
				64,
				11,
				0,
				0,
				0,
				0,
				224,
				78,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				160,
				15,
				0,
				192,
				120,
				0,
				0,
				0,
				0,
				0,
				16,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				216,
				78,
				0,
				0,
				0,
				0,
				136,
				63,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				248,
				151,
				15,
				0,
				0,
				0,
				192,
				77,
				0,
				0,
				0,
				0,
				64,
				18,
				0,
				0,
				0,
				0,
				152,
				19,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				124,
				21,
				0,
				48,
				6,
				0,
				0,
				0,
				0,
				0,
				4,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				82,
				7,
				0,
				0,
				0,
				0,
				68,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				12,
				123,
				1,
				0,
				0,
				0,
				66,
				7,
				0,
				0,
				0,
				0,
				42,
				0,
				0,
				0,
				0,
				0,
				222,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				175,
				0,
				0,
				12,
				2,
				0,
				0,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				27,
				3,
				0,
				0,
				0,
				0,
				56,
				3,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				200,
				239,
				0,
				0,
				0,
				128,
				130,
				1,
				0,
				0,
				0,
				0,
				64,
				0,
				0,
				0,
				0,
				0,
				75,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				25,
				0,
				0,
				195,
				1,
				0,
				0,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				96,
				184,
				1,
				0,
				0,
				0,
				192,
				115,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				192,
				114,
				116,
				0,
				0,
				0,
				224,
				222,
				1,
				0,
				0,
				0,
				64,
				34,
				0,
				0,
				0,
				0,
				224,
				67,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				80,
				20,
				0,
				192,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				248,
				112,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				192,
				247,
				30,
				0,
				0,
				0,
				64,
				85,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				224,
				49,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				22,
				113,
				0,
				48,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				66,
				16,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				156,
				0,
				0,
				0,
				0,
				0,
				32,
				74,
				5,
				0,
				0,
				0,
				190,
				9,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				118,
				4,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				140,
				2,
				0,
				0,
				0,
				0,
				128,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				96,
				2,
				0,
				0,
				0,
				128,
				30,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				31,
				146,
				0,
				0,
				0,
				128,
				79,
				2,
				0,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				82,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				37,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				206,
				4,
				0,
				0,
				144,
				1,
				26,
				2,
				0,
				0,
				0,
				0,
				240,
				4,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				104,
				179,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				30,
				0,
				254,
				0,
				0,
				0,
				20,
				0,
				66,
				0,
				0,
				0,
				10,
				0,
				142,
				0,
				0,
				0,
				10,
				0,
				70,
				0,
				0,
				0,
				10,
				0,
				30,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				1,
				79,
				0,
				128,
				12,
				0,
				0,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				215,
				0,
				0,
				0,
				0,
				128,
				38,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				240,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				7,
				128,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				1,
				224,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				191,
				55,
				0,
				0,
				0,
				248,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				127,
				0,
				248,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				175,
				4,
				0,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2218045086U, data);
			byte[] data2 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2218082975U, data2);
			this.ixboxConsole_0.SetMemory(2218083244U, new byte[]
			{
				byte.MaxValue
			});
			this.ixboxConsole_0.SetMemory(2218083241U, new byte[]
			{
				byte.MaxValue
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"uploadstats; updategamerprofile"
			});
			this.ixboxConsole_0.XNotify("Unlock All Given!");
		}

		// Token: 0x0600038C RID: 908 RVA: 0x000340E0 File Offset: 0x000322E0
		private void simpleButton634_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.WriteUInt32(2215141031U, 4294967055U);
			this.ixboxConsole_0.SetMemory(2215145697U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			this.ixboxConsole_0.SetMemory(2215145793U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data = new byte[]
			{
				192
			};
			this.ixboxConsole_0.SetMemory(2215146178U, data);
			byte[] data2 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215148128U, data2);
			byte[] data3 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215148380U, data3);
			byte[] data4 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215148967U, data4);
			byte[] data5 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215149051U, data5);
			byte[] data6 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215149303U, data6);
			byte[] data7 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215149135U, data7);
			byte[] data8 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215149386U, data8);
			byte[] data9 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215149470U, data9);
			byte[] data10 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215149554U, data10);
			byte[] data11 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215149638U, data11);
			byte[] data12 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215149647U, data12);
			byte[] data13 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215148128U, data13);
			byte[] data14 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215150141U, data14);
			byte[] data15 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215150225U, data15);
			byte[] data16 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215150309U, data16);
			byte[] data17 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215150393U, data17);
			byte[] data18 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215150477U, data18);
			byte[] data19 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215150561U, data19);
			byte[] data20 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215150645U, data20);
			byte[] data21 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215150728U, data21);
			byte[] data22 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215150812U, data22);
			byte[] data23 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215151148U, data23);
			byte[] data24 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215151232U, data24);
			byte[] data25 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215151316U, data25);
			byte[] data26 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215151567U, data26);
			byte[] data27 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215151651U, data27);
			byte[] data28 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215151735U, data28);
			byte[] data29 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215151987U, data29);
			byte[] data30 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215151903U, data30);
			byte[] data31 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215152154U, data31);
			byte[] data32 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215152490U, data32);
			byte[] data33 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215152574U, data33);
			byte[] data34 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215152658U, data34);
			byte[] data35 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215152741U, data35);
			byte[] data36 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215153161U, data36);
			byte[] data37 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215153329U, data37);
			byte[] data38 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215153412U, data38);
			byte[] data39 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215153664U, data39);
			byte[] data40 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215153748U, data40);
			byte[] data41 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215153832U, data41);
			byte[] data42 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215153916U, data42);
			byte[] data43 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215154083U, data43);
			byte[] data44 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215154167U, data44);
			byte[] data45 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215154251U, data45);
			byte[] data46 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215154335U, data46);
			byte[] data47 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215154419U, data47);
			byte[] data48 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215154503U, data48);
			this.ixboxConsole_0.SetMemory(2215156935U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data49 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215160541U, data49);
			this.ixboxConsole_0.SetMemory(2215160621U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data50 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215160709U, data50);
			byte[] data51 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215160793U, data51);
			byte[] data52 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215160877U, data52);
			byte[] data53 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215160961U, data53);
			byte[] data54 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215161045U, data54);
			byte[] data55 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215161129U, data55);
			byte[] data56 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215161212U, data56);
			byte[] data57 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215161297U, data57);
			byte[] data58 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215161380U, data58);
			byte[] data59 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215161464U, data59);
			byte[] data60 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215161548U, data60);
			byte[] data61 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215161632U, data61);
			byte[] data62 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215161716U, data62);
			byte[] data63 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215161800U, data63);
			byte[] data64 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215161883U, data64);
			byte[] data65 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215161968U, data65);
			byte[] data66 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215162051U, data66);
			byte[] data67 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215162135U, data67);
			byte[] data68 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215162218U, data68);
			byte[] data69 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215162303U, data69);
			byte[] data70 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215162386U, data70);
			byte[] data71 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215162471U, data71);
			byte[] data72 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215162554U, data72);
			byte[] data73 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215162639U, data73);
			byte[] data74 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215162722U, data74);
			byte[] data75 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215162806U, data75);
			byte[] data76 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215162890U, data76);
			byte[] data77 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215164316U, data77);
			byte[] data78 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215164400U, data78);
			byte[] data79 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215164568U, data79);
			byte[] data80 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215164736U, data80);
			byte[] data81 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215164819U, data81);
			byte[] data82 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215164899U, data82);
			byte[] data83 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215164903U, data83);
			byte[] data84 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215165155U, data84);
			byte[] data85 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215165239U, data85);
			byte[] data86 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215165323U, data86);
			byte[] data87 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215165407U, data87);
			byte[] data88 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215165490U, data88);
			byte[] data89 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215165658U, data89);
			byte[] data90 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215176914U, data90);
			byte[] data91 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215176932U, data91);
			byte[] data92 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215176949U, data92);
			byte[] data93 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215176967U, data93);
			byte[] data94 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215176985U, data94);
			byte[] data95 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177110U, data95);
			this.ixboxConsole_0.SetMemory(2215177115U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data96 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177128U, data96);
			this.ixboxConsole_0.SetMemory(2215177133U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data97 = new byte[]
			{
				byte.MaxValue,
				15
			};
			this.ixboxConsole_0.SetMemory(2215177146U, data97);
			this.ixboxConsole_0.SetMemory(2215177151U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data98 = new byte[]
			{
				byte.MaxValue,
				1
			};
			this.ixboxConsole_0.SetMemory(2215177170U, data98);
			this.ixboxConsole_0.SetMemory(2215177168U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data99 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177182U, data99);
			byte[] data100 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177200U, data100);
			this.ixboxConsole_0.SetMemory(2215177204U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data101 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177212U, data101);
			byte[] data102 = new byte[]
			{
				byte.MaxValue,
				1
			};
			this.ixboxConsole_0.SetMemory(2215177218U, data102);
			this.ixboxConsole_0.SetMemory(2215177222U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data103 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177230U, data103);
			byte[] data104 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177235U, data104);
			this.ixboxConsole_0.SetMemory(2215177240U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data105 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177253U, data105);
			this.ixboxConsole_0.SetMemory(2215177258U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data106 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177361U, data106);
			this.ixboxConsole_0.SetMemory(2215177365U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			this.ixboxConsole_0.SetMemory(2215177378U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			this.ixboxConsole_0.SetMemory(2215177383U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data107 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177396U, data107);
			this.ixboxConsole_0.SetMemory(2215177401U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data108 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177414U, data108);
			this.ixboxConsole_0.SetMemory(2215177419U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data109 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177432U, data109);
			this.ixboxConsole_0.SetMemory(2215177437U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data110 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177450U, data110);
			this.ixboxConsole_0.SetMemory(2215177454U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data111 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177468U, data111);
			this.ixboxConsole_0.SetMemory(2215177472U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data112 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177480U, data112);
			byte[] data113 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177486U, data113);
			byte[] data114 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177480U, data114);
			this.ixboxConsole_0.SetMemory(2215177490U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data115 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177504U, data115);
			this.ixboxConsole_0.SetMemory(2215177508U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			this.ixboxConsole_0.SetMemory(2215177521U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			this.ixboxConsole_0.SetMemory(2215177526U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data116 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177557U, data116);
			this.ixboxConsole_0.SetMemory(2215177562U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data117 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177575U, data117);
			this.ixboxConsole_0.SetMemory(2215177580U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data118 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177593U, data118);
			this.ixboxConsole_0.SetMemory(2215177597U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data119 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177611U, data119);
			this.ixboxConsole_0.SetMemory(2215177615U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data120 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177647U, data120);
			this.ixboxConsole_0.SetMemory(2215177651U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data121 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177659U, data121);
			byte[] data122 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177664U, data122);
			this.ixboxConsole_0.SetMemory(2215177669U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data123 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177677U, data123);
			byte[] data124 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177682U, data124);
			this.ixboxConsole_0.SetMemory(2215177687U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data125 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177694U, data125);
			byte[] data126 = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177700U, data126);
			this.ixboxConsole_0.SetMemory(2215177704U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data127 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177712U, data127);
			byte[] data128 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177736U, data128);
			this.ixboxConsole_0.SetMemory(2215177740U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data129 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177748U, data129);
			byte[] data130 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177754U, data130);
			this.ixboxConsole_0.SetMemory(2215177758U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data131 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177766U, data131);
			this.ixboxConsole_0.SetMemory(2215177776U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data132 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177784U, data132);
			byte[] data133 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177790U, data133);
			this.ixboxConsole_0.SetMemory(2215177794U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			byte[] data134 = new byte[]
			{
				byte.MaxValue
			};
			this.ixboxConsole_0.SetMemory(2215177802U, data134);
			this.ixboxConsole_0.XNotify("Unlock All Given!");
		}

		// Token: 0x0600038D RID: 909 RVA: 0x000358C4 File Offset: 0x00033AC4
		private void simpleButton652_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown114.Text));
			this.ixboxConsole_0.SetMemory(2199522772U, bytes);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000358FC File Offset: 0x00033AFC
		private void simpleButton654_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown115.Text));
			this.ixboxConsole_0.SetMemory(2199522764U, bytes);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00035934 File Offset: 0x00033B34
		private void simpleButton650_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown112.Text));
			this.ixboxConsole_0.SetMemory(2199522780U, bytes);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0003596C File Offset: 0x00033B6C
		private void simpleButton651_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown113.Text));
			this.ixboxConsole_0.SetMemory(2199522784U, bytes);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x000359A4 File Offset: 0x00033BA4
		private void simpleButton648_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown110.Text));
			this.ixboxConsole_0.SetMemory(2199522792U, bytes);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000359DC File Offset: 0x00033BDC
		private void simpleButton640_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown86.Text));
			this.ixboxConsole_0.SetMemory(2199522800U, bytes);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00035A14 File Offset: 0x00033C14
		private void simpleButton638_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown70.Text));
			this.ixboxConsole_0.SetMemory(2199522788U, bytes);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00035A4C File Offset: 0x00033C4C
		private void simpleButton646_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown108.Text));
			this.ixboxConsole_0.SetMemory(2199522836U, bytes);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00035A84 File Offset: 0x00033C84
		private void simpleButton647_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown109.Text));
			this.ixboxConsole_0.SetMemory(2199522840U, bytes);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00035ABC File Offset: 0x00033CBC
		private void simpleButton644_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown106.Text));
			this.ixboxConsole_0.SetMemory(2199522848U, bytes);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00035AF4 File Offset: 0x00033CF4
		private void simpleButton645_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown107.Text));
			this.ixboxConsole_0.SetMemory(2199522844U, bytes);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00035B2C File Offset: 0x00033D2C
		private void simpleButton642_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown104.Text));
			this.ixboxConsole_0.SetMemory(2199522860U, bytes);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00035B64 File Offset: 0x00033D64
		private void simpleButton643_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown105.Text));
			this.ixboxConsole_0.SetMemory(2199522864U, bytes);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00035B9C File Offset: 0x00033D9C
		private void simpleButton655_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				"defaultStatsInit;updategamerprofile;uploadstats"
			});
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00035BD0 File Offset: 0x00033DD0
		private void simpleButton653_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown105.Text));
			this.ixboxConsole_0.SetMemory(2199522864U, bytes);
			byte[] bytes2 = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown104.Text));
			this.ixboxConsole_0.SetMemory(2199522860U, bytes2);
			byte[] bytes3 = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown107.Text));
			this.ixboxConsole_0.SetMemory(2199522844U, bytes3);
			byte[] bytes4 = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown106.Text));
			this.ixboxConsole_0.SetMemory(2199522848U, bytes4);
			byte[] bytes5 = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown109.Text));
			this.ixboxConsole_0.SetMemory(2199522840U, bytes5);
			byte[] bytes6 = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown108.Text));
			this.ixboxConsole_0.SetMemory(2199522836U, bytes6);
			byte[] bytes7 = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown86.Text));
			this.ixboxConsole_0.SetMemory(2199522800U, bytes7);
			byte[] bytes8 = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown110.Text));
			this.ixboxConsole_0.SetMemory(2199522792U, bytes8);
			byte[] bytes9 = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown113.Text));
			this.ixboxConsole_0.SetMemory(2199522784U, bytes9);
			byte[] bytes10 = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown112.Text));
			this.ixboxConsole_0.SetMemory(2199522780U, bytes10);
			byte[] bytes11 = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown115.Text));
			this.ixboxConsole_0.SetMemory(2199522764U, bytes11);
			byte[] bytes12 = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown114.Text));
			this.ixboxConsole_0.SetMemory(2199522772U, bytes12);
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				"updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.XNotify("Set All Stats!");
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00035E00 File Offset: 0x00034000
		private void simpleButton656_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2199524352U, new byte[]
			{
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				5,
				4,
				9,
				9,
				2,
				2,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				9,
				9,
				2,
				2,
				2,
				2,
				2,
				9,
				9,
				9,
				9,
				9,
				9,
				9,
				9,
				9,
				9,
				9,
				9,
				9,
				9,
				9,
				9,
				6,
				9,
				6,
				9,
				9,
				9,
				9,
				9,
				7,
				9,
				7,
				9,
				9,
				9,
				9,
				9,
				9,
				7,
				7,
				7,
				7,
				7,
				7,
				7,
				7,
				7,
				7,
				7,
				7,
				7,
				7,
				7,
				7,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				2,
				2,
				2,
				2,
				2,
				5,
				5,
				5,
				5,
				5,
				5,
				5,
				5,
				5,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				4,
				2,
				2,
				2,
				2,
				4,
				3,
				3,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				4,
				4,
				4,
				4,
				4,
				4,
				2,
				2,
				4,
				4,
				4,
				2,
				2,
				2,
				2,
				4,
				4,
				4,
				4,
				4,
				4,
				4,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				3,
				3,
				2,
				2,
				2,
				3,
				3,
				2,
				3,
				2,
				2,
				2,
				2,
				2,
				2,
				4,
				2,
				2,
				4,
				4,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				2,
				4,
				2,
				4,
				4,
				4,
				2,
				4,
				4,
				2,
				2,
				3,
				3,
				3,
				2,
				3,
				5,
				5,
				5,
				5,
				5,
				2,
				2,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				196,
				9,
				0,
				0,
				232,
				3,
				0,
				0,
				136,
				19,
				0,
				0,
				232,
				3,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				20,
				0,
				0,
				0,
				60,
				0,
				0,
				0,
				15,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				20,
				0,
				0,
				0,
				60,
				0,
				0,
				0,
				15,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				20,
				0,
				0,
				0,
				60,
				0,
				0,
				0,
				15,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				20,
				0,
				0,
				0,
				60,
				0,
				0,
				0,
				15,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				20,
				0,
				0,
				0,
				60,
				0,
				0,
				0,
				15,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				60,
				0,
				0,
				0,
				15,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				9,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				20,
				0,
				0,
				0,
				60,
				0,
				0,
				0,
				15,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				20,
				0,
				0,
				0,
				60,
				0,
				0,
				0,
				15,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				20,
				0,
				0,
				0,
				60,
				0,
				0,
				0,
				15,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				20,
				0,
				0,
				0,
				60,
				0,
				0,
				0,
				15,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				15,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				6,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				15,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				6,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				15,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				6,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				30,
				0,
				0,
				0,
				60,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				9,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				30,
				0,
				0,
				0,
				60,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				9,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				30,
				0,
				0,
				0,
				60,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				9,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				30,
				0,
				0,
				0,
				60,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				9,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				30,
				0,
				0,
				0,
				60,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				9,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				15,
				0,
				0,
				0,
				60,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				9,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				15,
				0,
				0,
				0,
				60,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				9,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				15,
				0,
				0,
				0,
				60,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				9,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				15,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				6,
				0,
				0,
				0,
				244,
				1,
				0,
				0,
				232,
				3,
				0,
				0,
				15,
				0,
				0,
				0,
				60,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				9,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				196,
				9,
				0,
				0,
				244,
				1,
				0,
				0,
				196,
				9,
				0,
				0,
				244,
				1,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				232,
				3,
				0,
				0,
				244,
				1,
				0,
				0,
				196,
				9,
				0,
				0,
				244,
				1,
				0,
				0,
				196,
				9,
				0,
				0,
				244,
				1,
				0,
				0,
				176,
				4,
				0,
				0,
				176,
				4,
				0,
				0,
				176,
				4,
				0,
				0,
				176,
				4,
				0,
				0,
				250,
				0,
				0,
				0,
				0,
				97,
				8,
				0,
				244,
				1,
				0,
				0,
				250,
				0,
				0,
				0,
				250,
				0,
				0,
				0,
				238,
				2,
				0,
				0,
				132,
				3,
				0,
				0,
				232,
				3,
				0,
				0,
				250,
				0,
				0,
				0,
				238,
				2,
				0,
				0,
				250,
				0,
				0,
				0,
				100,
				0,
				0,
				0,
				244,
				1,
				0,
				0,
				100,
				0,
				0,
				0,
				238,
				2,
				0,
				0,
				64,
				36,
				20,
				0,
				244,
				1,
				0,
				0,
				50,
				0,
				0,
				0,
				50,
				0,
				0,
				0,
				50,
				0,
				0,
				0,
				50,
				0,
				0,
				0,
				50,
				0,
				0,
				0,
				50,
				0,
				0,
				0,
				50,
				0,
				0,
				0,
				50,
				0,
				0,
				0,
				25,
				0,
				0,
				0,
				25,
				0,
				0,
				0,
				25,
				0,
				0,
				0,
				25,
				0,
				0,
				0,
				25,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				232,
				3,
				0,
				0,
				232,
				3,
				0,
				0,
				232,
				3,
				0,
				0,
				50,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				50,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				50,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				25,
				0,
				0,
				0,
				25,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				232,
				3,
				0,
				0,
				232,
				3,
				0,
				0,
				232,
				3,
				0,
				0,
				232,
				3,
				0,
				0,
				232,
				3,
				0,
				0,
				232,
				3,
				0,
				0,
				232,
				3,
				0,
				0,
				232,
				3,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				200,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				15,
				0,
				0,
				0,
				15,
				0,
				0,
				0,
				15,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				80,
				195,
				0,
				0,
				80,
				195,
				0,
				0,
				100,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				50,
				0,
				0,
				0,
				50,
				0,
				0,
				0,
				50,
				0,
				0,
				0,
				50,
				0,
				0,
				0,
				50,
				0,
				0,
				0,
				50,
				0,
				0,
				0,
				50,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				25,
				0,
				0,
				0,
				25,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				25,
				0,
				0,
				0,
				25,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				25,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				200,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				15,
				0,
				0,
				0,
				50,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				250,
				0,
				0,
				0,
				100,
				0,
				0,
				0,
				232,
				3,
				0,
				0,
				44,
				1,
				0,
				0,
				44,
				1,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				16,
				0,
				23,
				0,
				8,
				0,
				0,
				0,
				130,
				3,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				254,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				126,
				191,
				byte.MaxValue,
				219,
				24,
				byte.MaxValue,
				40,
				203,
				223,
				203,
				125,
				126,
				252,
				30,
				103,
				0,
				254,
				231,
				202,
				49,
				113,
				byte.MaxValue,
				191,
				246,
				60,
				239,
				17,
				15,
				128,
				237,
				59,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				46,
				byte.MaxValue,
				223,
				108,
				119,
				254,
				254,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				239,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				127,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				239,
				238,
				254,
				31,
				238,
				87,
				165,
				10,
				0,
				0,
				0,
				254,
				125,
				byte.MaxValue,
				221,
				223,
				byte.MaxValue,
				127,
				byte.MaxValue,
				251,
				byte.MaxValue,
				237,
				191,
				223,
				byte.MaxValue,
				byte.MaxValue,
				223,
				byte.MaxValue,
				249,
				byte.MaxValue,
				223,
				237,
				byte.MaxValue,
				253,
				119,
				1,
				192,
				byte.MaxValue,
				223,
				byte.MaxValue,
				190,
				byte.MaxValue,
				63,
				240,
				byte.MaxValue,
				111,
				235,
				7,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				15,
				250,
				byte.MaxValue,
				127,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				254,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				191,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				7,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				122,
				77,
				153,
				3,
				0
			});
			this.ixboxConsole_0.XNotify("Unlock All Given!");
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00035E44 File Offset: 0x00034044
		private void simpleButton630_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[2];
			array[0] = 248;
			this.ixboxConsole_0.SetMemory(2218080848U, array);
			byte[] array2 = new byte[2];
			array2[0] = 124;
			this.ixboxConsole_0.SetMemory(2218080862U, array2);
			byte[] array3 = new byte[2];
			array3[0] = 15;
			this.ixboxConsole_0.SetMemory(2218080901U, array3);
			this.ixboxConsole_0.SetMemory(2218080914U, new byte[]
			{
				192,
				7
			});
			byte[] array4 = new byte[2];
			array4[0] = 248;
			this.ixboxConsole_0.SetMemory(2218080953U, array4);
			byte[] array5 = new byte[2];
			array5[0] = 124;
			this.ixboxConsole_0.SetMemory(2218080967U, array5);
			this.ixboxConsole_0.SetMemory(2218081006U, new byte[]
			{
				15,
				byte.MaxValue
			});
			this.ixboxConsole_0.SetMemory(2218081019U, new byte[]
			{
				192,
				7
			});
			byte[] array6 = new byte[2];
			array6[0] = 248;
			this.ixboxConsole_0.SetMemory(2218081058U, array6);
			byte[] array7 = new byte[2];
			array7[0] = 124;
			this.ixboxConsole_0.SetMemory(2218081072U, array7);
			byte[] array8 = new byte[2];
			array8[0] = 15;
			this.ixboxConsole_0.SetMemory(2218081111U, array8);
			this.ixboxConsole_0.SetMemory(2218081124U, new byte[]
			{
				192,
				7
			});
			byte[] array9 = new byte[2];
			array9[0] = 248;
			this.ixboxConsole_0.SetMemory(2218081163U, array9);
			byte[] array10 = new byte[2];
			array10[0] = 124;
			this.ixboxConsole_0.SetMemory(2218081177U, array10);
			byte[] array11 = new byte[2];
			array11[0] = 15;
			this.ixboxConsole_0.SetMemory(2218081216U, array11);
			this.ixboxConsole_0.SetMemory(2218081229U, new byte[]
			{
				192,
				7
			});
			byte[] array12 = new byte[2];
			array12[0] = 248;
			this.ixboxConsole_0.SetMemory(2218081268U, array12);
			byte[] array13 = new byte[2];
			array13[0] = 124;
			this.ixboxConsole_0.SetMemory(2218081282U, array13);
			byte[] array14 = new byte[2];
			array14[0] = 15;
			this.ixboxConsole_0.SetMemory(2218081321U, array14);
			this.ixboxConsole_0.SetMemory(2218081334U, new byte[]
			{
				192,
				7
			});
			this.ixboxConsole_0.XNotify("CE Digital Camo Applied To All Classes!");
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00036100 File Offset: 0x00034300
		private void method_78(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1041378984119775312/CleanUnlockAll.bin", "./UnlockAll.bin");
			this.ixboxConsole_0.SetMemory(2218045312U, File.ReadAllBytes("UnlockAll.bin"));
			File.Delete("UnlockAll.bin");
			this.ixboxConsole_0.XNotify("Unlock All Given!");
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0003615C File Offset: 0x0003435C
		private void simpleButton632_Click(object sender, EventArgs e)
		{
			byte[] data = new byte[1];
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(2215139962U, 1U, data, out num);
			this.ixboxConsole_0.XNotify("Godmode Class Applied To Class 4!");
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0003619C File Offset: 0x0003439C
		private void simpleButton633_Click(object sender, EventArgs e)
		{
			byte[] data = new byte[]
			{
				22,
				2,
				0,
				16,
				166,
				1,
				0,
				0,
				0,
				16,
				240,
				3,
				54,
				2,
				0,
				0,
				0,
				198,
				1
			};
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(2215139999U, 19U, data, out num);
			this.ixboxConsole_0.XNotify("Overkill Class Applied To Class 5!");
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x000361E8 File Offset: 0x000343E8
		public void simpleButton189_Click(object sender, EventArgs e)
		{
			this.listBox7.Items.Clear();
			File.AppendAllText("GameNames.txt", "");
			ListBox.ObjectCollection items = this.listBox7.Items;
			object[] items2 = File.ReadAllLines("GameNames.txt");
			items.AddRange(items2);
			foreach (string text in this.ixboxConsole_0.Drives.Split(new char[]
			{
				",".Last<char>()
			}))
			{
				if (text.Contains("DVD"))
				{
					this.listBox7.Items.Add("Launch Game From Disc");
				}
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00036298 File Offset: 0x00034498
		private void method_79(object sender, EventArgs e)
		{
			byte[] array = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			};
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(2203614128U, (uint)array.Length, array, out num);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x000362DC File Offset: 0x000344DC
		private void simpleButton196_Click(object sender, EventArgs e)
		{
			this.method_31();
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x000362F0 File Offset: 0x000344F0
		private void simpleButton193_Click(object sender, EventArgs e)
		{
			this.method_30();
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00036304 File Offset: 0x00034504
		private void simpleButton243_Click(object sender, EventArgs e)
		{
			this.method_32();
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00036318 File Offset: 0x00034518
		private void simpleButton244_Click(object sender, EventArgs e)
		{
			this.method_33();
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0003632C File Offset: 0x0003452C
		private void simpleButton245_Click(object sender, EventArgs e)
		{
			this.method_34();
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00036340 File Offset: 0x00034540
		private void simpleButton246_Click(object sender, EventArgs e)
		{
			this.method_35();
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00036354 File Offset: 0x00034554
		private void simpleButton254_Click(object sender, EventArgs e)
		{
			this.method_44();
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00036368 File Offset: 0x00034568
		private void simpleButton255_Click(object sender, EventArgs e)
		{
			this.method_45();
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0003637C File Offset: 0x0003457C
		private void simpleButton257_Click(object sender, EventArgs e)
		{
			this.method_46();
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00036390 File Offset: 0x00034590
		private void simpleButton259_Click(object sender, EventArgs e)
		{
			this.method_48();
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000363A4 File Offset: 0x000345A4
		private void simpleButton251_Click(object sender, EventArgs e)
		{
			this.method_36();
		}

		// Token: 0x060003AE RID: 942 RVA: 0x000363B8 File Offset: 0x000345B8
		private void simpleButton252_Click(object sender, EventArgs e)
		{
			this.method_37();
		}

		// Token: 0x060003AF RID: 943 RVA: 0x000363CC File Offset: 0x000345CC
		private void simpleButton249_Click(object sender, EventArgs e)
		{
			this.method_38();
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000363E0 File Offset: 0x000345E0
		private void simpleButton250_Click(object sender, EventArgs e)
		{
			this.method_39();
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x000363F4 File Offset: 0x000345F4
		private void simpleButton247_Click(object sender, EventArgs e)
		{
			this.method_41();
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00036408 File Offset: 0x00034608
		private void simpleButton248_Click(object sender, EventArgs e)
		{
			this.method_42();
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0003641C File Offset: 0x0003461C
		private void simpleButton253_Click(object sender, EventArgs e)
		{
			this.method_43();
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00036430 File Offset: 0x00034630
		private void simpleButton256_Click(object sender, EventArgs e)
		{
			this.Tokens();
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00036444 File Offset: 0x00034644
		private void simpleButton258_Click(object sender, EventArgs e)
		{
			this.method_47();
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00036458 File Offset: 0x00034658
		private void simpleButton659_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes((uint)this.numericUpDown121.Value);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(2203617268U, 4U, bytes, out num);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00036498 File Offset: 0x00034698
		private void simpleButton661_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes((uint)this.numericUpDown122.Value);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(2203616508U, 4U, bytes, out num);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x000364D8 File Offset: 0x000346D8
		private void simpleButton657_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes((uint)this.numericUpDown119.Value);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(2203597178U, 4U, bytes, out num);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00036518 File Offset: 0x00034718
		private void simpleButton658_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes((uint)this.numericUpDown120.Value);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(2203597137U, 4U, bytes, out num);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00036558 File Offset: 0x00034758
		private void simpleButton649_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes((uint)this.numericUpDown118.Value);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(2203597097U, 4U, bytes, out num);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00036598 File Offset: 0x00034798
		private void simpleButton627_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes((uint)this.numericUpDown67.Value);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(2203597141U, 4U, bytes, out num);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x000365D8 File Offset: 0x000347D8
		private void simpleButton639_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes((uint)this.numericUpDown116.Value);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(2203597218U, 4U, bytes, out num);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00036618 File Offset: 0x00034818
		private void simpleButton641_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes((uint)this.numericUpDown117.Value);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(2203597145U, 4U, bytes, out num);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00036658 File Offset: 0x00034858
		private void simpleButton631_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes((uint)this.numericUpDown69.Value);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(2203597129U, 4U, bytes, out num);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00036698 File Offset: 0x00034898
		private void simpleButton635_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes((uint)this.numericUpDown71.Value);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(2203597150U, 4U, bytes, out num);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000366D8 File Offset: 0x000348D8
		private void simpleButton194_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185545528U, new object[]
			{
				0,
				"defaultStatsInit;updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.XNotify("Reset Stats!");
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0003671C File Offset: 0x0003491C
		private void simpleButton190_Click(object sender, EventArgs e)
		{
			for (uint num = 0U; num < 10U; num += 1U)
			{
				this.ixboxConsole_0.SetMemory(2203597004U + num * 1380U + 4072U, new byte[]
				{
					byte.MaxValue
				});
			}
			this.ixboxConsole_0.XNotify("All Squad Members Maxed Out!");
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0003677C File Offset: 0x0003497C
		private void simpleButton660_Click(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes((uint)this.numericUpDown121.Value);
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(2203617268U, 4U, bytes, out num);
			byte[] bytes2 = BitConverter.GetBytes((uint)this.numericUpDown122.Value);
			this.ixboxConsole_0.DebugTarget.SetMemory(2203616508U, 4U, bytes2, out num);
			byte[] bytes3 = BitConverter.GetBytes((uint)this.numericUpDown119.Value);
			this.ixboxConsole_0.DebugTarget.SetMemory(2203597178U, 4U, bytes3, out num);
			byte[] bytes4 = BitConverter.GetBytes((uint)this.numericUpDown120.Value);
			this.ixboxConsole_0.DebugTarget.SetMemory(2203597137U, 4U, bytes4, out num);
			byte[] bytes5 = BitConverter.GetBytes((uint)this.numericUpDown118.Value);
			this.ixboxConsole_0.DebugTarget.SetMemory(2203597097U, 4U, bytes5, out num);
			byte[] bytes6 = BitConverter.GetBytes((uint)this.numericUpDown67.Value);
			this.ixboxConsole_0.DebugTarget.SetMemory(2203597141U, 4U, bytes6, out num);
			byte[] bytes7 = BitConverter.GetBytes((uint)this.numericUpDown116.Value);
			this.ixboxConsole_0.DebugTarget.SetMemory(2203597218U, 4U, bytes7, out num);
			byte[] bytes8 = BitConverter.GetBytes((uint)this.numericUpDown117.Value);
			this.ixboxConsole_0.DebugTarget.SetMemory(2203597145U, 4U, bytes8, out num);
			byte[] bytes9 = BitConverter.GetBytes((uint)this.numericUpDown69.Value);
			this.ixboxConsole_0.DebugTarget.SetMemory(2203597129U, 4U, bytes9, out num);
			byte[] bytes10 = BitConverter.GetBytes((uint)this.numericUpDown71.Value);
			this.ixboxConsole_0.DebugTarget.SetMemory(2203597150U, 4U, bytes10, out num);
			this.ixboxConsole_0.XNotify("Set All Stats!");
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0002BF80 File Offset: 0x0002A180
		private uint method_80(uint uint_0)
		{
			return 2200967552U + uint_0 * 14080U;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00036984 File Offset: 0x00034B84
		public string GetGamertagGHOSTSEXT(uint cli)
		{
			byte[] array = new byte[20];
			uint num;
			this.ixboxConsole_0.DebugTarget.GetMemory(this.method_80(cli) + 12316U, 20U, array, out num);
			this.ixboxConsole_0.DebugTarget.InvalidateMemoryCache(true, this.method_80(cli) + 12316U, 20U);
			return this.ByteToString(array);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000369EC File Offset: 0x00034BEC
		public string ByteToString(byte[] input)
		{
			UTF8Encoding utf8Encoding = new UTF8Encoding();
			return utf8Encoding.GetString(input);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00036A0C File Offset: 0x00034C0C
		private void simpleButton663_Click(object sender, EventArgs e)
		{
			this.listBox8.Items.Clear();
			for (int i = 0; i < 4; i++)
			{
				this.listBox8.Items.Add(Convert.ToString(i) + "= " + this.GetGamertagGHOSTSEXT(Convert.ToUInt32(i)));
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00036A6C File Offset: 0x00034C6C
		private void simpleButton662_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.WriteInt32(this.method_80(Convert.ToUInt32(this.listBox8.SelectedIndex)) + 7U, 2);
			this.ixboxConsole_0.WriteInt32(this.method_80(Convert.ToUInt32(this.listBox8.SelectedIndex)) + 14U, 20);
			this.ixboxConsole_0.WriteInt32(this.method_80(Convert.ToUInt32(this.listBox8.SelectedIndex)) + 13084U, 3);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00036AEC File Offset: 0x00034CEC
		private void simpleButton637_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.WriteInt32(this.method_80(Convert.ToUInt32(this.listBox8.SelectedIndex)) + 13084U, 0);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0002C208 File Offset: 0x0002A408
		private uint method_81(uint uint_0)
		{
			return 2201466496U + uint_0 * 640U;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00036B24 File Offset: 0x00034D24
		private void simpleButton664_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.WriteInt32(this.method_81(Convert.ToUInt32(this.listBox8.SelectedIndex)) + 396U, 1);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00036B5C File Offset: 0x00034D5C
		private void simpleButton636_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.WriteInt32(this.method_81(Convert.ToUInt32(this.listBox8.SelectedIndex)) + 396U, 0);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00036B94 File Offset: 0x00034D94
		private void simpleButton628_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[4];
			array[0] = 96;
			this.ixboxConsole_0.SetMemory(2183431696U, array);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00036BC4 File Offset: 0x00034DC4
		private void simpleButton192_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2183431696U, new byte[]
			{
				125,
				75,
				24,
				46
			});
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00036BF4 File Offset: 0x00034DF4
		private void simpleButton669_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[4];
			array[0] = 96;
			this.ixboxConsole_0.SetMemory(2183582388U, array);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00036C24 File Offset: 0x00034E24
		private void simpleButton668_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2183582388U, new byte[]
			{
				65,
				154,
				0,
				12
			});
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00036C54 File Offset: 0x00034E54
		private void simpleButton667_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[4];
			array[0] = 96;
			this.ixboxConsole_0.SetMemory(2183959364U, array);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00036C84 File Offset: 0x00034E84
		private void simpleButton666_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2183959364U, new byte[]
			{
				75,
				248,
				174,
				149
			});
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00036CB4 File Offset: 0x00034EB4
		private void simpleButton671_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2183655832U, new byte[]
			{
				56,
				96,
				0,
				1
			});
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00036CE4 File Offset: 0x00034EE4
		private void simpleButton670_Click(object sender, EventArgs e)
		{
			byte[] array = new byte[4];
			array[0] = 56;
			array[1] = 96;
			this.ixboxConsole_0.SetMemory(2183655832U, array);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x000077B0 File Offset: 0x000059B0
		private void method_82(object sender, EventArgs e)
		{
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00036D18 File Offset: 0x00034F18
		private void simpleButton665_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.XNotify(this.textEdit_0.Text + "\nH̶͕̤҇͌́͜a̴̭̞͗͋͌̒͛͢͡ç̴̫̖̗̣͐̐̀̋̎̕ḳ̶̢̞̭̭͕͕̔͂̋̅͌̉͛̂͡\nH̶͕̤҇͌́͜a̴̭̞͗͋͌̒͛͢͡ç̴̫̖̗̣͐̐̀̋̎̕ḳ̶̢̞̭̭͕͕̔͂̋̅͌̉͛̂͡");
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00036D48 File Offset: 0x00034F48
		private void simpleButton673_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				string.Concat(new string[]
				{
					"setviewpos ",
					this.textEdit_140.Text,
					" ",
					this.textEdit_142.Text,
					" ",
					this.textEdit_141.Text
				})
			});
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00036DC4 File Offset: 0x00034FC4
		private void simpleButton672_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				string.Concat(new string[]
				{
					"setviewpos ",
					this.textEdit_145.Text,
					" ",
					this.textEdit_144.Text,
					" ",
					this.textEdit_143.Text
				})
			});
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00036E40 File Offset: 0x00035040
		private void simpleButton682_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "gsc files (*.gsc)|*.gsc";
			openFileDialog.FileName = Path.GetFileName(openFileDialog.FileName);
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.textEdit_146.Text = openFileDialog.FileName;
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00036E94 File Offset: 0x00035094
		private void simpleButton674_Click(object sender, EventArgs e)
		{
			if (!this.textEdit_146.Text.Contains(".gsc"))
			{
				XtraMessageBox.Show("No GSC has been selected yet, do that first.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.simpleButton682_Click(sender, null);
			}
			else
			{
				byte[] array = File.ReadAllBytes(this.textEdit_146.Text);
				this.ixboxConsole_0.SetMemory(2199829632U, BitConverter.GetBytes(1076887552).Reverse<byte>().ToArray<byte>());
				this.ixboxConsole_0.SetMemory(1076887552U, new byte[array.Length + 1]);
				this.ixboxConsole_0.SetMemory(1076887552U, array);
				this.ixboxConsole_0.XNotify("Succesfully Injected GSC Menu!");
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00036F4C File Offset: 0x0003514C
		private void simpleButton675_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			if (this.comboBoxEdit21.SelectedIndex == 0)
			{
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1042078931173523466/development_dvars.gsc", "_development_dvars.gsc");
				byte[] array = File.ReadAllBytes("./_development_dvars.gsc");
				this.ixboxConsole_0.SetMemory(2199829632U, BitConverter.GetBytes(1076887552).Reverse<byte>().ToArray<byte>());
				this.ixboxConsole_0.SetMemory(1076887552U, new byte[array.Length + 1]);
				this.ixboxConsole_0.SetMemory(1076887552U, array);
				this.ixboxConsole_0.XNotify("Succesfully Injected Batman V17 GSC Menu!");
				File.Delete("_development_dvars.gsc");
			}
			if (this.comboBoxEdit21.SelectedIndex == 1)
			{
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1042078498740768768/clientids.gsc", "_clientids.gsc");
				byte[] array2 = File.ReadAllBytes("./_clientids.gsc");
				this.ixboxConsole_0.SetMemory(2199829632U, BitConverter.GetBytes(1076887552).Reverse<byte>().ToArray<byte>());
				this.ixboxConsole_0.SetMemory(1076887552U, new byte[array2.Length + 1]);
				this.ixboxConsole_0.SetMemory(1076887552U, array2);
				this.ixboxConsole_0.XNotify("Succesfully Injected Bossam V6 GSC Menu!");
				File.Delete("_clientids.gsc");
			}
			if (this.comboBoxEdit21.SelectedIndex == 2)
			{
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1042082172263223356/clientids.gsc", "_clientids.gsc");
				byte[] array3 = File.ReadAllBytes("./_clientids.gsc");
				this.ixboxConsole_0.SetMemory(2199829632U, BitConverter.GetBytes(1076887552).Reverse<byte>().ToArray<byte>());
				this.ixboxConsole_0.SetMemory(1076887552U, new byte[array3.Length + 1]);
				this.ixboxConsole_0.SetMemory(1076887552U, array3);
				this.ixboxConsole_0.XNotify("Succesfully Injected Elegance V5 GSC Menu!");
				File.Delete("_clientids.gsc");
			}
			if (this.comboBoxEdit21.SelectedIndex == 3)
			{
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1082034925181612093/rank.gsc", "_rank.gsc");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1082034924128837652/sticky_grenade.gsc", "_sticky_grenade.gsc");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1082034924451803198/ambientpackage.gsc", "_ambientpackage.gsc");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1082034924799938610/development_dvars.gsc", "_development_dvars.gsc");
				uint uintfromd = this.GETUINTFROMD(1076887553U);
				byte[] array4 = File.ReadAllBytes("./_ambientpackage.gsc");
				this.ixboxConsole_0.SetMemory(2199829440U, BitConverter.GetBytes(uintfromd).Reverse<byte>().ToArray<byte>());
				this.ixboxConsole_0.SetMemory(uintfromd, new byte[array4.Length + 1]);
				this.ixboxConsole_0.SetMemory(uintfromd, array4);
				uint uintfromd2 = this.GETUINTFROMD(uintfromd + (uint)(array4.Length + 1) + 1U);
				byte[] array5 = File.ReadAllBytes("./_development_dvars.gsc");
				this.ixboxConsole_0.SetMemory(2199829632U, BitConverter.GetBytes(uintfromd2).Reverse<byte>().ToArray<byte>());
				this.ixboxConsole_0.SetMemory(uintfromd2, new byte[array5.Length + 1]);
				this.ixboxConsole_0.SetMemory(uintfromd2, array5);
				uint uintfromd3 = this.GETUINTFROMD(uintfromd2 + (uint)(array5.Length + 1) + 1U);
				byte[] array6 = File.ReadAllBytes("./_sticky_grenade.gsc");
				this.ixboxConsole_0.SetMemory(2199829980U, BitConverter.GetBytes(uintfromd3).Reverse<byte>().ToArray<byte>());
				this.ixboxConsole_0.SetMemory(uintfromd3, new byte[array6.Length + 1]);
				this.ixboxConsole_0.SetMemory(uintfromd3, array6);
				uint uintfromd4 = this.GETUINTFROMD(uintfromd3 + (uint)(array6.Length + 1) + 1U);
				byte[] array7 = File.ReadAllBytes("./_rank.gsc");
				this.ixboxConsole_0.SetMemory(2199830484U, BitConverter.GetBytes(uintfromd4).Reverse<byte>().ToArray<byte>());
				this.ixboxConsole_0.SetMemory(uintfromd4, new byte[array7.Length + 1]);
				this.ixboxConsole_0.SetMemory(uintfromd4, array7);
				this.ixboxConsole_0.XNotify("Succesfully Injected Jiggy V4.5 GSC Menu!");
				File.Delete("_rank.gsc");
				File.Delete("_ambientpackage.gsc");
				File.Delete("_sticky_grenade.gsc");
				File.Delete("_development_dvars.gsc");
			}
			if (this.comboBoxEdit21.SelectedIndex == 4)
			{
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1082032695695122542/explosive_bolt.gsc", "_explosive_bolt.gsc");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1082032696047448264/globalentities.gsc", "_globalentities.gsc");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1082032696567533618/rank.gsc", "_rank.gsc");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1082032696932442143/shellshock.gsc", "_shellshock.gsc");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1082032697217658880/sticky_grenade.gsc", "_sticky_grenade.gsc");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1082032697481891970/acousticsensor.gsc", "_acousticsensor.gsc");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1082032697788084294/ambientpackage.gsc", "_ambientpackage.gsc");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1082032698077483159/development_dvars.gsc", "_development_dvars.gsc");
				uint uintfromd5 = this.GETUINTFROMD(1076887553U);
				byte[] array8 = File.ReadAllBytes("./_ambientpackage.gsc");
				this.ixboxConsole_0.SetMemory(2199829440U, BitConverter.GetBytes(uintfromd5).Reverse<byte>().ToArray<byte>());
				this.ixboxConsole_0.SetMemory(uintfromd5, new byte[array8.Length + 1]);
				this.ixboxConsole_0.SetMemory(uintfromd5, array8);
				uint uintfromd6 = this.GETUINTFROMD(uintfromd5 + (uint)(array8.Length + 1) + 1U);
				byte[] array9 = File.ReadAllBytes("./_development_dvars.gsc");
				this.ixboxConsole_0.SetMemory(2199829632U, BitConverter.GetBytes(uintfromd6).Reverse<byte>().ToArray<byte>());
				this.ixboxConsole_0.SetMemory(uintfromd6, new byte[array9.Length + 1]);
				this.ixboxConsole_0.SetMemory(uintfromd6, array9);
				uint uintfromd7 = this.GETUINTFROMD(uintfromd6 + (uint)(array9.Length + 1) + 1U);
				byte[] array10 = File.ReadAllBytes("./_sticky_grenade.gsc");
				this.ixboxConsole_0.SetMemory(2199829980U, BitConverter.GetBytes(uintfromd7).Reverse<byte>().ToArray<byte>());
				this.ixboxConsole_0.SetMemory(uintfromd7, new byte[array10.Length + 1]);
				this.ixboxConsole_0.SetMemory(uintfromd7, array10);
				uint uintfromd8 = this.GETUINTFROMD(uintfromd7 + (uint)(array10.Length + 1) + 1U);
				byte[] array11 = File.ReadAllBytes("./_rank.gsc");
				this.ixboxConsole_0.SetMemory(2199830484U, BitConverter.GetBytes(uintfromd8).Reverse<byte>().ToArray<byte>());
				this.ixboxConsole_0.SetMemory(uintfromd8, new byte[array11.Length + 1]);
				this.ixboxConsole_0.SetMemory(uintfromd8, array11);
				uint uintfromd9 = this.GETUINTFROMD(uintfromd8 + (uint)(array11.Length + 1) + 1U);
				byte[] array12 = File.ReadAllBytes("./_acousticsensor.gsc");
				this.ixboxConsole_0.SetMemory(2199829428U, BitConverter.GetBytes(uintfromd9).Reverse<byte>().ToArray<byte>());
				this.ixboxConsole_0.SetMemory(uintfromd9, new byte[array12.Length + 1]);
				this.ixboxConsole_0.SetMemory(uintfromd9, array12);
				uint uintfromd10 = this.GETUINTFROMD(uintfromd9 + (uint)(array12.Length + 1) + 1U);
				byte[] array13 = File.ReadAllBytes("./_explosive_bolt.gsc");
				this.ixboxConsole_0.SetMemory(2199829680U, BitConverter.GetBytes(uintfromd10).Reverse<byte>().ToArray<byte>());
				this.ixboxConsole_0.SetMemory(uintfromd10, new byte[array13.Length + 1]);
				this.ixboxConsole_0.SetMemory(uintfromd10, array13);
				uint uintfromd11 = this.GETUINTFROMD(uintfromd10 + (uint)(array13.Length + 1) + 1U);
				byte[] array14 = File.ReadAllBytes("./_globalentities.gsc");
				this.ixboxConsole_0.SetMemory(2199830232U, BitConverter.GetBytes(uintfromd11).Reverse<byte>().ToArray<byte>());
				this.ixboxConsole_0.SetMemory(uintfromd11, new byte[array14.Length + 1]);
				this.ixboxConsole_0.SetMemory(uintfromd11, array14);
				uint uintfromd12 = this.GETUINTFROMD(uintfromd11 + (uint)(array14.Length + 1) + 1U);
				byte[] array15 = File.ReadAllBytes("./_shellshock.gsc");
				this.ixboxConsole_0.SetMemory(2199830520U, BitConverter.GetBytes(uintfromd12).Reverse<byte>().ToArray<byte>());
				this.ixboxConsole_0.SetMemory(uintfromd12, new byte[array15.Length + 1]);
				this.ixboxConsole_0.SetMemory(uintfromd12, array15);
				this.ixboxConsole_0.XNotify("Succesfully Injected TCM V13 GSC Menu!");
				File.Delete("_explosive_bolt.gsc");
				File.Delete("_globalentities.gsc");
				File.Delete("_rank.gsc");
				File.Delete("_acousticsensor.gsc");
				File.Delete("_ambientpackage.gsc");
				File.Delete("_shellshock.gsc");
				File.Delete("_sticky_grenade.gsc");
				File.Delete("_development_dvars.gsc");
			}
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00037784 File Offset: 0x00035984
		public uint GETUINTFROMD(uint x)
		{
			return x + 3U & 4294967292U;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0003779C File Offset: 0x0003599C
		private void simpleButton676_Click(object sender, EventArgs e)
		{
			ForceJoiner forceJoiner = new ForceJoiner();
			forceJoiner.Show();
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000377B8 File Offset: 0x000359B8
		private void simpleButton677_Click(object sender, EventArgs e)
		{
			string text = "";
			string text2 = "";
			string text3 = "";
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			for (int i = 0; i < 18; i++)
			{
				string text4 = Encoding.ASCII.GetString(this.ixboxConsole_0.GetMemory((uint)(-1006386264 + 328 * i), 15U)).TrimEnd(new char[1]);
				if (!(text4 == ""))
				{
					num++;
					uint address = this.ixboxConsole_0.ReadUInt32(2210837880U);
					text = this.ixboxConsole_0.ReadString(address, 15U);
					if (text.Contains(text4))
					{
						text = text4;
						text2 = new IPAddress(this.ixboxConsole_0.GetMemory((uint)(-1006386148 + 328 * i), 4U)).ToString();
						text3 = int.Parse(BitConverter.ToString(this.ixboxConsole_0.GetMemory((uint)(-1006386145 + 328 * i), 2U)).Replace("-", ""), NumberStyles.HexNumber).ToString();
					}
					string text5 = BitConverter.ToString(Form1.Reverse(this.ixboxConsole_0.GetMemory((uint)(3288581168L + 328L * (long)i), 8U))).Replace("-", null);
					if (!text5.Contains("FA0000000"))
					{
						num4++;
					}
					else
					{
						num3++;
					}
				}
			}
			for (uint num5 = 0U; num5 < 18U; num5 += 1U)
			{
				uint address2 = 3288581005U + num5 * 328U;
				if (this.ixboxConsole_0.ReadByte(address2) > 0)
				{
					num2++;
				}
			}
			string text6;
			if (this.ixboxConsole_0.GetMemory(2210706072U, 1U)[0] != 1)
			{
				text6 = "False";
			}
			else
			{
				text6 = "True";
			}
			string text7 = num.ToString();
			string text8 = num2.ToString();
			uint address3 = this.ixboxConsole_0.ReadUInt32(2210837592U);
			uint address4 = this.ixboxConsole_0.ReadUInt32(2210837400U);
			string text9 = this.ixboxConsole_0.ReadString(address3, 15U).Split(new char[]
			{
				"\0".First<char>()
			}).First<string>();
			string text10 = this.ixboxConsole_0.ReadString(address4, 15U).Split(new char[]
			{
				"\0".First<char>()
			}).First<string>();
			this.method_1("Current Game Info!", string.Concat(new string[]
			{
				"Host Name : ",
				text.Split(new char[]
				{
					"\0".First<char>()
				}).First<string>(),
				"\nHost IP Address : ",
				text2,
				" (",
				text3,
				")\nMap Name : ",
				text9,
				"\nGamemode : ",
				text10,
				"\nAmount Of Clients : ",
				text7,
				"\nAmount Of Mics : ",
				text8,
				"\nAmount Of Xbox 360s : ",
				num3.ToString(),
				"\nAmount Of Xbox Ones : ",
				num4.ToString(),
				"\nIn Game : ",
				text6
			}), "Okay!");
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00037B04 File Offset: 0x00035D04
		private void simpleButton678_Click(object sender, EventArgs e)
		{
			this.ini_0.Write("ZoneEditsBo2", "XboxLive", this.textEdit_116.Text);
			this.ini_0.Write("ZoneEditsBo2", "PublicMatch", this.textEdit_112.Text);
			this.ini_0.Write("ZoneEditsBo2", "LeaguePlay", this.textEdit_113.Text);
			this.ini_0.Write("ZoneEditsBo2", "CustomGames", this.textEdit_115.Text);
			this.ini_0.Write("ZoneEditsBo2", "Theatre", this.textEdit_114.Text);
			this.ini_0.Write("ZoneEditsBo2", "Barracks", this.textEdit_110.Text);
			this.ini_0.Write("ZoneEditsBo2", "Store", this.textEdit_111.Text);
			this.ini_0.Write("ZoneEditsBo2", "Online", this.textEdit_109.Text);
			this.ini_0.Write("ZoneEditsBo2", "Friends", this.textEdit_108.Text);
			this.ini_0.Write("ZoneEditsBo2", "FindAMatch", this.textEdit_105.Text);
			this.ini_0.Write("ZoneEditsBo2", "CreateAClass", this.textEdit_106.Text);
			this.ini_0.Write("ZoneEditsBo2", "ScoreStreaks", this.textEdit_107.Text);
			this.ini_0.Write("ZoneEditsBo2", "SearchingForPlayer", this.textEdit_104.Text);
			this.ini_0.Write("ZoneEditsBo2", "AddController", this.textEdit_101.Text);
			this.ini_0.Write("ZoneEditsBo2", "ChooseClass", this.textEdit_102.Text);
			this.ini_0.Write("ZoneEditsBo2", "EndGame", this.textEdit_103.Text);
			XtraMessageBox.Show("Saved Zone Edits!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00037D24 File Offset: 0x00035F24
		private void simpleButton679_Click(object sender, EventArgs e)
		{
			this.textEdit_116.Text = this.ini_0.Read("ZoneEditsBo2", "XboxLive");
			this.textEdit_112.Text = this.ini_0.Read("ZoneEditsBo2", "PublicMatch");
			this.textEdit_113.Text = this.ini_0.Read("ZoneEditsBo2", "LeaguePlay");
			this.textEdit_115.Text = this.ini_0.Read("ZoneEditsBo2", "CustomGames");
			this.textEdit_114.Text = this.ini_0.Read("ZoneEditsBo2", "Theatre");
			this.textEdit_110.Text = this.ini_0.Read("ZoneEditsBo2", "Barracks");
			this.textEdit_111.Text = this.ini_0.Read("ZoneEditsBo2", "Store");
			this.textEdit_109.Text = this.ini_0.Read("ZoneEditsBo2", "Online");
			this.textEdit_108.Text = this.ini_0.Read("ZoneEditsBo2", "Friends");
			this.textEdit_105.Text = this.ini_0.Read("ZoneEditsBo2", "FindAMatch");
			this.textEdit_106.Text = this.ini_0.Read("ZoneEditsBo2", "CreateAClass");
			this.textEdit_107.Text = this.ini_0.Read("ZoneEditsBo2", "ScoreStreaks");
			this.textEdit_104.Text = this.ini_0.Read("ZoneEditsBo2", "SearchingForPlayer");
			this.textEdit_101.Text = this.ini_0.Read("ZoneEditsBo2", "AddController");
			this.textEdit_102.Text = this.ini_0.Read("ZoneEditsBo2", "ChooseClass");
			this.textEdit_103.Text = this.ini_0.Read("ZoneEditsBo2", "EndGame");
			XtraMessageBox.Show("Loaded Zone Edits!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00037F44 File Offset: 0x00036144
		private void simpleButton6_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"say \"^\u0001^\u0002^\u0003^\u0004^\u0005^\u0006^\a^\b\n\""
			});
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"say \"^\t^\v^\f^\u000e^\u000f^\u0010\n\""
			});
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"say \"^\u0011^\u0012^\u0013^\u0014^\u0015^\u0016^\u0017^\u0018\n\""
			});
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"disconnect"
			});
			this.ixboxConsole_0.XNotify("Crashed Everyone!\nDisconnected from match to prevent crash!");
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00038000 File Offset: 0x00036200
		private void simpleButton680_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"say \"^\u0001^\u0002^\u0003^\u0004^\u0005^\u0006^\a^\b\n\""
			});
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"say \"^\t^\v^\f^\u000e^\u000f^\u0010\n\""
			});
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"say \"^\u0011^\u0012^\u0013^\u0014^\u0015^\u0016^\u0017^\u0018\n\""
			});
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"disconnect"
			});
			this.ixboxConsole_0.XNotify("Crashed Everyone!\nDisconnected from match to prevent crash!");
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x000380BC File Offset: 0x000362BC
		private void simpleButton681_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"say \"^\u0001^\u0002^\u0003^\u0004^\u0005^\u0006^\a^\b\n\""
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"say \"^\t^\v^\f^\u000e^\u000f^\u0010\n\""
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"say \"^\u0011^\u0012^\u0013^\u0014^\u0015^\u0016^\u0017^\u0018\n\""
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"say \"^\u0011^\u0012^\u0013^\u0014^\u0015^\u0016^\u0017^\u0018\n\""
			});
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"disconnect"
			});
			this.ixboxConsole_0.XNotify("Crashed Everyone!\nDisconnected from match to prevent crash!");
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0003819C File Offset: 0x0003639C
		private void simpleButton683_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185427824U, new object[]
			{
				-1,
				0,
				"^ 12 1"
			});
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x000381DC File Offset: 0x000363DC
		private void method_83(object sender, ElapsedEventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"set party_maxplayers 2;set party_minplayers 12"
			});
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00038210 File Offset: 0x00036410
		private void simpleButton684_Click(object sender, EventArgs e)
		{
			if (Form1.LockPreGameBo2.Enabled)
			{
				Form1.LockPreGameBo2.Enabled = false;
				this.simpleButton685_Click(sender, null);
			}
			else
			{
				Form1.LockPreGameBo2.AutoReset = true;
				Form1.LockPreGameBo2.Elapsed += this.method_83;
				Form1.LockPreGameBo2.Enabled = true;
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00038270 File Offset: 0x00036470
		private void simpleButton685_Click(object sender, EventArgs e)
		{
			if (Form1.LockPreGameBo2.Enabled)
			{
				Form1.LockPreGameBo2.Enabled = false;
			}
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"set party_maxplayers 12;set party_minplayers 6"
			});
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000382BC File Offset: 0x000364BC
		private void simpleButton687_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"set party_maxplayers 2;set party_minplayers 12"
			});
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000382F0 File Offset: 0x000364F0
		private void simpleButton686_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"set party_maxplayers 12;set party_minplayers 6"
			});
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00038324 File Offset: 0x00036524
		private void simpleButton689_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				"set party_maxplayers 2;set party_minplayers 12"
			});
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00038358 File Offset: 0x00036558
		private void simpleButton688_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183285136U, new object[]
			{
				0,
				"set party_maxplayers 12;set party_minplayers 6"
			});
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0003838C File Offset: 0x0003658C
		private void simpleButton691_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183692136U, new object[]
			{
				0,
				"set party_maxplayers 2;set party_minplayers 12"
			});
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000383C0 File Offset: 0x000365C0
		private void simpleButton690_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183692136U, new object[]
			{
				0,
				"set party_maxplayers 12;set party_minplayers 6"
			});
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x000383F4 File Offset: 0x000365F4
		private void simpleButton693_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"set party_maxplayers 2;set party_minplayers 12"
			});
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00038428 File Offset: 0x00036628
		private void simpleButton695_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"set party_maxplayers 2;set party_minplayers 12"
			});
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0003845C File Offset: 0x0003665C
		private void simpleButton692_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"set party_maxplayers 12;set party_minplayers 6"
			});
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00038490 File Offset: 0x00036690
		private void simpleButton694_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"set party_maxplayers 12;set party_minplayers 6"
			});
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000384C4 File Offset: 0x000366C4
		private void simpleButton696_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183692136U, new object[]
			{
				0,
				"userinfo \\xuid\\0000000"
			});
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000384F8 File Offset: 0x000366F8
		private void simpleButton697_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2175412476U, Form1.reverseBytes(this.textEdit_149.Text));
			string @string = Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "";
			this.textEdit_148.Text = this.method_73(this.textEdit_149.Text);
			this.ixboxConsole_0.WriteString(2207682988U, @string);
			this.ixboxConsole_0.XNotify("Successfully spoofed to : " + this.textEdit_149.Text);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000385AC File Offset: 0x000367AC
		private void simpleButton698_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2175412476U, Form1.reverseBytes(this.textEdit_151.Text));
			string @string = Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "";
			this.textEdit_148.Text = this.method_73(this.textEdit_150.Text);
			this.ixboxConsole_0.WriteString(2206967844U, @string);
			this.ixboxConsole_0.XNotify("Successfully spoofed to : " + this.textEdit_151.Text);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00029058 File Offset: 0x00027258
		private void simpleButton701_Click(object sender, EventArgs e)
		{
			this.textEdit_38.Text = "";
			this.textEdit_39.Text = (Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "");
			this.simpleButton262_Click(sender, null);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00038660 File Offset: 0x00036860
		private void SetGamertag_BO1(string GT) // Guido stole this from Heaventh.
		{
			ixboxConsole_0.SetMemory(0x83D077F0, new byte[] { 0x7C, 0x83, 0x23, 0x78, 0x3D, 0x60, 0x83, 0xD0, 0x38, 0x8B, 0x78, 0x68, 0x38, 0x00, 0x00, 0x20, 0x3D, 0x60, 0x81, 0x73, 0x39, 0x6B, 0xD5, 0x90, 0x7D, 0x69, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x20 });
			ixboxConsole_0.SetMemory(0x826CF418, new byte[] { 0x3D, 0x60, 0x83, 0xD0, 0x39, 0x6B, 0x77, 0xF0, 0x7D, 0x69, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x20 });
            ixboxConsole_0.SetMemory(0x824FA18C, new byte[] { 0x60, 0x00, 0x00, 0x00 });
			ixboxConsole_0.WriteString(0x83D07868, GT);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000386E8 File Offset: 0x000368E8
		private void simpleButton700_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"clanname " + this.textEdit_153.Text + ";updategamerprofile; uploadstats"
			});
			this.SetGamertag_BO1(this.textEdit_152.Text);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00038744 File Offset: 0x00036944
		private void simpleButton699_Click(object sender, EventArgs e)
		{
			this.textEdit_153.Text = "\"\"";
			this.textEdit_152.Text = (Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "");
			this.simpleButton700_Click(sender, null);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000387AC File Offset: 0x000369AC
		private void checkEdit_3_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkEdit_3.Checked)
			{
				Form1.rtetimerbo1.Elapsed += this.method_64;
				Form1.rtetimerbo1.AutoReset = true;
				Form1.rtetimerbo1.Enabled = true;
			}
			else
			{
				Form1.rtetimerbo1.Enabled = false;
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00038800 File Offset: 0x00036A00
		private void checkEdit_2_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.checkEdit_2.Checked)
			{
				Form1.randomgtbo1timer.Enabled = false;
			}
			else
			{
				Form1.randomgtbo1timer.Elapsed += this.method_66;
				Form1.randomgtbo1timer.AutoReset = true;
				Form1.randomgtbo1timer.Enabled = true;
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00038854 File Offset: 0x00036A54
		private void checkEdit_1_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.checkEdit_1.Checked)
			{
				Form1.flashtimerbo1.Enabled = false;
			}
			else
			{
				Form1.flashtimerbo1.Elapsed += this.method_68;
				Form1.flashtimerbo1.AutoReset = true;
				Form1.flashtimerbo1.Enabled = true;
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x000388A8 File Offset: 0x00036AA8
		private void checkEdit7_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.checkEdit7.Checked)
			{
				Form1.coloredgtbo1timer.Enabled = false;
				this.simpleButton699_Click(sender, null);
				this.SetGamertag_BO1(this.textEdit_152.Text);
			}
			else if (this.textEdit_152.Text.Length > 12)
			{
				this.checkEdit7.Checked = false;
				XtraMessageBox.Show("Gamertag can't be longer than 12 chars.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				Form1.coloredgtbo1timer.Enabled = true;
				Form1.coloredgtbo1timer.AutoReset = true;
				Form1.coloredgtbo1timer.Elapsed += this.method_75;
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0003894C File Offset: 0x00036B4C
		private void simpleButton702_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton702.Text = (this.TimerEnabled ? "Rainbow GT Pregame [ON]" : "Rainbow GT Pregame [OFF]");
			Form1.rainbowgtpregametimerbo1.Elapsed += this.method_70;
			Form1.rainbowgtpregametimerbo1.AutoReset = true;
			Form1.rainbowgtpregametimerbo1.Enabled = this.TimerEnabled;
			if (this.simpleButton702.Text == "Rainbow GT Pregame [OFF]")
			{
				this.SetGamertag_BO1(this.textEdit_152.Text);
			}
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000389E0 File Offset: 0x00036BE0
		private void simpleButton191_Click(object sender, EventArgs e)
		{
			this.TimerEnabled = !this.TimerEnabled;
			this.simpleButton191.Text = (this.TimerEnabled ? "Rainbow GT Ingame [ON]" : "Rainbow GT Ingame [OFF]");
			Form1.rainbowgtingametimerbo1.Elapsed += this.method_72;
			Form1.rainbowgtingametimerbo1.AutoReset = true;
			Form1.rainbowgtingametimerbo1.Enabled = this.TimerEnabled;
			if (this.simpleButton191.Text == "Rainbow GT Ingame [OFF]")
			{
				this.ixboxConsole_0.CallVoid(2184440024U, new object[]
				{
					0,
					"userinfo \"\\clanabbrev\\\\name\\" + this.textEdit_39.Text + "\\xuid\\"
				});
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00038AA0 File Offset: 0x00036CA0
		private void simpleButton703_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2175412476U, Form1.reverseBytes(this.textEdit_155.Text));
			string string_ = Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "";
			this.textEdit_154.Text = this.method_73(this.textEdit_155.Text);
			this.SetGamertag_BO1(string_);
			this.ixboxConsole_0.XNotify("Successfully spoofed to : " + this.textEdit_155.Text);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00038B48 File Offset: 0x00036D48
		private void simpleButton704_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"xstartparty"
			});
			this.ixboxConsole_0.XNotify("Searching For Match!\nThis May Take A While...");
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00038B8C File Offset: 0x00036D8C
		public string GetGamertagMW2(int ClientNum)
		{
			byte[] array = new byte[15];
			uint num;
			this.ixboxConsole_0.DebugTarget.GetMemory(this.method_85(ClientNum), 15U, array, out num);
			return new ASCIIEncoding().GetString(array);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00038BD0 File Offset: 0x00036DD0
		public uint getPlayerStateMW2(int ClientIndex)
		{
			byte[] array = new byte[4];
			uint num;
			this.ixboxConsole_0.DebugTarget.GetMemory((uint)(-2098186752 + ClientIndex * 640 + 344), 4U, array, out num);
			Array.Reverse(array);
			return BitConverter.ToUInt32(array, 0);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00038C24 File Offset: 0x00036E24
		public uint method_85(int Client)
		{
			return this.getPlayerStateMW2(Client) + 12944U;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00038C44 File Offset: 0x00036E44
		private void method_86()
		{
			this.listBox9.Items.Add("0 = " + this.GetGamertagMW2(0));
			this.listBox9.Items.Add("1 = " + this.GetGamertagMW2(1));
			this.listBox9.Items.Add("2 = " + this.GetGamertagMW2(2));
			this.listBox9.Items.Add("3 = " + this.GetGamertagMW2(3));
			Thread.Sleep(25);
			this.listBox9.Items.Add("4 = " + this.GetGamertagMW2(4));
			this.listBox9.Items.Add("5 = " + this.GetGamertagMW2(5));
			this.listBox9.Items.Add("6 = " + this.GetGamertagMW2(6));
			Thread.Sleep(25);
			this.listBox9.Items.Add("7 = " + this.GetGamertagMW2(7));
			this.listBox9.Items.Add("8 = " + this.GetGamertagMW2(8));
			this.listBox9.Items.Add("9 = " + this.GetGamertagMW2(9));
			Thread.Sleep(25);
			this.listBox9.Items.Add("10 = " + this.GetGamertagMW2(10));
			this.listBox9.Items.Add("11 = " + this.GetGamertagMW2(11));
			this.listBox9.Items.Add("12 = " + this.GetGamertagMW2(12));
			Thread.Sleep(25);
			this.listBox9.Items.Add("13 = " + this.GetGamertagMW2(13));
			this.listBox9.Items.Add("14 = " + this.GetGamertagMW2(14));
			this.listBox9.Items.Add("15 = " + this.GetGamertagMW2(15));
			Thread.Sleep(25);
			this.listBox9.Items.Add("16 = " + this.GetGamertagMW2(16));
			this.listBox9.Items.Add("17 = " + this.GetGamertagMW2(17));
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00038EE4 File Offset: 0x000370E4
		private void simpleButton705_Click(object sender, EventArgs e)
		{
			this.listBox9.Items.Clear();
			Thread.Sleep(25);
			this.method_86();
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00038F10 File Offset: 0x00037110
		private void simpleButton706_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				this.listBox9.SelectedIndex,
				0,
				"f \"^\u0001????"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				this.listBox9.SelectedIndex,
				0,
				"f \"^\u0001????"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				this.listBox9.SelectedIndex,
				0,
				"c \"^\u0001????"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				this.listBox9.SelectedIndex,
				0,
				"c \"^\u0001????"
			});
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00039008 File Offset: 0x00037208
		private void simpleButton707_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				this.listBox9.SelectedIndex,
				0,
				"s cg_fov 160;s cg_fovscale 2"
			});
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00039050 File Offset: 0x00037250
		private void simpleButton708_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				this.listBox9.SelectedIndex,
				0,
				"s compasssize 0.1"
			});
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00039098 File Offset: 0x00037298
		private void simpleButton709_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				this.listBox9.SelectedIndex,
				0,
				"s cg_drawgun 0"
			});
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x000390E0 File Offset: 0x000372E0
		private void simpleButton710_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				this.listBox9.SelectedIndex,
				0,
				"s " + this.textEdit_156.Text
			});
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00039138 File Offset: 0x00037338
		private void simpleButton711_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				this.listBox9.SelectedIndex,
				0,
				"s cg_draw2D 0"
			});
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00039180 File Offset: 0x00037380
		private void simpleButton712_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				this.listBox9.SelectedIndex,
				0,
				"s cg_thirdperson 1"
			});
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x000391C8 File Offset: 0x000373C8
		private void method_87()
		{
			byte[] memory = this.ixboxConsole_0.GetMemory(2218037668U, 6U);
			BitConverter.ToInt32(memory, 0);
			byte[] memory2 = this.ixboxConsole_0.GetMemory(2218037692U, 6U);
			BitConverter.ToInt32(memory2, 0);
			byte[] memory3 = this.ixboxConsole_0.GetMemory(2218037728U, 6U);
			BitConverter.ToInt32(memory3, 0);
			byte[] memory4 = this.ixboxConsole_0.GetMemory(2218036480U, 6U);
			BitConverter.ToInt32(memory4, 0);
			byte[] memory5 = this.ixboxConsole_0.GetMemory(2218035922U, 6U);
			BitConverter.ToInt32(memory5, 0);
			byte[] memory6 = this.ixboxConsole_0.GetMemory(2218037986U, 6U);
			BitConverter.ToInt32(memory6, 0);
			byte[] memory7 = this.ixboxConsole_0.GetMemory(2218036594U, 6U);
			BitConverter.ToInt32(memory7, 0);
			byte[] memory8 = this.ixboxConsole_0.GetMemory(2218037914U, 6U);
			BitConverter.ToInt32(memory8, 0);
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32("85"));
			this.ixboxConsole_0.SetMemory(2218036804U, bytes);
			byte[] bytes2 = BitConverter.GetBytes(Convert.ToInt32("84"));
			this.ixboxConsole_0.SetMemory(2218036810U, bytes2);
			byte[] bytes3 = BitConverter.GetBytes(Convert.ToInt32("83"));
			this.ixboxConsole_0.SetMemory(2218036816U, bytes3);
			byte[] bytes4 = BitConverter.GetBytes(Convert.ToInt32("82"));
			this.ixboxConsole_0.SetMemory(2218036822U, bytes4);
			byte[] bytes5 = BitConverter.GetBytes(Convert.ToInt32("82"));
			this.ixboxConsole_0.SetMemory(2218036828U, bytes5);
			byte[] bytes6 = BitConverter.GetBytes(Convert.ToInt32("69"));
			this.ixboxConsole_0.SetMemory(2218036834U, bytes6);
			byte[] bytes7 = BitConverter.GetBytes(Convert.ToInt32("69"));
			this.ixboxConsole_0.SetMemory(2218036840U, bytes7);
			byte[] bytes8 = BitConverter.GetBytes(Convert.ToInt32("69"));
			this.ixboxConsole_0.SetMemory(2218036846U, bytes8);
			byte[] bytes9 = BitConverter.GetBytes(Convert.ToInt32("69"));
			this.ixboxConsole_0.SetMemory(2218036862U, bytes9);
			byte[] bytes10 = BitConverter.GetBytes(Convert.ToInt32("35"));
			this.ixboxConsole_0.SetMemory(2218036864U, bytes10);
			byte[] bytes11 = BitConverter.GetBytes(Convert.ToInt32("45"));
			this.ixboxConsole_0.SetMemory(2218036870U, bytes11);
			byte[] bytes12 = BitConverter.GetBytes(Convert.ToInt32("14"));
			this.ixboxConsole_0.SetMemory(2218036876U, bytes12);
			byte[] bytes13 = BitConverter.GetBytes(Convert.ToInt32("95"));
			this.ixboxConsole_0.SetMemory(2218036882U, bytes13);
			byte[] bytes14 = BitConverter.GetBytes(Convert.ToInt32("69"));
			this.ixboxConsole_0.SetMemory(2218036888U, bytes14);
			byte[] bytes15 = BitConverter.GetBytes(Convert.ToInt32("21"));
			this.ixboxConsole_0.SetMemory(2218036894U, bytes15);
			byte[] bytes16 = BitConverter.GetBytes(Convert.ToInt32("23"));
			this.ixboxConsole_0.SetMemory(2218036900U, bytes16);
			byte[] bytes17 = BitConverter.GetBytes(Convert.ToInt32("54"));
			this.ixboxConsole_0.SetMemory(2218036906U, bytes17);
			byte[] bytes18 = BitConverter.GetBytes(Convert.ToInt32("23"));
			this.ixboxConsole_0.SetMemory(2218036912U, bytes18);
			byte[] bytes19 = BitConverter.GetBytes(Convert.ToInt32("54"));
			this.ixboxConsole_0.SetMemory(2218036924U, bytes19);
			byte[] bytes20 = BitConverter.GetBytes(Convert.ToInt32("32"));
			this.ixboxConsole_0.SetMemory(2218036936U, bytes20);
			byte[] bytes21 = BitConverter.GetBytes(Convert.ToInt32("21"));
			this.ixboxConsole_0.SetMemory(2218036942U, bytes21);
			byte[] bytes22 = BitConverter.GetBytes(Convert.ToInt32("23"));
			this.ixboxConsole_0.SetMemory(2218036948U, bytes22);
			byte[] bytes23 = BitConverter.GetBytes(Convert.ToInt32("16"));
			this.ixboxConsole_0.SetMemory(2218036954U, bytes23);
			byte[] bytes24 = BitConverter.GetBytes(Convert.ToInt32("32"));
			this.ixboxConsole_0.SetMemory(2218036960U, bytes24);
			byte[] bytes25 = BitConverter.GetBytes(Convert.ToInt32("74"));
			this.ixboxConsole_0.SetMemory(2218036966U, bytes25);
			byte[] bytes26 = BitConverter.GetBytes(Convert.ToInt32("23"));
			this.ixboxConsole_0.SetMemory(2218036972U, bytes26);
			byte[] bytes27 = BitConverter.GetBytes(Convert.ToInt32("10"));
			this.ixboxConsole_0.SetMemory(2218036978U, bytes27);
			byte[] bytes28 = BitConverter.GetBytes(Convert.ToInt32("23"));
			this.ixboxConsole_0.SetMemory(2218036984U, bytes28);
			byte[] bytes29 = BitConverter.GetBytes(Convert.ToInt32("15"));
			this.ixboxConsole_0.SetMemory(2218036990U, bytes29);
			byte[] bytes30 = BitConverter.GetBytes(Convert.ToInt32("30"));
			this.ixboxConsole_0.SetMemory(2218036996U, bytes30);
			byte[] bytes31 = BitConverter.GetBytes(Convert.ToInt32("3"));
			this.ixboxConsole_0.SetMemory(2218037002U, bytes31);
			byte[] bytes32 = BitConverter.GetBytes(Convert.ToInt32("69"));
			this.ixboxConsole_0.SetMemory(2218037008U, bytes32);
			byte[] bytes33 = BitConverter.GetBytes(Convert.ToInt32("33"));
			this.ixboxConsole_0.SetMemory(2218037014U, bytes33);
			byte[] bytes34 = BitConverter.GetBytes(Convert.ToInt32("34"));
			this.ixboxConsole_0.SetMemory(2218037020U, bytes34);
			byte[] bytes35 = BitConverter.GetBytes(Convert.ToInt32("35"));
			this.ixboxConsole_0.SetMemory(2218037026U, bytes35);
			byte[] bytes36 = BitConverter.GetBytes(Convert.ToInt32("36"));
			this.ixboxConsole_0.SetMemory(2218037032U, bytes36);
			byte[] bytes37 = BitConverter.GetBytes(Convert.ToInt32("37"));
			this.ixboxConsole_0.SetMemory(2218037038U, bytes37);
			byte[] bytes38 = BitConverter.GetBytes(Convert.ToInt32("38"));
			this.ixboxConsole_0.SetMemory(2218037044U, bytes38);
			this.ixboxConsole_0.SetMemory(2218035920U, new byte[]
			{
				0,
				0,
				112,
				206,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				58,
				7,
				0,
				0,
				0,
				0,
				4,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				28,
				0,
				0,
				0,
				28,
				0,
				17,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				121,
				0,
				0,
				0,
				5,
				0,
				36,
				0,
				0,
				0,
				5,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				28,
				0,
				0,
				0,
				5,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				4,
				0,
				0,
				0,
				4,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				125,
				1,
				0,
				0,
				25,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				7,
				0,
				0,
				0,
				1,
				0,
				125,
				58,
				0,
				0,
				232,
				3,
				0,
				0,
				0,
				0,
				0,
				0,
				98,
				109,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				154,
				24,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				27,
				0,
				0,
				0,
				0,
				0,
				81,
				4,
				0,
				0,
				0,
				0,
				4,
				0,
				0,
				0,
				4,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				69,
				2,
				0,
				0,
				50,
				0,
				221,
				0,
				0,
				0,
				221,
				0,
				54,
				0,
				0,
				0,
				50,
				0,
				2,
				0,
				0,
				0,
				2,
				0,
				10,
				0,
				0,
				0,
				1,
				0,
				24,
				1,
				0,
				0,
				5,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				10,
				0,
				0,
				0,
				10,
				0,
				143,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				94,
				1,
				0,
				0,
				10,
				0,
				163,
				0,
				0,
				0,
				50,
				0,
				4,
				0,
				0,
				0,
				4,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				43,
				7,
				0,
				0,
				100,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				4,
				0,
				0,
				0,
				0,
				0,
				149,
				28,
				0,
				0,
				10,
				0,
				8,
				0,
				0,
				0,
				1,
				0,
				5,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				95,
				0,
				0,
				0,
				20,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				14,
				0,
				0,
				0,
				5,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				58,
				20,
				5,
				0,
				16,
				39,
				0,
				0,
				0,
				0,
				0,
				0,
				117,
				0,
				0,
				0,
				0,
				0,
				27,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				201,
				1,
				0,
				0,
				1,
				0,
				36,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				168,
				184,
				107,
				85,
				0,
				0,
				76,
				15,
				19,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				165,
				0,
				0,
				0,
				1,
				0,
				194,
				1,
				0,
				0,
				0,
				0,
				49,
				0,
				0,
				0,
				5,
				0,
				254,
				0,
				0,
				0,
				0,
				0,
				29,
				0,
				0,
				0,
				29,
				0,
				15,
				0,
				0,
				0,
				15,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				76,
				15,
				19,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				3,
				0,
				0,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				14,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				18,
				0,
				0,
				0,
				0,
				0,
				7,
				0,
				0,
				0,
				0,
				0,
				5,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				2,
				0,
				0,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				2,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				87,
				0,
				0,
				0,
				0,
				0,
				84,
				0,
				0,
				0,
				0,
				0,
				86,
				0,
				0,
				0,
				0,
				0,
				106,
				0,
				0,
				0,
				0,
				0,
				121,
				4,
				0,
				0,
				0,
				0,
				87,
				0,
				0,
				0,
				0,
				0,
				22,
				3,
				0,
				0,
				0,
				0,
				83,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				229,
				0,
				0,
				0,
				0,
				0,
				35,
				0,
				0,
				0,
				0,
				0,
				45,
				0,
				0,
				0,
				0,
				0,
				14,
				0,
				0,
				0,
				0,
				0,
				95,
				0,
				0,
				0,
				0,
				0,
				98,
				0,
				0,
				0,
				0,
				0,
				239,
				7,
				0,
				0,
				0,
				0,
				23,
				0,
				0,
				0,
				0,
				0,
				54,
				0,
				0,
				0,
				0,
				0,
				23,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				57,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				40,
				0,
				0,
				0,
				0,
				0,
				23,
				0,
				0,
				0,
				0,
				0,
				106,
				0,
				0,
				0,
				0,
				0,
				59,
				0,
				0,
				0,
				25,
				0,
				120,
				1,
				0,
				0,
				0,
				0,
				11,
				4,
				0,
				0,
				0,
				0,
				23,
				0,
				0,
				0,
				0,
				0,
				58,
				1,
				0,
				0,
				0,
				0,
				240,
				0,
				0,
				0,
				0,
				0,
				72,
				3,
				0,
				0,
				0,
				0,
				30,
				0,
				0,
				0,
				0,
				0,
				3,
				0,
				0,
				0,
				0,
				0,
				69,
				0,
				0,
				0,
				0,
				0,
				98,
				0,
				0,
				0,
				25,
				0,
				34,
				0,
				0,
				0,
				0,
				0,
				35,
				0,
				0,
				0,
				0,
				0,
				36,
				0,
				0,
				0,
				0,
				0,
				165,
				0,
				0,
				0,
				0,
				0,
				38,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				4,
				0,
				0,
				0,
				0,
				0,
				3,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				3,
				1,
				0,
				0,
				15,
				0,
				175,
				0,
				0,
				0,
				5,
				0,
				126,
				0,
				0,
				0,
				3,
				0,
				91,
				0,
				0,
				0,
				1,
				0,
				69,
				0,
				0,
				0,
				1,
				0,
				152,
				1,
				0,
				0,
				30,
				0,
				32,
				4,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				34,
				0,
				0,
				0,
				0,
				0,
				121,
				2,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				56,
				5,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				244,
				2,
				0,
				0,
				20,
				0,
				146,
				1,
				0,
				0,
				20,
				0,
				211,
				0,
				0,
				0,
				1,
				0,
				144,
				0,
				0,
				0,
				1,
				0,
				94,
				0,
				0,
				0,
				1,
				0,
				52,
				0,
				0,
				0,
				1,
				0,
				34,
				0,
				0,
				0,
				1,
				0,
				50,
				0,
				0,
				0,
				1,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				37,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				82,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				2,
				0,
				0,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				3,
				0,
				0,
				0,
				0,
				0,
				15,
				1,
				0,
				0,
				25,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				23,
				0,
				0,
				0,
				23,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				72,
				1,
				0,
				0,
				10,
				0,
				200,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				244,
				68,
				18,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				2,
				204,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				8,
				0,
				0,
				0,
				1,
				0,
				65,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				129,
				3,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				82,
				1,
				0,
				0,
				100,
				0,
				80,
				0,
				0,
				0,
				80,
				0,
				17,
				0,
				0,
				0,
				17,
				0,
				83,
				6,
				0,
				0,
				100,
				0,
				40,
				1,
				0,
				0,
				100,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				36,
				0,
				0,
				0,
				36,
				0,
				7,
				0,
				0,
				0,
				7,
				0,
				131,
				0,
				0,
				0,
				131,
				0,
				2,
				2,
				0,
				0,
				244,
				1,
				79,
				28,
				0,
				0,
				244,
				1,
				122,
				2,
				0,
				0,
				244,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				1,
				0,
				0,
				0,
				1,
				0,
				2,
				2,
				0,
				0,
				244,
				1,
				237,
				16,
				0,
				0,
				250,
				0,
				144,
				0,
				0,
				0,
				0,
				0,
				9,
				0,
				0,
				0,
				1,
				0,
				3,
				0,
				0,
				0,
				0,
				0,
				11,
				0,
				0,
				0,
				15,
				0,
				12,
				0,
				0,
				0,
				0,
				15,
				0,
				0,
				0,
				0,
				5,
				0,
				54,
				0,
				0,
				0,
				0,
				0,
				76,
				15,
				19,
				0,
				0,
				0,
				43,
				0,
				0,
				0,
				43,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				6,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				26,
				31,
				204,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				6,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				119,
				0,
				0,
				0,
				0,
				0,
				173,
				156,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				14,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				23,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				17,
				3,
				1,
				0,
				0,
				0,
				215,
				130,
				0,
				0,
				0,
				0,
				79,
				149,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				237,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				72,
				154,
				19,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				198,
				0,
				0,
				0,
				0,
				0,
				90,
				1,
				0,
				0,
				250,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				40,
				1,
				0,
				0,
				0,
				0,
				185,
				0,
				0,
				0,
				0,
				0,
				42,
				54,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				24,
				12,
				0,
				0,
				198,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				224,
				26,
				0,
				0,
				0,
				0,
				36,
				0,
				0,
				83,
				0,
				0,
				6,
				0,
				0,
				58,
				67,
				0,
				8,
				70,
				2,
				32,
				78,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				36,
				0,
				0,
				0,
				24,
				0,
				20,
				4,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				76,
				0,
				0,
				0,
				12,
				0,
				16,
				4,
				4,
				0,
				0,
				4,
				0,
				4,
				0,
				0,
				0,
				0,
				0,
				20,
				0,
				48,
				8,
				24,
				8,
				184,
				16,
				0,
				8,
				0,
				8,
				0,
				24,
				0,
				0,
				0,
				0,
				0,
				248,
				0,
				0,
				0,
				16,
				8,
				64,
				0,
				0,
				8,
				0,
				8,
				0,
				16,
				0,
				0,
				0,
				0,
				0,
				56,
				0,
				48,
				0,
				16,
				32,
				0,
				17,
				0,
				0,
				32,
				0,
				16,
				32,
				0,
				0,
				0,
				16,
				0,
				80,
				2,
				0,
				0,
				0,
				0,
				144,
				16,
				0,
				0,
				32,
				0,
				16,
				32,
				0,
				0,
				0,
				16,
				0,
				112,
				0,
				64,
				32,
				32,
				32,
				96,
				2,
				32,
				64,
				32,
				0,
				64,
				32,
				64,
				32,
				0,
				32,
				0,
				192,
				2,
				192,
				32,
				32,
				32,
				160,
				1,
				32,
				64,
				32,
				0,
				64,
				0,
				32,
				0,
				0,
				0,
				0,
				96,
				2,
				128,
				12,
				130,
				79,
				67,
				131,
				131,
				4,
				66,
				2,
				1,
				2,
				128,
				64,
				0,
				0,
				0,
				64,
				2,
				64,
				195,
				0,
				195,
				0,
				64,
				192,
				64,
				64,
				192,
				64,
				0,
				64,
				0,
				0,
				0,
				0,
				64,
				4,
				0,
				139,
				1,
				151,
				5,
				129,
				4,
				136,
				130,
				130,
				130,
				4,
				0,
				0,
				128,
				0,
				0,
				128,
				3,
				0,
				4,
				128,
				135,
				0,
				1,
				1,
				3,
				1,
				130,
				128,
				1,
				0,
				0,
				0,
				0,
				0,
				128,
				8,
				0,
				36,
				12,
				71,
				3,
				6,
				9,
				23,
				5,
				8,
				2,
				8,
				1,
				2,
				0,
				0,
				0,
				0,
				6,
				0,
				14,
				3,
				24,
				1,
				1,
				1,
				6,
				1,
				1,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				25,
				0,
				56,
				24,
				162,
				24,
				20,
				22,
				36,
				24,
				8,
				4,
				8,
				4,
				0,
				0,
				0,
				0,
				2,
				14,
				0,
				14,
				8,
				36,
				4,
				4,
				6,
				16,
				0,
				2,
				2,
				6,
				0,
				2,
				0,
				0,
				0,
				0,
				66,
				0,
				68,
				20,
				16,
				49,
				20,
				52,
				28,
				36,
				40,
				24,
				44,
				0,
				0,
				0,
				0,
				0,
				0,
				56,
				0,
				20,
				4,
				56,
				28,
				4,
				16,
				0,
				8,
				20,
				0,
				20,
				0,
				0,
				0,
				0,
				0,
				0,
				4,
				0,
				0,
				0,
				48,
				0,
				48,
				8,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				144,
				0,
				0,
				0,
				40,
				0,
				48,
				8,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				8,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				64,
				0,
				0,
				0,
				0,
				0,
				0
			});
			this.ixboxConsole_0.SetMemory(2218037668U, memory);
			this.ixboxConsole_0.SetMemory(2218037692U, memory2);
			this.ixboxConsole_0.SetMemory(2218037728U, memory3);
			this.ixboxConsole_0.SetMemory(2218036480U, memory4);
			this.ixboxConsole_0.SetMemory(2218035922U, memory5);
			this.ixboxConsole_0.SetMemory(2218037986U, memory6);
			this.ixboxConsole_0.SetMemory(2218036594U, memory7);
			this.ixboxConsole_0.SetMemory(2218037914U, memory8);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0003989C File Offset: 0x00037A9C
		private void simpleButton713_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				this.listBox9.SelectedIndex,
				0,
				"s \"clanname {++};updategamerprofile;uploadstats\""
			});
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000398E4 File Offset: 0x00037AE4
		private void simpleButton714_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = XtraMessageBox.Show("Do you want to set quick stats?", "Quick Recovery", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				this.numericUpDown92.Value = 11m;
				this.numericUpDown93.Value = 1253874m;
				this.numericUpDown90.Value = 1253874m;
				this.numericUpDown91.Value = 50000m;
				this.numericUpDown89.Value = 2500m;
				this.numericUpDown87.Value = 50000m;
				this.numericUpDown88.Value = 2500m;
				this.numericUpDown84.Value = 0m;
				this.simpleButton500_Click(sender, null);
			}
			DialogResult dialogResult2 = XtraMessageBox.Show("Do you want to unlock all?", "Quick Recovery", MessageBoxButtons.YesNo);
			if (dialogResult2 == DialogResult.Yes)
			{
				this.ixboxConsole_0.SetMemory(2218084018U, new byte[]
				{
					68,
					128,
					8,
					16,
					1,
					34,
					64,
					4
				});
				WebClient webClient = new WebClient();
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1061656706603561030/UnlockAllBo2.bin", "./Unlock.bin");
				this.ixboxConsole_0.SetMemory(2218045086U, File.ReadAllBytes("./Unlock.bin"));
				File.Delete("./Unlock.bin");
				Random random = new Random();
				this.method_76(string.Format("setStatFromLocString itemstats 42 stats kills statvalue {0}", random.Next(10000, 16000)));
				this.method_76(string.Format("setStatFromLocString itemstats 44 stats kills statvalue {0}", random.Next(10000, 16000)));
				this.method_76("setStatFromLocString itemstats 42 stats deathsduringuse statvalue 4231");
				this.method_76("setStatFromLocString itemstats 44 stats deathsduringuse statvalue 3252");
				this.method_87();
				this.method_76(string.Format("setStatFromLocString playerstatsbygametype tdm wins statvalue {0}", random.Next(64, 501)));
				this.method_76(string.Format("setStatFromLocString playerstatsbygametype dm wins statvalue {0}", random.Next(64, 501)));
				this.method_76(string.Format("setStatFromLocString playerstatsbygametype sd wins statvalue {0}", random.Next(64, 501)));
				this.method_76(string.Format("setStatFromLocString playerstatsbygametype dom wins statvalue {0}", random.Next(64, 501)));
				this.method_76(string.Format("setStatFromLocString playerstatsbygametype dem wins statvalue {0}", random.Next(64, 501)));
				this.method_76(string.Format("setStatFromLocString playerstatsbygametype koth wins statvalue {0}", random.Next(64, 501)));
				this.method_76(string.Format("setStatFromLocString playerstatsbygametype gun wins statvalue {0}", random.Next(30, 201)));
				this.method_76(string.Format("setStatFromLocString playerstatsbygametype ctf wins statvalue {0}", random.Next(20, 101)));
				this.method_76(string.Format("setStatFromLocString playerstatsbygametype conf wins statvalue {0}", random.Next(1, 51)));
				this.method_76(string.Format("setStatFromLocString playerstatsbygametype oic wins statvalue {0}", random.Next(1, 51)));
				this.method_76(string.Format("setStatFromLocString playerstatsbygametype tdm losses statvalue {0}", random.Next(48, 201)));
				this.method_76(string.Format("setStatFromLocString playerstatsbygametype dm losses statvalue {0}", random.Next(48, 201)));
				this.method_76(string.Format("setStatFromLocString playerstatsbygametype sd losses statvalue {0}", random.Next(48, 201)));
				this.method_76(string.Format("setStatFromLocString playerstatsbygametype dom losses statvalue {0}", random.Next(48, 201)));
				this.method_76(string.Format("setStatFromLocString playerstatsbygametype dem losses statvalue {0}", random.Next(48, 201)));
				this.method_76(string.Format("setStatFromLocString playerstatsbygametype koth losses statvalue {0}", random.Next(48, 201)));
				this.method_76(string.Format("setStatFromLocString playerstatsbygametype gun losses statvalue {0}", random.Next(1, 41)));
				this.method_76(string.Format("setStatFromLocString playerstatsbygametype ctf losses statvalue {0}", random.Next(1, 41)));
				this.method_76(string.Format("setStatFromLocString playerstatsbygametype conf losses statvalue {0}", random.Next(1, 41)));
				this.method_76(string.Format("setStatFromLocString playerstatsbygametype oic losses statvalue {0}", random.Next(1, 41)));
				this.ixboxConsole_0.SetMemory(2218076872U, new byte[]
				{
					192,
					63
				});
				this.ixboxConsole_0.SetMemory(2218084018U, new byte[]
				{
					68,
					128,
					8,
					16,
					1,
					34,
					64,
					4
				});
				byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(11));
				this.ixboxConsole_0.SetMemory(2218037668U, bytes);
				byte[] bytes2 = BitConverter.GetBytes(Convert.ToInt32(random.Next(4000000, 20000001)));
				this.ixboxConsole_0.SetMemory(2218037728U, bytes2);
				byte[] bytes3 = BitConverter.GetBytes(Convert.ToInt32(random.Next(100000, 300001)));
				this.ixboxConsole_0.SetMemory(2218036480U, bytes3);
				byte[] bytes4 = BitConverter.GetBytes(Convert.ToInt32(random.Next(50000, 100001)));
				this.ixboxConsole_0.SetMemory(2218035922U, bytes4);
				byte[] bytes5 = BitConverter.GetBytes(Convert.ToInt32(random.Next(1280, 2145)));
				this.ixboxConsole_0.SetMemory(2218037986U, bytes5);
				byte[] bytes6 = BitConverter.GetBytes(Convert.ToInt32(random.Next(256, 501)));
				this.ixboxConsole_0.SetMemory(2218036594U, bytes6);
				byte[] bytes7 = BitConverter.GetBytes(Convert.ToInt32(random.Next(612725, 1856211)));
				this.ixboxConsole_0.SetMemory(2218037914U, bytes7);
				this.ixboxConsole_0.SetMemory(2218037670U, new byte[]
				{
					0,
					0,
					15,
					0,
					0,
					0,
					0,
					0,
					0,
					15,
					0,
					0,
					0,
					0,
					0,
					0,
					54,
					0,
					0,
					0,
					0,
					0,
					76,
					15,
					19
				});
				this.ixboxConsole_0.XNotify("Unlock All Given!");
			}
			DialogResult dialogResult3 = XtraMessageBox.Show("Do you want to apply colored gamertag classes?", "Quick Recovery", MessageBoxButtons.YesNo);
			if (dialogResult3 == DialogResult.Yes)
			{
				this.simpleButton511_Click(sender, null);
			}
			this.simpleButton500_Click(sender, null);
			this.ixboxConsole_0.XNotify("Quick Recovery Applied!");
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00039F28 File Offset: 0x00038128
		private void method_88(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"cg_fov " + this.numericUpDown19.Value.ToString()
			});
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00039F78 File Offset: 0x00038178
		private void method_89(object sender, EventArgs e)
		{
			if (this.simpleButton716.Text == "Super Speed [OFF]")
			{
				this.simpleButton716.Text = "Super Speed [ON]";
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"g_speed 650"
				});
			}
			else
			{
				this.simpleButton716.Text = "Super Speed [OFF]";
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					"g_speed 165"
				});
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0003A00C File Offset: 0x0003820C
		private void simpleButton715_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184600384U, new object[]
			{
				0,
				"cg_fov " + this.numericUpDown19.Value.ToString()
			});
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0003A05C File Offset: 0x0003825C
		private void simpleButton716_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184600384U, new object[]
			{
				0,
				"toggle g_speed 650 165"
			});
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0003A090 File Offset: 0x00038290
		private void simpleButton718_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184600384U, new object[]
			{
				0,
				"toggle bg_gravity 125 800"
			});
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0003A0C4 File Offset: 0x000382C4
		private void simpleButton719_Click(object sender, EventArgs e)
		{
			if (this.simpleButton719.Text == "Super Jump [OFF]")
			{
				this.simpleButton719.Text = "Super Jump [ON]";
				this.ixboxConsole_0.WriteFloat(2181053664U, 29999f);
			}
			else
			{
				this.simpleButton719.Text = "Super Jump [OFF]";
				this.ixboxConsole_0.WriteFloat(2181053664U, 39f);
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0003A134 File Offset: 0x00038334
		private void simpleButton720_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184600384U, new object[]
			{
				0,
				"fast_restart"
			});
			this.ixboxConsole_0.XNotify("Restarted Mission!");
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0003A178 File Offset: 0x00038378
		private void simpleButton717_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184600384U, new object[]
			{
				0,
				this.textEdit_157.Text
			});
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0003A1B4 File Offset: 0x000383B4
		private void method_90(string string_3, bool bool_1)
		{
			uint num = this.method_91(string_3);
			if (num > 0U)
			{
				if (bool_1)
				{
					this.ixboxConsole_0.WriteInt16(num + 64U, 1);
				}
				object[] arguments = new object[]
				{
					num
				};
				this.ixboxConsole_0.CallVoid("xboxkrnl.exe", 417, arguments);
			}
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0003A210 File Offset: 0x00038410
		private uint method_91(string string_3)
		{
			object[] arguments = new object[]
			{
				string_3
			};
			return this.ixboxConsole_0.Call<uint>("xam.xex", 1102, arguments);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0003A244 File Offset: 0x00038444
		private void simpleButton724_Click(object sender, EventArgs e)
		{
			this.bool_0 = true;
			string text = this.textEdit_158.Text;
			string hex = this.method_73(text);
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1058351946832039976/BO2RemoteRecovery.xex", "./BO2RemoteRecovery.xex");
			this.ixboxConsole_0.SendFile("./BO2RemoteRecovery.xex", "Hdd:\\BO2RemoteRecovery.xex");
			File.Delete("./BO2RemoteRecovery.xex");
			this.ixboxConsole_0.Call<uint>("xboxkrnl.exe", 409, new object[]
			{
				"Hdd:\\BO2RemoteRecovery.xex",
				8,
				0,
				0
			});
			this.ixboxConsole_0.DeleteFile("Hdd:\\BO2RemoteRecovery.xex");
			this.ixboxConsole_0.WriteByte(2175795328U, 1);
			this.ixboxConsole_0.WriteString(2175795329U, text);
			this.ixboxConsole_0.SetMemory(2175795345U, hexString(hex));
			string programName = this.ixboxConsole_0.DebugTarget.RunningProcessInfo.ProgramName;
			string text2 = programName.Replace("\\Device\\Harddisk0\\Partition1", "Hdd:");
			string text3 = text2;
			int length = text3.LastIndexOf("\\");
			this.ixboxConsole_0.Reboot(text2, text2.Substring(0, length), null, XboxRebootFlags.Title);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0003A384 File Offset: 0x00038584
		private void simpleButton726_Click(object sender, EventArgs e)
		{
			this.bool_0 = false;
			this.method_90("BO2RemoteRecovery.xex", true);
			this.ixboxConsole_0.XNotify("Undid Spoofing!");
			string programName = this.ixboxConsole_0.DebugTarget.RunningProcessInfo.ProgramName;
			string text = programName.Replace("\\Device\\Harddisk0\\Partition1", "Hdd:");
			string text2 = text;
			int length = text2.LastIndexOf("\\");
			this.ixboxConsole_0.Reboot(text, text.Substring(0, length), null, XboxRebootFlags.Title);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0003A40C File Offset: 0x0003860C
		private void simpleButton727_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"resetstats;updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.XNotify("Reset Stats!");
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00033C2C File Offset: 0x00031E2C
		private void simpleButton728_Click(object sender, EventArgs e)
		{
			this.method_76("setStatFromLocString cacloadouts customclassname 0 \"^H^H\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 1 \"^H^H\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 2 \"^H^H\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 3 \"^H^H\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 4 \"^H^H\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 5 \"^H^H\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 6 \"^H^H\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 7 \"^H^H\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 8 \"^H^H\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 9 \"^H^H\"");
			this.method_76("updategamerprofile;uploadstats");
			this.ixboxConsole_0.XNotify("Froze Classes!");
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0003A450 File Offset: 0x00038650
		private void simpleButton788_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.WriteByte(2210848536U, 1);
			this.NewBytes(2210849304U, 4);
			this.ixboxConsole_0.WriteInt32(2210849208U, int.MaxValue);
			Thread.Sleep(50);
			this.ixboxConsole_0.WriteByte(2210849400U, 1);
			this.NewBytes(2210849304U, 4);
			this.ixboxConsole_0.WriteInt32(2210850072U, int.MaxValue);
			this.ixboxConsole_0.XNotify("Given Probation!");
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0003A4D8 File Offset: 0x000386D8
		public void NewBytes(uint address, int Size)
		{
			this.ixboxConsole_0.SetMemory(address, new byte[Size]);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0003A4F8 File Offset: 0x000386F8
		private void simpleButton730_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"resetstats;updategamerprofile;uploadstats"
			});
			XtraMessageBox.Show("Stats are now reset, click OK when you have passed the reset stats prompt.");
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statSetByName RANKXP 1253874;updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.XNotify("Corrupted Account!");
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0003A570 File Offset: 0x00038770
		private void simpleButton796_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statsetbyname PLEVEL 2147483647;updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statsetbyname KILLS 2147483647;updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statsetbyname SCORE 2147483647;updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statsetbyname WINS 2147483647;updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statsetbyname HITS -167185920;updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statsetbyname RANKXP 2147483647;updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statsetbyname DEATHS 2147483647;updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"statsetbyname TIME_PLAYED_TOTAL 2147483647;updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.XNotify("Barracks Broken!");
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0003A6EC File Offset: 0x000388EC
		private void simpleButton797_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If it resets to a backup, try again. Eventually it will work but it's buggy.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0003A70C File Offset: 0x0003890C
		private void simpleButton739_Click(object sender, EventArgs e)
		{
			this.numericUpDown92.Value = 11m;
			this.numericUpDown93.Value = 1253874m;
			this.numericUpDown90.Value = 1253874m;
			this.numericUpDown91.Value = 50000m;
			this.numericUpDown89.Value = 2500m;
			this.numericUpDown87.Value = 50000m;
			this.numericUpDown88.Value = 2500m;
			this.numericUpDown84.Value = 0m;
			this.simpleButton500_Click(sender, null);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00033CC4 File Offset: 0x00031EC4
		private void simpleButton738_Click(object sender, EventArgs e)
		{
			this.method_76("setStatFromLocString cacloadouts customclassname 0 \"Custom 1\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 1 \"Custom 2\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 2 \"Custom 3\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 3 \"Custom 4\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 4 \"Custom 5\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 5 \"Custom 6\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 6 \"Custom 7\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 7 \"Custom 8\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 8 \"Custom 9\"");
			this.method_76("setStatFromLocString cacloadouts customclassname 9 \"Custom 10\"");
			this.method_76("updategamerprofile;uploadstats");
			this.ixboxConsole_0.XNotify("Unfroze Classes!");
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0003A7C4 File Offset: 0x000389C4
		private void simpleButton737_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.WriteByte(2210848536U, 0);
			this.ixboxConsole_0.WriteInt32(2210849304U, int.MaxValue);
			this.NewBytes(2210849208U, 4);
			Thread.Sleep(50);
			this.ixboxConsole_0.WriteByte(2210849400U, 0);
			this.ixboxConsole_0.WriteInt32(2210849304U, int.MaxValue);
			this.NewBytes(2210850072U, 4);
			this.ixboxConsole_0.XNotify("Removed Probation!");
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0003A84C File Offset: 0x00038A4C
		private void simpleButton740_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2181501328U, new object[]
			{
				"set thereisacow 1337;developer 1;developer_script 1;sv_cheats 1;set monkeytoy 0;spdevmap"
			});
			this.ixboxConsole_0.XNotify("You can now use the other options!");
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0003A888 File Offset: 0x00038A88
		private void simpleButton741_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2181501328U, new object[]
			{
				this.textEdit_170.Text
			});
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0003A8BC File Offset: 0x00038ABC
		private void simpleButton747_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2181501328U, new object[]
			{
				"map_restart"
			});
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0003A8E8 File Offset: 0x00038AE8
		private void simpleButton742_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2181501328U, new object[]
			{
				"cg_fov " + this.textEdit_169.Text
			});
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0003A924 File Offset: 0x00038B24
		private void simpleButton743_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2181501328U, new object[]
			{
				"g_speed " + this.textEdit_168.Text
			});
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0003A960 File Offset: 0x00038B60
		private void simpleButton753_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2181501328U, new object[]
			{
				"g_gravity " + this.textEdit_167.Text
			});
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0003A99C File Offset: 0x00038B9C
		private void simpleButton745_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2181501328U, new object[]
			{
				"ufo"
			});
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0003A9C8 File Offset: 0x00038BC8
		private void simpleButton746_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2181501328U, new object[]
			{
				"noclip"
			});
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0003A9F4 File Offset: 0x00038BF4
		private void simpleButton744_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2181501328U, new object[]
			{
				"god"
			});
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0003AA20 File Offset: 0x00038C20
		private void simpleButton748_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2181501328U, new object[]
			{
				"toggle r_fog 0 1"
			});
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0003AA4C File Offset: 0x00038C4C
		private void simpleButton750_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2181501328U, new object[]
			{
				"toggle r_fastsky"
			});
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0003AA78 File Offset: 0x00038C78
		private void simpleButton752_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2181501328U, new object[]
			{
				"give ammo"
			});
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0003AAA4 File Offset: 0x00038CA4
		private void simpleButton751_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2181501328U, new object[]
			{
				"give all"
			});
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0003AAD0 File Offset: 0x00038CD0
		private void simpleButton754_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2181501328U, new object[]
			{
				"take all"
			});
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0003AAFC File Offset: 0x00038CFC
		private void simpleButton749_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2181501328U, new object[]
			{
				"kill"
			});
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0003AB28 File Offset: 0x00038D28
		private void simpleButton755_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2181501328U, new object[]
			{
				"disconnect"
			});
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0003AB54 File Offset: 0x00038D54
		private void simpleButton771_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184441616U, new object[]
			{
				"developer 1;developer_script 1;sv_cheats 1"
			});
			this.ixboxConsole_0.XNotify("You can now use the other options!");
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0003AB90 File Offset: 0x00038D90
		private void simpleButton770_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184441616U, new object[]
			{
				this.textEdit_166.Text
			});
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0003ABC4 File Offset: 0x00038DC4
		private void simpleButton764_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184441616U, new object[]
			{
				"map_restart"
			});
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0003ABF0 File Offset: 0x00038DF0
		private void simpleButton769_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184441616U, new object[]
			{
				"cg_fov " + this.textEdit_165.Text
			});
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0003AC2C File Offset: 0x00038E2C
		private void simpleButton768_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184441616U, new object[]
			{
				"g_speed " + this.textEdit_164.Text
			});
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0003AC68 File Offset: 0x00038E68
		private void simpleButton758_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184441616U, new object[]
			{
				"g_gravity " + this.textEdit_163.Text
			});
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0003ACA4 File Offset: 0x00038EA4
		private void simpleButton766_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184441616U, new object[]
			{
				"ufo"
			});
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0003ACD0 File Offset: 0x00038ED0
		private void simpleButton765_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184441616U, new object[]
			{
				"noclip"
			});
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0003ACFC File Offset: 0x00038EFC
		private void simpleButton767_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184441616U, new object[]
			{
				"god"
			});
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0003AD28 File Offset: 0x00038F28
		private void simpleButton763_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184441616U, new object[]
			{
				"toggle r_fog 0 1"
			});
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0003AD54 File Offset: 0x00038F54
		private void simpleButton761_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184441616U, new object[]
			{
				"toggle r_fullbright"
			});
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0003AD80 File Offset: 0x00038F80
		private void simpleButton759_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184441616U, new object[]
			{
				"give ammo"
			});
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0003ADAC File Offset: 0x00038FAC
		private void simpleButton760_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184441616U, new object[]
			{
				"give all"
			});
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0003ADD8 File Offset: 0x00038FD8
		private void simpleButton757_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184441616U, new object[]
			{
				"take all"
			});
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0003AE04 File Offset: 0x00039004
		private void simpleButton762_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184441616U, new object[]
			{
				"kill"
			});
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0003AE30 File Offset: 0x00039030
		private void simpleButton756_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184441616U, new object[]
			{
				"disconnect"
			});
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0003AE5C File Offset: 0x0003905C
		private void simpleButton787_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185747400U, new object[]
			{
				0,
				"developer 1;developer_script 1;sv_cheats 1"
			});
			this.ixboxConsole_0.XNotify("You can now use the other options!");
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0003AEA0 File Offset: 0x000390A0
		private void simpleButton786_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185747400U, new object[]
			{
				0,
				this.textEdit_162.Text
			});
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0003AEDC File Offset: 0x000390DC
		private void simpleButton780_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185747400U, new object[]
			{
				0,
				"map_restart"
			});
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0003AF10 File Offset: 0x00039110
		private void simpleButton785_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185747400U, new object[]
			{
				0,
				"cg_fov " + this.textEdit_161.Text
			});
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0003AF54 File Offset: 0x00039154
		private void simpleButton784_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185747400U, new object[]
			{
				0,
				"g_speed " + this.textEdit_160.Text
			});
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0003AF98 File Offset: 0x00039198
		private void simpleButton774_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185747400U, new object[]
			{
				0,
				"g_gravity " + this.textEdit_159.Text
			});
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0003AFDC File Offset: 0x000391DC
		private void simpleButton782_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185747400U, new object[]
			{
				0,
				"ufo"
			});
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0003B010 File Offset: 0x00039210
		private void simpleButton781_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185747400U, new object[]
			{
				0,
				"noclip"
			});
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0003B044 File Offset: 0x00039244
		private void simpleButton783_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185747400U, new object[]
			{
				0,
				"god"
			});
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0003B078 File Offset: 0x00039278
		private void simpleButton779_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185747400U, new object[]
			{
				0,
				"notarget"
			});
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0003B0AC File Offset: 0x000392AC
		private void simpleButton777_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185747400U, new object[]
			{
				0,
				"toggle cg_widescreen"
			});
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0003B0E0 File Offset: 0x000392E0
		private void simpleButton775_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185747400U, new object[]
			{
				0,
				"give ammo"
			});
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0003B114 File Offset: 0x00039314
		private void simpleButton776_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185747400U, new object[]
			{
				0,
				"give all"
			});
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0003B148 File Offset: 0x00039348
		private void simpleButton773_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185747400U, new object[]
			{
				0,
				"take all"
			});
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0003B17C File Offset: 0x0003937C
		private void simpleButton778_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185747400U, new object[]
			{
				0,
				"kill"
			});
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0003B1B0 File Offset: 0x000393B0
		private void simpleButton772_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185747400U, new object[]
			{
				0,
				"disconnect"
			});
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0003B1E4 File Offset: 0x000393E4
		private void simpleButton734_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2208743761U, new byte[4]);
			byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown131.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743761U, bytes);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0003B23C File Offset: 0x0003943C
		private void simpleButton736_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2208743917U, new byte[4]);
			byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown132.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743917U, bytes);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0003B294 File Offset: 0x00039494
		private void simpleButton732_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2208743978U, new byte[4]);
			byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown129.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743978U, bytes);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0003B2EC File Offset: 0x000394EC
		private void simpleButton725_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2208743829U, new byte[4]);
			byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown111.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743829U, bytes);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0003B344 File Offset: 0x00039544
		private void simpleButton729_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2208744022U, new byte[4]);
			byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown126.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208744022U, bytes);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0003B39C File Offset: 0x0003959C
		private void simpleButton733_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2208743937U, new byte[4]);
			byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown130.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743937U, bytes);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0003B3F4 File Offset: 0x000395F4
		private void simpleButton731_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2208743897U, new byte[4]);
			byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown128.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743897U, bytes);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0003B44C File Offset: 0x0003964C
		private void simpleButton723_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2208744006U, new byte[4]);
			byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown68.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208744006U, bytes);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0003B4A4 File Offset: 0x000396A4
		private void simpleButton735_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2208743761U, new byte[4]);
			byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown131.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743761U, bytes);
			this.ixboxConsole_0.SetMemory(2208743917U, new byte[4]);
			byte[] bytes2 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown132.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743917U, bytes2);
			this.ixboxConsole_0.SetMemory(2208743978U, new byte[4]);
			byte[] bytes3 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown129.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743978U, bytes3);
			this.ixboxConsole_0.SetMemory(2208743829U, new byte[4]);
			byte[] bytes4 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown111.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743829U, bytes4);
			this.ixboxConsole_0.SetMemory(2208744022U, new byte[4]);
			byte[] bytes5 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown126.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208744022U, bytes5);
			this.ixboxConsole_0.SetMemory(2208743937U, new byte[4]);
			byte[] bytes6 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown130.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743937U, bytes6);
			this.ixboxConsole_0.SetMemory(2208743897U, new byte[4]);
			byte[] bytes7 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown128.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743897U, bytes7);
			this.ixboxConsole_0.SetMemory(2208744006U, new byte[4]);
			byte[] bytes8 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown68.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208744006U, bytes8);
			this.ixboxConsole_0.XNotify("Set All Stats!");
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0003B704 File Offset: 0x00039904
		private void simpleButton721_Click(object sender, EventArgs e)
		{
			this.numericUpDown131.Value = 30m;
			this.numericUpDown132.Value = 1253874m;
			this.numericUpDown129.Value = 1253874m;
			this.numericUpDown111.Value = 75m;
			this.numericUpDown126.Value = 50000m;
			this.numericUpDown130.Value = 50000m;
			this.numericUpDown128.Value = 2500m;
			this.numericUpDown68.Value = 2500m;
			this.ixboxConsole_0.SetMemory(2208743761U, new byte[4]);
			byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown131.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743761U, bytes);
			this.ixboxConsole_0.SetMemory(2208743917U, new byte[4]);
			byte[] bytes2 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown132.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743917U, bytes2);
			this.ixboxConsole_0.SetMemory(2208743978U, new byte[4]);
			byte[] bytes3 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown129.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743978U, bytes3);
			this.ixboxConsole_0.SetMemory(2208743829U, new byte[4]);
			byte[] bytes4 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown111.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743829U, bytes4);
			this.ixboxConsole_0.SetMemory(2208744022U, new byte[4]);
			byte[] bytes5 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown126.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208744022U, bytes5);
			this.ixboxConsole_0.SetMemory(2208743937U, new byte[4]);
			byte[] bytes6 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown130.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743937U, bytes6);
			this.ixboxConsole_0.SetMemory(2208743897U, new byte[4]);
			byte[] bytes7 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown128.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743897U, bytes7);
			this.ixboxConsole_0.SetMemory(2208744006U, new byte[4]);
			byte[] bytes8 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown68.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208744006U, bytes8);
			this.ixboxConsole_0.XNotify("Quick Stats Set!");
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0003BA04 File Offset: 0x00039C04
		private void simpleButton722_Click(object sender, EventArgs e)
		{
			this.numericUpDown131.Value = 0m;
			this.numericUpDown132.Value = 0m;
			this.numericUpDown129.Value = 0m;
			this.numericUpDown111.Value = 0m;
			this.numericUpDown126.Value = 0m;
			this.numericUpDown130.Value = 0m;
			this.numericUpDown128.Value = 0m;
			this.numericUpDown68.Value = 0m;
			this.ixboxConsole_0.SetMemory(2208743761U, new byte[4]);
			byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown131.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743761U, bytes);
			this.ixboxConsole_0.SetMemory(2208743917U, new byte[4]);
			byte[] bytes2 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown132.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743917U, bytes2);
			this.ixboxConsole_0.SetMemory(2208743978U, new byte[4]);
			byte[] bytes3 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown129.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743978U, bytes3);
			this.ixboxConsole_0.SetMemory(2208743829U, new byte[4]);
			byte[] bytes4 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown111.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743829U, bytes4);
			this.ixboxConsole_0.SetMemory(2208744022U, new byte[4]);
			byte[] bytes5 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown126.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208744022U, bytes5);
			this.ixboxConsole_0.SetMemory(2208743937U, new byte[4]);
			byte[] bytes6 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown130.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743937U, bytes6);
			this.ixboxConsole_0.SetMemory(2208743897U, new byte[4]);
			byte[] bytes7 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown128.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208743897U, bytes7);
			this.ixboxConsole_0.SetMemory(2208744006U, new byte[4]);
			byte[] bytes8 = BitConverter.GetBytes(Convert.ToUInt32(this.numericUpDown68.Value.ToString()));
			this.ixboxConsole_0.SetMemory(2208744006U, bytes8);
			this.ixboxConsole_0.XNotify("Reset Stats!");
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0003BCE4 File Offset: 0x00039EE4
		private void simpleButton803_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183717368U, new object[]
			{
				0,
				"sv_cheats 1"
			});
			this.ixboxConsole_0.CallVoid(2183717368U, new object[]
			{
				0,
				this.textEdit_171.Text
			});
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0003BD48 File Offset: 0x00039F48
		private void simpleButton789_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183717368U, new object[]
			{
				0,
				"cg_fov " + this.numericUpDown103.Value.ToString()
			});
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0003BD98 File Offset: 0x00039F98
		private void simpleButton791_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183717368U, new object[]
			{
				0,
				"toggle g_speed 650 165"
			});
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0003BDCC File Offset: 0x00039FCC
		private void simpleButton790_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183717368U, new object[]
			{
				0,
				"g_fallDamageMinHeight 9999"
			});
			this.ixboxConsole_0.CallVoid(2183717368U, new object[]
			{
				0,
				"toggle jump_height 999 39"
			});
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0003BE28 File Offset: 0x0003A028
		private void simpleButton792_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183717368U, new object[]
			{
				0,
				"toggle g_gravity 125 800"
			});
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0003BE5C File Offset: 0x0003A05C
		private void simpleButton793_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183717368U, new object[]
			{
				0,
				"toggle compasssize 1.5 1"
			});
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0003BE90 File Offset: 0x0003A090
		private void simpleButton794_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183717368U, new object[]
			{
				0,
				"fast_restart"
			});
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0003BEC4 File Offset: 0x0003A0C4
		private void simpleButton795_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183717368U, new object[]
			{
				0,
				"disconnect"
			});
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000077B0 File Offset: 0x000059B0
		private void groupControl9_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0003BEF8 File Offset: 0x0003A0F8
		private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBoxEdit1.SelectedIndex == 1)
			{
				this.textEdit_138.Visible = true;
				this.labelControl92.Visible = true;
			}
			if (this.comboBoxEdit1.SelectedIndex == 4)
			{
				this.textEdit_137.Visible = true;
				this.labelControl18.Visible = true;
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0003BF58 File Offset: 0x0003A158
		private void comboBoxEdit3_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBoxEdit1.SelectedIndex == 1)
			{
				this.textEdit_135.Visible = true;
				this.labelControl26.Visible = true;
			}
			if (this.comboBoxEdit1.SelectedIndex == 4)
			{
				this.textEdit_136.Visible = true;
				this.labelControl91.Visible = true;
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0003BFB8 File Offset: 0x0003A1B8
		private void simpleButton798_Click(object sender, EventArgs e)
		{
			this.simpleButton714_Click(sender, null);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0003BFD0 File Offset: 0x0003A1D0
		private void simpleButton799_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184248664U, new object[]
			{
				0,
				"toggle r_debuglayers"
			});
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0003C004 File Offset: 0x0003A204
		private void simpleButton800_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184248664U, new object[]
			{
				0,
				"toggle g_ai"
			});
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0003C038 File Offset: 0x0003A238
		private void simpleButton802_Click(object sender, EventArgs e)
		{
			if (this.numericUpDown123.Value == 1m)
			{
				this.ixboxConsole_0.SetMemory(2195469236U, Encoding.ASCII.GetBytes("5000"));
			}
			if (this.numericUpDown123.Value == 2m)
			{
				this.ixboxConsole_0.SetMemory(2195476700U, Encoding.ASCII.GetBytes("5000"));
			}
			if (this.numericUpDown123.Value == 3m)
			{
				this.ixboxConsole_0.SetMemory(2195484164U, Encoding.ASCII.GetBytes("5000"));
			}
			if (this.numericUpDown123.Value == 4m)
			{
				this.ixboxConsole_0.SetMemory(2195491628U, Encoding.ASCII.GetBytes("5000"));
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0003C120 File Offset: 0x0003A320
		private void simpleButton801_Click(object sender, EventArgs e)
		{
			if (this.numericUpDown123.Value == 1m)
			{
				this.ixboxConsole_0.WriteFloat(2195469236U, float.Parse("0"));
			}
			if (this.numericUpDown123.Value == 2m)
			{
				this.ixboxConsole_0.WriteFloat(2195476700U, float.Parse("0"));
			}
			if (this.numericUpDown123.Value == 3m)
			{
				this.ixboxConsole_0.WriteFloat(2195484164U, float.Parse("0"));
			}
			if (this.numericUpDown123.Value == 4m)
			{
				this.ixboxConsole_0.WriteFloat(2195491628U, float.Parse("0"));
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0003C1F4 File Offset: 0x0003A3F4
		private void simpleButton810_Click(object sender, EventArgs e)
		{
			byte value = Convert.ToByte(this.numericUpDown127.Value);
			byte[] bytes = BitConverter.GetBytes((short)value);
			this.ixboxConsole_0.SetMemory(this.PlayerLevel, bytes);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0003C230 File Offset: 0x0003A430
		private void simpleButton811_Click(object sender, EventArgs e)
		{
			byte value = Convert.ToByte(this.numericUpDown134.Value);
			byte[] bytes = BitConverter.GetBytes((short)value);
			this.ixboxConsole_0.SetMemory(this.Vigor, bytes);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0003C26C File Offset: 0x0003A46C
		private void simpleButton812_Click(object sender, EventArgs e)
		{
			byte value = Convert.ToByte(this.numericUpDown136.Value);
			byte[] bytes = BitConverter.GetBytes((short)value);
			this.ixboxConsole_0.SetMemory(this.Endurance, bytes);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0003C2A8 File Offset: 0x0003A4A8
		private void simpleButton813_Click(object sender, EventArgs e)
		{
			byte value = Convert.ToByte(this.numericUpDown135.Value);
			byte[] bytes = BitConverter.GetBytes((short)value);
			this.ixboxConsole_0.SetMemory(this.Vitality, bytes);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0003C2E4 File Offset: 0x0003A4E4
		private void simpleButton814_Click(object sender, EventArgs e)
		{
			byte value = Convert.ToByte(this.numericUpDown133.Value);
			byte[] bytes = BitConverter.GetBytes((short)value);
			this.ixboxConsole_0.SetMemory(this.Strength, bytes);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0003C320 File Offset: 0x0003A520
		private void simpleButton815_Click(object sender, EventArgs e)
		{
			byte value = Convert.ToByte(this.numericUpDown125.Value);
			byte[] bytes = BitConverter.GetBytes((short)value);
			this.ixboxConsole_0.SetMemory(this.Faith, bytes);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0003C35C File Offset: 0x0003A55C
		private void simpleButton804_Click(object sender, EventArgs e)
		{
			byte value = Convert.ToByte(this.numericUpDown124.Value);
			byte[] bytes = BitConverter.GetBytes((short)value);
			this.ixboxConsole_0.SetMemory(this.Attunement, bytes);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0003C398 File Offset: 0x0003A598
		private void simpleButton806_Click(object sender, EventArgs e)
		{
			byte value = Convert.ToByte(this.numericUpDown140.Value);
			byte[] bytes = BitConverter.GetBytes((short)value);
			this.ixboxConsole_0.SetMemory(this.Dexterity, bytes);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0003C3D4 File Offset: 0x0003A5D4
		private void simpleButton807_Click(object sender, EventArgs e)
		{
			byte value = Convert.ToByte(this.numericUpDown139.Value);
			byte[] bytes = BitConverter.GetBytes((short)value);
			this.ixboxConsole_0.SetMemory(this.Intelligence, bytes);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0003C410 File Offset: 0x0003A610
		private void simpleButton808_Click(object sender, EventArgs e)
		{
			byte value = Convert.ToByte(this.numericUpDown138.Value);
			byte[] bytes = BitConverter.GetBytes((short)value);
			this.ixboxConsole_0.SetMemory(this.Adaptability, bytes);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0003C44C File Offset: 0x0003A64C
		private void simpleButton805_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(3324845277U, new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			this.ixboxConsole_0.SetMemory(3324845304U, new byte[]
			{
				15,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			});
			this.ixboxConsole_0.SetMemory(3324845077U, new byte[]
			{
				99,
				99,
				99,
				99,
				99,
				99,
				99,
				99
			});
			this.ixboxConsole_0.SetMemory(3324845099U, new byte[]
			{
				6,
				99,
				99,
				99,
				99,
				99,
				99,
				99,
				99,
				99
			});
			this.ixboxConsole_0.XNotify("Player Has Been Modded!");
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0003C4F0 File Offset: 0x0003A6F0
		private void simpleButton829_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187578128U, new object[]
			{
				this.textEdit_172.Text
			});
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0003C524 File Offset: 0x0003A724
		private void simpleButton809_Click(object sender, EventArgs e)
		{
			foreach (uint address in this.healthstuff)
			{
				this.ixboxConsole_0.SetMemory(address, new byte[]
				{
					100
				});
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0003C56C File Offset: 0x0003A76C
		private void simpleButton816_Click(object sender, EventArgs e)
		{
			foreach (uint address in this.healthstuff)
			{
				this.ixboxConsole_0.SetMemory(address, new byte[]
				{
					1
				});
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0003C5B4 File Offset: 0x0003A7B4
		private void simpleButton817_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2204058237U, new byte[]
			{
				1
			});
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0003C5DC File Offset: 0x0003A7DC
		private void simpleButton818_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2204058237U, new byte[1]);
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0003C600 File Offset: 0x0003A800
		private void simpleButton819_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187578128U, new object[]
			{
				"recoil 0"
			});
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0003C62C File Offset: 0x0003A82C
		private void simpleButton820_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187578128U, new object[]
			{
				"recoil 1"
			});
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0003C658 File Offset: 0x0003A858
		private void simpleButton821_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187578128U, new object[]
			{
				"Nathaniel_hack"
			});
			this.ixboxConsole_0.CallVoid(2187578128U, new object[]
			{
				"Nathaniel_hack_alpha 0"
			});
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0003C6A4 File Offset: 0x0003A8A4
		private void simpleButton822_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187578128U, new object[]
			{
				"Nathaniel_hack"
			});
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0003C6D0 File Offset: 0x0003A8D0
		private void simpleButton823_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187578128U, new object[]
			{
				"show_fps"
			});
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0003C6D0 File Offset: 0x0003A8D0
		private void simpleButton824_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187578128U, new object[]
			{
				"show_fps"
			});
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0003C6FC File Offset: 0x0003A8FC
		private void simpleButton825_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187578128U, new object[]
			{
				"fog"
			});
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0003C6FC File Offset: 0x0003A8FC
		private void simpleButton826_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187578128U, new object[]
			{
				"fog"
			});
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0003C728 File Offset: 0x0003A928
		private void simpleButton827_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187578128U, new object[]
			{
				"set_time_of_day 12"
			});
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0003C754 File Offset: 0x0003A954
		private void simpleButton828_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187578128U, new object[]
			{
				"set_time_of_day 20"
			});
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0003C780 File Offset: 0x0003A980
		private void simpleButton832_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187578128U, new object[]
			{
				"give_player_n_weapons 7"
			});
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0003C7AC File Offset: 0x0003A9AC
		private void simpleButton831_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187578128U, new object[]
			{
				"give_player_n_weapons 0"
			});
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0003C7D8 File Offset: 0x0003A9D8
		private void simpleButton830_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187578128U, new object[]
			{
				"hood_explore_all"
			});
			this.ixboxConsole_0.CallVoid(2187578128U, new object[]
			{
				"hood_win_all"
			});
			this.ixboxConsole_0.CallVoid(2187578128U, new object[]
			{
				"activity_unlock_levels"
			});
			this.ixboxConsole_0.CallVoid(2187578128U, new object[]
			{
				"cheats_unlock_all"
			});
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0003C860 File Offset: 0x0003AA60
		private void simpleButton833_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(3260839472U, new byte[]
			{
				119,
				119,
				119,
				119
			});
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0003C890 File Offset: 0x0003AA90
		private void simpleButton834_Click(object sender, EventArgs e)
		{
			this.simpleButton810_Click(sender, null);
			this.simpleButton811_Click(sender, null);
			this.simpleButton812_Click(sender, null);
			this.simpleButton813_Click(sender, null);
			this.simpleButton814_Click(sender, null);
			this.simpleButton815_Click(sender, null);
			this.simpleButton804_Click(sender, null);
			this.simpleButton806_Click(sender, null);
			this.simpleButton807_Click(sender, null);
			this.simpleButton808_Click(sender, null);
			this.ixboxConsole_0.XNotify("Set All Applied!");
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0003C900 File Offset: 0x0003AB00
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.XNotify("Hello There!");
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0003C920 File Offset: 0x0003AB20
		private void simpleButton836_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton836.Text == "Chams [OFF]"))
			{
				this.simpleButton836.Text = "Chams [OFF]";
				this.ixboxConsole_0.SetMemory(2210750520U, new byte[]
				{
					63,
					128,
					0,
					0,
					63,
					128,
					0,
					0,
					63
				});
			}
			else
			{
				this.simpleButton836.Text = "Chams [ON]";
				this.ixboxConsole_0.SetMemory(2210750520U, new byte[]
				{
					79,
					128,
					0,
					0,
					63
				});
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0003C9AC File Offset: 0x0003ABAC
		private void timer_2_Tick(object sender, EventArgs e)
		{
			Random random = new Random();
			byte b = Convert.ToByte(random.Next(0, 255));
			byte b2 = Convert.ToByte(random.Next(0, 255));
			byte b3 = Convert.ToByte(random.Next(0, 255));
			byte b4 = Convert.ToByte(random.Next(0, 255));
			byte b5 = Convert.ToByte(random.Next(0, 255));
			byte b6 = Convert.ToByte(random.Next(0, 255));
			this.ixboxConsole_0.SetMemory(2210750520U, new byte[]
			{
				b,
				b2,
				b3,
				b4,
				b5,
				b6
			});
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0003CA6C File Offset: 0x0003AC6C
		private void simpleButton835_Click(object sender, EventArgs e)
		{
			if (this.timer_2.Enabled)
			{
				this.timer_2.Stop();
				this.ixboxConsole_0.SetMemory(2210750520U, new byte[]
				{
					63,
					128,
					0,
					0,
					63,
					128,
					0,
					0,
					63
				});
			}
			else
			{
				this.timer_2.Interval = 250;
				this.timer_2.Tick += this.timer_2_Tick;
				this.timer_2.Start();
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0003CAEC File Offset: 0x0003ACEC
		private void simpleButton837_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"clanname " + this.textEdit_173.Text + ";updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.WriteString(2227325884U, this.textEdit_174.Text);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0003CB50 File Offset: 0x0003AD50
		private string method_92()
		{
			return Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "";
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0003CB98 File Offset: 0x0003AD98
		private void simpleButton839_Click(object sender, EventArgs e)
		{
			string text = Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "";
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"userinfo \"\\clanabbrev\\\\name\\" + text + "\\xuid\\"
			});
			this.textEdit_4.Text = text;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0003CC1C File Offset: 0x0003AE1C
		private void simpleButton838_Click(object sender, EventArgs e)
		{
			this.textEdit_173.Text = "\"\"";
			this.textEdit_174.Text = this.method_92();
			this.simpleButton837_Click(sender, null);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0003CC54 File Offset: 0x0003AE54
		private void simpleButton840_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2175412476U, Form1.reverseBytes(this.textEdit_177.Text));
			string @string = Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "";
			this.textEdit_176.Text = this.method_73(this.textEdit_177.Text);
			this.ixboxConsole_0.WriteString(2227325884U, @string);
			this.ixboxConsole_0.XNotify("Successfully spoofed to : " + this.textEdit_177.Text);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0003CD08 File Offset: 0x0003AF08
		private void simpleButton842_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = XtraMessageBox.Show("Are you sure you want to permanently break this advanced warfare account? This action can NOT be undone.", "Warning", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				this.ixboxConsole_0.CallVoid(2185702272U, new object[]
				{
					0,
					"defaultstatsinit;updategamerprofile;uploadstats"
				});
				this.ixboxConsole_0.XNotify("Permanently broke Advanced Warfare account, restart game!\nIt will never be able to go past main screen again.");
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0003CD68 File Offset: 0x0003AF68
		private void simpleButton841_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2218084018U, new byte[]
			{
				68,
				128,
				8,
				16,
				1,
				34,
				64,
				4
			});
			this.ixboxConsole_0.XNotify("10 Classes Applied!");
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0003CDA8 File Offset: 0x0003AFA8
		private void simpleButton846_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"clanname " + this.textEdit_180.Text + ";updategamerprofile;uploadstats"
			});
			this.ixboxConsole_0.WriteString(2233677493U, this.textEdit_181.Text);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0003CE0C File Offset: 0x0003B00C
		private void simpleButton845_Click(object sender, EventArgs e)
		{
			this.textEdit_180.Text = "\"\"";
			this.textEdit_181.Text = this.method_92();
			this.simpleButton846_Click(sender, null);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0003CE44 File Offset: 0x0003B044
		private void simpleButton847_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"userinfo \\clanabbrev\\" + this.textEdit_182.Text + "\\name\\" + this.textEdit_183.Text
			});
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0003CE98 File Offset: 0x0003B098
		private void simpleButton844_Click(object sender, EventArgs e)
		{
			string text = this.method_92();
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"userinfo \\clanabbrev\\\\name\\" + text
			});
			this.textEdit_182.Text = "";
			this.textEdit_183.Text = text;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0003CEF8 File Offset: 0x0003B0F8
		private void simpleButton843_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2175412476U, Form1.reverseBytes(this.textEdit_179.Text));
			string @string = Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "";
			this.textEdit_178.Text = this.method_73(this.textEdit_179.Text);
			this.ixboxConsole_0.WriteString(2233677493U, @string);
			this.ixboxConsole_0.XNotify("Successfully spoofed to : " + this.textEdit_179.Text);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0003CFAC File Offset: 0x0003B1AC
		private void method_93(string string_3)
		{
			this.ixboxConsole_0.CallVoid(2183759696U, new object[]
			{
				0,
				string_3
			});
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0003CFDC File Offset: 0x0003B1DC
		private void simpleButton861_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183759696U, new object[]
			{
				0,
				this.textEdit_186.Text
			});
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0003D018 File Offset: 0x0003B218
		private void simpleButton860_Click(object sender, EventArgs e)
		{
			this.method_93("cg_fov " + this.textEdit_185.Text);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0003D040 File Offset: 0x0003B240
		private void simpleButton849_Click(object sender, EventArgs e)
		{
			this.method_93("g_gravity " + this.textEdit_184.Text);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0003D068 File Offset: 0x0003B268
		private void simpleButton857_Click(object sender, EventArgs e)
		{
			this.method_93("ufo");
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0003D080 File Offset: 0x0003B280
		private void simpleButton856_Click(object sender, EventArgs e)
		{
			this.method_93("noclip");
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0003D098 File Offset: 0x0003B298
		private void simpleButton858_Click(object sender, EventArgs e)
		{
			this.method_93("god");
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0003D0B0 File Offset: 0x0003B2B0
		private void simpleButton114_Click(object sender, EventArgs e)
		{
			this.method_93("toggle player_sustainammo");
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0003D0C8 File Offset: 0x0003B2C8
		private void simpleButton854_Click(object sender, EventArgs e)
		{
			this.method_93("toggle r_fog");
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0003D0E0 File Offset: 0x0003B2E0
		private void simpleButton851_Click(object sender, EventArgs e)
		{
			this.method_93("give all");
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0003D0F8 File Offset: 0x0003B2F8
		private void simpleButton848_Click(object sender, EventArgs e)
		{
			this.method_93("take all");
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0003D110 File Offset: 0x0003B310
		private void method_94(object sender, EventArgs e)
		{
			this.method_93("toggle cg_laserforceon");
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0003D128 File Offset: 0x0003B328
		private void simpleButton850_Click(object sender, EventArgs e)
		{
			this.method_93("ai axis delete");
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0003D140 File Offset: 0x0003B340
		private void simpleButton853_Click(object sender, EventArgs e)
		{
			this.method_93("toggle g_ai");
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0003D158 File Offset: 0x0003B358
		private void simpleButton855_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton855.Text == "Tracers [OFF]"))
			{
				this.simpleButton855.Text = "Tracers [OFF]";
				this.method_93("cg_tracerSpeed 0000;cg_tracerwidth 0;cg_tracerlength 0");
			}
			else
			{
				this.simpleButton855.Text = "Tracers [ON]";
				this.method_93("cg_tracerSpeed 0150;cg_tracerwidth 5;cg_tracerlength 999");
			}
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0003D1B4 File Offset: 0x0003B3B4
		private void simpleButton859_Click(object sender, EventArgs e)
		{
			if (this.simpleButton859.Text == "Rapid Fire [OFF]")
			{
				this.simpleButton859.Text = "Rapid Fire [ON]";
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"give perk_doubletap_mp"
				});
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"perk_weapRateMultiplier 0.001;player_burstFireCooldown 0"
				});
			}
			else
			{
				this.simpleButton859.Text = "Rapid Fire [OFF]";
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"perk_weapRateMultiplier 1;player_burstFireCooldown 1"
				});
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0003D270 File Offset: 0x0003B470
		private void method_95(object sender, EventArgs e)
		{
			XtraMessageBox.Show("Requires Double Tap Perk. Use on one shot weapons may be buggy.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0003D290 File Offset: 0x0003B490
		private void simpleButton863_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"give dogs_mp"
			});
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0003D2C4 File Offset: 0x0003B4C4
		private void simpleButton864_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"give all"
			});
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0003D2F8 File Offset: 0x0003B4F8
		private void simpleButton862_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"take all"
			});
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0003D32C File Offset: 0x0003B52C
		private void simpleButton865_Click(object sender, EventArgs e)
		{
			if (this.textEdit_133.Text == "")
			{
				XtraMessageBox.Show("For this you need to have a path filled in above where your games are located.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				if (!this.textEdit_133.Text.Contains("."))
				{
					DialogResult dialogResult = XtraMessageBox.Show("Do you want to remove your already added games?", "Guido's Console Tool", MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes)
					{
						if (!this.textEdit_133.Text.EndsWith("\\"))
						{
							this.textEdit_133.Text = this.textEdit_133.Text + "\\";
						}
						this.listBox7.Items.Clear();
						File.Delete("GameNames.txt");
						File.AppendAllText("GameNames.txt", "");
						File.Delete("GameLauncher.ini");
						IXboxFiles xboxFiles = this.ixboxConsole_0.DirectoryFiles(this.textEdit_133.Text);
                        IEnumerator enumerator = xboxFiles.GetEnumerator();
						
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							IXboxFile xboxFile = (IXboxFile)obj;
							if (!xboxFile.Name.Contains("."))
							{
								this.listBox7.Items.Add(xboxFile.Name.Split(new char[]
								{
									"\\".Last<char>()
								}).Last<string>());
								this.ini_2.Write(xboxFile.Name.Split(new char[]
								{
									"\\".Last<char>()
								}).Last<string>() + "p1", "Path1", xboxFile.Name + "\\default.xex");
								this.ini_2.Write(xboxFile.Name.Split(new char[]
								{
									"\\".Last<char>()
								}).Last<string>() + "p2", "Path2", xboxFile.Name);
								string contents = xboxFile.Name.Split(new char[]
								{
									"\\".Last<char>()
								}).Last<string>() + Environment.NewLine;
								File.AppendAllText("GameNames.txt", contents);
							}
						}
						return;
						
					}
					if (!this.textEdit_133.Text.EndsWith("\\"))
					{
						this.textEdit_133.Text = this.textEdit_133.Text + "\\";
					}
					IXboxFiles xboxFiles2 = this.ixboxConsole_0.DirectoryFiles(this.textEdit_133.Text);
                    IEnumerator enumerator2 = xboxFiles2.GetEnumerator();
					
					while (enumerator2.MoveNext())
					{
						object obj2 = enumerator2.Current;
						IXboxFile xboxFile2 = (IXboxFile)obj2;
						if (!xboxFile2.Name.Contains("."))
						{
							this.listBox7.Items.Add(xboxFile2.Name.Split(new char[]
							{
								"\\".Last<char>()
							}).Last<string>());
							this.ini_2.Write(xboxFile2.Name.Split(new char[]
							{
								"\\".Last<char>()
							}).Last<string>() + "p1", "Path1", xboxFile2.Name + "\\default.xex");
							this.ini_2.Write(xboxFile2.Name.Split(new char[]
							{
								"\\".Last<char>()
							}).Last<string>() + "p2", "Path2", xboxFile2.Name);
							string contents2 = xboxFile2.Name.Split(new char[]
							{
								"\\".Last<char>()
							}).Last<string>() + Environment.NewLine;
							File.AppendAllText("GameNames.txt", contents2);
						}
					}
					return;
					
				}
				XtraMessageBox.Show("Folder to scan can not be a file.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0003D77C File Offset: 0x0003B97C
		private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listBox7.SelectedItem != null)
			{
				this.textEdit_134.Text = this.listBox7.SelectedItem.ToString();
				this.textEdit_133.Text = this.ini_2.Read(this.listBox7.SelectedItem.ToString() + "p2", "Path2");
				this.textEdit_132.Text = this.ini_2.Read(this.listBox7.SelectedItem.ToString() + "p1", "Path1").Split(new char[]
				{
					"\\".Last<char>()
				}).Last<string>();
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0003D840 File Offset: 0x0003BA40
		private void comboBoxEdit23_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.textEdit_187.Visible = false;
			this.labelControl119.Visible = false;
			if (this.comboBoxEdit23.SelectedIndex == 8)
			{
				this.textEdit_187.Visible = true;
				this.labelControl119.Visible = true;
				this.labelControl119.Text = "Command:";
			}
			if (this.comboBoxEdit23.SelectedIndex == 4)
			{
				this.textEdit_187.Visible = true;
				this.labelControl119.Visible = true;
				this.labelControl119.Text = "FOV:";
			}
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0003D8D8 File Offset: 0x0003BAD8
		private void simpleButton866_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit23.SelectedIndex == -1 || this.comboBoxEdit22.SelectedIndex == -1)
			{
				XtraMessageBox.Show("You haven't selected either a bind or a function.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				string str = "";
				string str2 = "";
				if (this.comboBoxEdit22.SelectedIndex == 0)
				{
					str = "BUTTON_RTRIG";
				}
				if (this.comboBoxEdit22.SelectedIndex == 1)
				{
					str = "BUTTON_LTRIG";
				}
				if (this.comboBoxEdit22.SelectedIndex == 2)
				{
					str = "BUTTON_RSHLDR";
				}
				if (this.comboBoxEdit22.SelectedIndex == 3)
				{
					str = "BUTTON_LSHLDR";
				}
				if (this.comboBoxEdit22.SelectedIndex == 4)
				{
					str = "BUTTON_RSTICK";
				}
				if (this.comboBoxEdit22.SelectedIndex == 5)
				{
					str = "BUTTON_LSTICK";
				}
				if (this.comboBoxEdit22.SelectedIndex == 6)
				{
					str = "BUTTON_A";
				}
				if (this.comboBoxEdit22.SelectedIndex == 7)
				{
					str = "BUTTON_B";
				}
				if (this.comboBoxEdit22.SelectedIndex == 8)
				{
					str = "BUTTON_X";
				}
				if (this.comboBoxEdit22.SelectedIndex == 9)
				{
					str = "BUTTON_Y";
				}
				if (this.comboBoxEdit22.SelectedIndex == 10)
				{
					str = "DPAD_UP";
				}
				if (this.comboBoxEdit22.SelectedIndex == 11)
				{
					str = "DPAD_DOWN";
				}
				if (this.comboBoxEdit22.SelectedIndex == 12)
				{
					str = "DPAD_LEFT";
				}
				if (this.comboBoxEdit22.SelectedIndex == 13)
				{
					str = "DPAD_RIGHT";
				}
				if (this.comboBoxEdit22.SelectedIndex == 14)
				{
					str = "APAD_UP";
				}
				if (this.comboBoxEdit22.SelectedIndex == 15)
				{
					str = "APAD_DOWN";
				}
				if (this.comboBoxEdit22.SelectedIndex == 16)
				{
					str = "APAD_LEFT";
				}
				if (this.comboBoxEdit22.SelectedIndex == 17)
				{
					str = "APAD_RIGHT";
				}
				if (this.comboBoxEdit22.SelectedIndex == 18)
				{
					str = "BUTTON_BACK";
				}
				if (this.comboBoxEdit22.SelectedIndex == 19)
				{
					str = "BUTTON_START";
				}
				if (this.comboBoxEdit23.SelectedIndex == 0)
				{
					str2 = "god";
				}
				if (this.comboBoxEdit23.SelectedIndex == 1)
				{
					str2 = "demigod";
				}
				if (this.comboBoxEdit23.SelectedIndex == 2)
				{
					str2 = "noclip";
				}
				if (this.comboBoxEdit23.SelectedIndex == 3)
				{
					str2 = "ufo";
				}
				if (this.comboBoxEdit23.SelectedIndex == 4)
				{
					str2 = "cg_fov " + this.textEdit_187.Text;
				}
				if (this.comboBoxEdit23.SelectedIndex == 5)
				{
					str2 = "give ammo";
				}
				if (this.comboBoxEdit23.SelectedIndex == 6)
				{
					str2 = "give dogs_mp";
				}
				if (this.comboBoxEdit23.SelectedIndex == 7)
				{
					str2 = "give artillery_mp";
				}
				if (this.comboBoxEdit23.SelectedIndex == 8)
				{
					str2 = this.textEdit_187.Text;
				}
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"bind " + str + " " + str2
				});
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x000077B0 File Offset: 0x000059B0
		private void comboBoxEdit22_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0003DC20 File Offset: 0x0003BE20
		private void simpleButton867_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"toggle vehicle_perk_leadfoot_speed_increase 1 500"
			});
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0003DC54 File Offset: 0x0003BE54
		private void simpleButton869_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"set g_teamname_allies " + this.textEdit_189.Text
			});
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"set g_teamname_axis " + this.textEdit_188.Text
			});
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0003DCD0 File Offset: 0x0003BED0
		private void simpleButton870_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"kick " + this.textEdit_190.Text
			});
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0003DD14 File Offset: 0x0003BF14
		private void simpleButton868_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"toggle perk_vehicleReloadReduction 0.001 1"
			});
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x000077B0 File Offset: 0x000059B0
		private void xtraTabPage22_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0003DD48 File Offset: 0x0003BF48
		private void simpleButton871_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"toggle player_sustainammo"
			});
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x000077B0 File Offset: 0x000059B0
		private void xtraTabControl1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000077B0 File Offset: 0x000059B0
		private void textEdit_191_EditValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0003DD7C File Offset: 0x0003BF7C
		private void simpleButton872_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"joinplayersessionbyxuid " + this.method_73(this.textEdit_191.Text)
			});
			this.ixboxConsole_0.XNotify("Attempted To Join : " + this.textEdit_191.Text);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0003DDE8 File Offset: 0x0003BFE8
		private void simpleButton874_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"xsendinvitetoxuid " + this.method_73(this.textEdit_193.Text)
			});
			this.ixboxConsole_0.XNotify("Sent Invite To : " + this.textEdit_193.Text);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0003DE54 File Offset: 0x0003C054
		private void simpleButton875_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"xaddfriend " + this.textEdit_192.Text
			});
			this.ixboxConsole_0.XNotify("Sent Friend Request To : " + this.textEdit_192.Text);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0003DEB8 File Offset: 0x0003C0B8
		private void simpleButton873_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"xstopparty"
			});
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000077B0 File Offset: 0x000059B0
		private void xtraTabPage7_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0003DEEC File Offset: 0x0003C0EC
		private void simpleButton876_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton876.Text == "Tracers [OFF]"))
			{
				this.simpleButton876.Text = "Tracers [OFF]";
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"cg_tracerSpeed 0000;cg_tracerwidth 0;cg_tracerlength 0"
				});
			}
			else
			{
				this.simpleButton876.Text = "Tracers [ON]";
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"cg_tracerSpeed 0050;cg_tracerwidth 9;cg_tracerlength 999"
				});
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0003DF80 File Offset: 0x0003C180
		private void timer_3_Tick(object sender, EventArgs e)
		{
			if (this.ixboxConsole_0.GetMemory(2210706072U, 1U)[0] == 1)
			{
				this.ixboxConsole_0.CallVoid(2185237984U, new object[]
				{
					0,
					string.Format("cmd mr {0} -1 killserverpc", this.ixboxConsole_0.ReadInt32(2193708888U))
				});
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0003DFE8 File Offset: 0x0003C1E8
		private void simpleButton877_Click(object sender, EventArgs e)
		{
			if (this.timer_3.Enabled)
			{
				this.timer_3.Enabled = false;
				this.ixboxConsole_0.XNotify("Endgame Looper Disabled!");
			}
			else
			{
				this.timer_3.Interval = 3000;
				this.timer_3.Tick += this.timer_3_Tick;
				this.timer_3.Enabled = true;
				this.ixboxConsole_0.XNotify("Endgame Looper Enabled!");
			}
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x000077B0 File Offset: 0x000059B0
		private void comboBoxEdit16_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x000077B0 File Offset: 0x000059B0
		private void xtraTabPage41_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0003E068 File Offset: 0x0003C268
		private void simpleButton878_Click(object sender, EventArgs e)
		{
			object[] array = new object[2];
			array[0] = 0;
			object[] array2 = array;
			array2[1] = string.Concat(new string[]
			{
				"userinfo \"\\clanabbrev\\",
				"^H^H",
				"\\name\\",
				this.textEdit_70.Text,
				"\\invited\\1\""
			});
			this.ixboxConsole_0.CallVoid(2183628512U, array2);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0003E0D8 File Offset: 0x0003C2D8
		private void simpleButton879_Click(object sender, EventArgs e)
		{
			this.method_59("UwU");
			Thread.Sleep(1000);
			this.method_59("^F^H");
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				";statwriteddl clantagstats clanname ^F^H;"
			});
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0003E12C File Offset: 0x0003C32C
		private void simpleButton880_Click(object sender, EventArgs e)
		{
			this.method_59("^H\u007f\u007f\a$floatz");
			this.simpleButton411_Click(sender, null);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0003E14C File Offset: 0x0003C34C
		private void simpleButton533_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "gsc files (*.gsc)|*.gsc";
			openFileDialog.FileName = Path.GetFileName(openFileDialog.FileName);
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.listBox_0.Items.Add(openFileDialog.FileName);
			}
		}

        internal sealed class PrivateImplementationDetails
        {
            internal static uint ComputeStringHash(string s)
            {
                uint num = new uint();
                if (s != null)
                {
                    num = 0x811c9dc5;
                    for (int i = 0; i < s.Length; i++)
                    {
                        num = (s[i] ^ num) * 0x1000193;
                    }
                }
                return num;
            }
        }


        // Token: 0x060004CE RID: 1230 RVA: 0x0003E1A4 File Offset: 0x0003C3A4
        private uint method_96(string string_3)
		{
			uint num = PrivateImplementationDetails.ComputeStringHash(string_3);
			if (num > 0x48AB23A7U)
			{
				if (num > 1859819856U)
				{
					if (num != 3170642895U)
					{
						if (num != 3406671180U)
						{
							if (num == 3604132185U)
							{
								if (string_3 == "_sticky_grenade.gsc")
								{
									return 2199829980U;
								}
							}
						}
						else if (string_3 == "_explosive_bolt.gsc")
						{
							return 2199829680U;
						}
					}
					else if (string_3 == "_shellshock.gsc")
					{
						return 2199830520U;
					}
				}
				else if (num != 1748925554U)
				{
					if (num != 1761167560U)
					{
						if (num == 1859819856U)
						{
							if (string_3 == "_dev.gsc")
							{
								return 2199830184U;
							}
						}
					}
					else if (string_3 == "_sensor_grenade.gsc")
					{
						return 2199829908U;
					}
				}
				else if (string_3 == "_acousticsensor.gsc")
				{
					return 2199829428U;
				}
			}
			else if (num <= 447815947U)
			{
				if (num != 340118543U)
				{
					if (num == 447815947U)
					{
						if (string_3 == "_globalentities.gsc")
						{
							return 2199830232U;
						}
					}
				}
				else if (string_3 == "_ambientpackage.gsc")
				{
					return 2199829440U;
				}
			}
			else if (num != 966429941U)
			{
				if (num != 1028874588U)
				{
					if (num == 1219175335U)
					{
						if (string_3 == "_development_dvars.gsc")
						{
							return 2199829632U;
						}
					}
				}
				else if (string_3 == "_clientids.gsc")
				{
					return 2199830136U;
				}
			}
			else if (string_3 == "_rank.gsc")
			{
				return 2199830484U;
			}
			return 0U;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0003E37C File Offset: 0x0003C57C
		private void simpleButton881_Click(object sender, EventArgs e)
		{
			if (this.listBox_0.Items.Count > 8)
			{
				XtraMessageBox.Show("You can't inject more than 8 files.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				int count = this.listBox_0.Items.Count;
				List<string> list = new List<string>();
				foreach (object obj in this.listBox_0.Items)
				{
					string item = (string)obj;
					list.Add(item);
				}
				if (count == 1)
				{
					uint uintfromd = this.GETUINTFROMD(1076887553U);
					byte[] array = File.ReadAllBytes(list[0]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[0].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd, new byte[array.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd, array);
				}
				if (count == 2)
				{
					uint uintfromd2 = this.GETUINTFROMD(1076887553U);
					byte[] array2 = File.ReadAllBytes(list[0]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[0].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd2).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd2, new byte[array2.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd2, array2);
					uint uintfromd3 = this.GETUINTFROMD(uintfromd2 + (uint)(array2.Length + 1) + 1U);
					byte[] array3 = File.ReadAllBytes(list[1]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[1].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd3).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd3, new byte[array3.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd3, array3);
				}
				if (count == 3)
				{
					uint uintfromd4 = this.GETUINTFROMD(1076887553U);
					byte[] array4 = File.ReadAllBytes(list[0]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[0].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd4).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd4, new byte[array4.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd4, array4);
					uint uintfromd5 = this.GETUINTFROMD(uintfromd4 + (uint)(array4.Length + 1) + 1U);
					byte[] array5 = File.ReadAllBytes(list[1]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[1].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd5).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd5, new byte[array5.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd5, array5);
					uint uintfromd6 = this.GETUINTFROMD(uintfromd5 + (uint)(array5.Length + 1) + 1U);
					byte[] array6 = File.ReadAllBytes(list[2]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[2].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd6).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd6, new byte[array6.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd6, array6);
				}
				if (count == 4)
				{
					uint uintfromd7 = this.GETUINTFROMD(1076887553U);
					byte[] array7 = File.ReadAllBytes(list[0]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[0].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd7).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd7, new byte[array7.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd7, array7);
					uint uintfromd8 = this.GETUINTFROMD(uintfromd7 + (uint)(array7.Length + 1) + 1U);
					byte[] array8 = File.ReadAllBytes(list[1]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[1].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd8).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd8, new byte[array8.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd8, array8);
					uint uintfromd9 = this.GETUINTFROMD(uintfromd8 + (uint)(array8.Length + 1) + 1U);
					byte[] array9 = File.ReadAllBytes(list[2]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[2].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd9).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd9, new byte[array9.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd9, array9);
					uint uintfromd10 = this.GETUINTFROMD(uintfromd9 + (uint)(array9.Length + 1) + 1U);
					byte[] array10 = File.ReadAllBytes(list[3]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[3].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd10).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd10, new byte[array10.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd10, array10);
				}
				if (count == 5)
				{
					uint uintfromd11 = this.GETUINTFROMD(1076887553U);
					byte[] array11 = File.ReadAllBytes(list[0]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[0].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd11).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd11, new byte[array11.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd11, array11);
					uint uintfromd12 = this.GETUINTFROMD(uintfromd11 + (uint)(array11.Length + 1) + 1U);
					byte[] array12 = File.ReadAllBytes(list[1]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[1].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd12).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd12, new byte[array12.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd12, array12);
					uint uintfromd13 = this.GETUINTFROMD(uintfromd12 + (uint)(array12.Length + 1) + 1U);
					byte[] array13 = File.ReadAllBytes(list[2]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[2].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd13).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd13, new byte[array13.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd13, array13);
					uint uintfromd14 = this.GETUINTFROMD(uintfromd13 + (uint)(array13.Length + 1) + 1U);
					byte[] array14 = File.ReadAllBytes(list[3]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[3].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd14).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd14, new byte[array14.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd14, array14);
					uint uintfromd15 = this.GETUINTFROMD(uintfromd14 + (uint)(array14.Length + 1) + 1U);
					byte[] array15 = File.ReadAllBytes(list[4]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[4].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd15).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd15, new byte[array15.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd15, array15);
				}
				if (count == 6)
				{
					uint uintfromd16 = this.GETUINTFROMD(1076887553U);
					byte[] array16 = File.ReadAllBytes(list[0]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[0].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd16).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd16, new byte[array16.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd16, array16);
					uint uintfromd17 = this.GETUINTFROMD(uintfromd16 + (uint)(array16.Length + 1) + 1U);
					byte[] array17 = File.ReadAllBytes(list[1]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[1].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd17).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd17, new byte[array17.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd17, array17);
					uint uintfromd18 = this.GETUINTFROMD(uintfromd17 + (uint)(array17.Length + 1) + 1U);
					byte[] array18 = File.ReadAllBytes(list[2]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[2].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd18).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd18, new byte[array18.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd18, array18);
					uint uintfromd19 = this.GETUINTFROMD(uintfromd18 + (uint)(array18.Length + 1) + 1U);
					byte[] array19 = File.ReadAllBytes(list[3]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[3].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd19).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd19, new byte[array19.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd19, array19);
					uint uintfromd20 = this.GETUINTFROMD(uintfromd19 + (uint)(array19.Length + 1) + 1U);
					byte[] array20 = File.ReadAllBytes(list[4]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[4].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd20).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd20, new byte[array20.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd20, array20);
					uint uintfromd21 = this.GETUINTFROMD(uintfromd20 + (uint)(array20.Length + 1) + 1U);
					byte[] array21 = File.ReadAllBytes(list[5]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[5].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd21).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd21, new byte[array21.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd21, array21);
				}
				if (count == 7)
				{
					uint uintfromd22 = this.GETUINTFROMD(1076887553U);
					byte[] array22 = File.ReadAllBytes(list[0]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[0].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd22).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd22, new byte[array22.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd22, array22);
					uint uintfromd23 = this.GETUINTFROMD(uintfromd22 + (uint)(array22.Length + 1) + 1U);
					byte[] array23 = File.ReadAllBytes(list[1]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[1].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd23).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd23, new byte[array23.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd23, array23);
					uint uintfromd24 = this.GETUINTFROMD(uintfromd23 + (uint)(array23.Length + 1) + 1U);
					byte[] array24 = File.ReadAllBytes(list[2]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[2].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd24).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd24, new byte[array24.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd24, array24);
					uint uintfromd25 = this.GETUINTFROMD(uintfromd24 + (uint)(array24.Length + 1) + 1U);
					byte[] array25 = File.ReadAllBytes(list[3]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[3].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd25).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd25, new byte[array25.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd25, array25);
					uint uintfromd26 = this.GETUINTFROMD(uintfromd25 + (uint)(array25.Length + 1) + 1U);
					byte[] array26 = File.ReadAllBytes(list[4]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[4].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd26).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd26, new byte[array26.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd26, array26);
					uint uintfromd27 = this.GETUINTFROMD(uintfromd26 + (uint)(array26.Length + 1) + 1U);
					byte[] array27 = File.ReadAllBytes(list[5]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[5].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd27).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd27, new byte[array27.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd27, array27);
					uint uintfromd28 = this.GETUINTFROMD(uintfromd27 + (uint)(array27.Length + 1) + 1U);
					byte[] array28 = File.ReadAllBytes(list[6]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[6].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd28).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd28, new byte[array28.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd28, array28);
				}
				if (count == 8)
				{
					uint uintfromd29 = this.GETUINTFROMD(1076887553U);
					byte[] array29 = File.ReadAllBytes(list[0]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[0].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd29).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd29, new byte[array29.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd29, array29);
					uint uintfromd30 = this.GETUINTFROMD(uintfromd29 + (uint)(array29.Length + 1) + 1U);
					byte[] array30 = File.ReadAllBytes(list[1]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[1].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd30).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd30, new byte[array30.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd30, array30);
					uint uintfromd31 = this.GETUINTFROMD(uintfromd30 + (uint)(array30.Length + 1) + 1U);
					byte[] array31 = File.ReadAllBytes(list[2]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[2].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd31).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd31, new byte[array31.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd31, array31);
					uint uintfromd32 = this.GETUINTFROMD(uintfromd31 + (uint)(array31.Length + 1) + 1U);
					byte[] array32 = File.ReadAllBytes(list[3]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[3].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd32).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd32, new byte[array32.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd32, array32);
					uint uintfromd33 = this.GETUINTFROMD(uintfromd32 + (uint)(array32.Length + 1) + 1U);
					byte[] array33 = File.ReadAllBytes(list[4]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[4].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd33).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd33, new byte[array33.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd33, array33);
					uint uintfromd34 = this.GETUINTFROMD(uintfromd33 + (uint)(array33.Length + 1) + 1U);
					byte[] array34 = File.ReadAllBytes(list[5]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[5].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd34).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd34, new byte[array34.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd34, array34);
					uint uintfromd35 = this.GETUINTFROMD(uintfromd34 + (uint)(array34.Length + 1) + 1U);
					byte[] array35 = File.ReadAllBytes(list[6]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[6].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd35).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd35, new byte[array35.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd35, array35);
					uint uintfromd36 = this.GETUINTFROMD(uintfromd35 + (uint)(array35.Length + 1) + 1U);
					byte[] array36 = File.ReadAllBytes(list[7]);
					this.ixboxConsole_0.SetMemory(this.method_96(list[7].Split(new char[]
					{
						"\\".Last<char>()
					}).Last<string>()), BitConverter.GetBytes(uintfromd36).Reverse<byte>().ToArray<byte>());
					this.ixboxConsole_0.SetMemory(uintfromd36, new byte[array36.Length + 1]);
					this.ixboxConsole_0.SetMemory(uintfromd36, array36);
				}
				this.ixboxConsole_0.XNotify("Succesfully Injected GSC Menu!");
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0003F89C File Offset: 0x0003DA9C
		private void simpleButton882_Click(object sender, EventArgs e)
		{
			this.listBox_0.Items.Clear();
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x000077B0 File Offset: 0x000059B0
		private void xtraTabPage34_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0003F8BC File Offset: 0x0003DABC
		private void simpleButton883_Click(object sender, EventArgs e)
		{
			List<string> list = new List<string>();
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < 18; i++)
			{
				string text = Encoding.ASCII.GetString(this.ixboxConsole_0.GetMemory((uint)(-1006386264 + 328 * i), 15U)).TrimEnd(new char[1]);
				string text2 = BitConverter.ToString(this.ixboxConsole_0.GetMemory((uint)(-1006386142 + 328 * i), 6U)).Replace("-", "");
				if (text != "")
				{
					num2++;
				}
				if (text2.StartsWith("0022"))
				{
					list.Add(text);
					num++;
				}
			}
			string text3 = "";
			foreach (string str in list)
			{
				text3 = text3 + str + Environment.NewLine;
			}
			XtraMessageBox.Show(string.Concat(new string[]
			{
				"Possible RGH Users Found:\n",
				text3,
				"\nOut of ",
				num2.ToString(),
				" clients ",
				num.ToString(),
				" are on an RGH."
			}));
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0003FA24 File Offset: 0x0003DC24
		private void simpleButton884_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit15.SelectedIndex == 0)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"ui_mapname mp_airfield"
				});
			}
			if (this.comboBoxEdit15.SelectedIndex == 1)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"ui_mapname mp_asylum"
				});
			}
			if (this.comboBoxEdit15.SelectedIndex == 2)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"ui_mapname mp_castle"
				});
			}
			if (this.comboBoxEdit15.SelectedIndex == 3)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"ui_mapname mp_shrine"
				});
			}
			if (this.comboBoxEdit15.SelectedIndex == 4)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"ui_mapname mp_courtyard"
				});
			}
			if (this.comboBoxEdit15.SelectedIndex == 5)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"ui_mapname mp_dome"
				});
			}
			if (this.comboBoxEdit15.SelectedIndex == 6)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"ui_mapname mp_downfall"
				});
			}
			if (this.comboBoxEdit15.SelectedIndex == 7)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"ui_mapname mp_hangar"
				});
			}
			if (this.comboBoxEdit15.SelectedIndex == 8)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"ui_mapname mp_makin"
				});
			}
			if (this.comboBoxEdit15.SelectedIndex == 9)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"ui_mapname mp_outskirts"
				});
			}
			if (this.comboBoxEdit15.SelectedIndex == 10)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"ui_mapname mp_roundhouse"
				});
			}
			if (this.comboBoxEdit15.SelectedIndex == 11)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"ui_mapname mp_seelow"
				});
			}
			if (this.comboBoxEdit15.SelectedIndex == 12)
			{
				this.ixboxConsole_0.CallVoid(2183593736U, new object[]
				{
					0,
					"ui_mapname mp_suburban"
				});
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0003FD00 File Offset: 0x0003DF00
		private void simpleButton885_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit24.SelectedIndex == 0)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"ui_mapname mp_afghan"
				});
			}
			if (this.comboBoxEdit24.SelectedIndex == 1)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"ui_mapname mp_derail"
				});
			}
			if (this.comboBoxEdit24.SelectedIndex == 2)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"ui_mapname mp_estate"
				});
			}
			if (this.comboBoxEdit24.SelectedIndex == 3)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"ui_mapname mp_favela"
				});
			}
			if (this.comboBoxEdit24.SelectedIndex == 4)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"ui_mapname mp_highrise"
				});
			}
			if (this.comboBoxEdit24.SelectedIndex == 5)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"ui_mapname mp_invasion"
				});
			}
			if (this.comboBoxEdit24.SelectedIndex == 6)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"ui_mapname mp_checkpoint"
				});
			}
			if (this.comboBoxEdit24.SelectedIndex == 7)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"ui_mapname mp_quarry"
				});
			}
			if (this.comboBoxEdit24.SelectedIndex == 8)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"ui_mapname mp_rundown"
				});
			}
			if (this.comboBoxEdit24.SelectedIndex == 9)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"ui_mapname mp_rust"
				});
			}
			if (this.comboBoxEdit24.SelectedIndex == 10)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"ui_mapname mp_boneyard"
				});
			}
			if (this.comboBoxEdit24.SelectedIndex == 11)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"ui_mapname mp_nightshift"
				});
			}
			if (this.comboBoxEdit24.SelectedIndex == 12)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"ui_mapname mp_subbase"
				});
			}
			if (this.comboBoxEdit24.SelectedIndex == 13)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"ui_mapname mp_terminal"
				});
			}
			if (this.comboBoxEdit24.SelectedIndex == 14)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"ui_mapname mp_underpass"
				});
			}
			if (this.comboBoxEdit24.SelectedIndex == 15)
			{
				this.ixboxConsole_0.CallVoid(2183285136U, new object[]
				{
					0,
					"ui_mapname mp_brecourt"
				});
			}
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x000077B0 File Offset: 0x000059B0
		private void comboBoxEdit25_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00040084 File Offset: 0x0003E284
		private void simpleButton886_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit25.SelectedIndex == 0)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"ui_mapname mp_seatown"
				});
			}
			if (this.comboBoxEdit25.SelectedIndex == 1)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"ui_mapname mp_dome"
				});
			}
			if (this.comboBoxEdit25.SelectedIndex == 2)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"ui_mapname mp_plaza2"
				});
			}
			if (this.comboBoxEdit25.SelectedIndex == 3)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"ui_mapname mp_mogadishu"
				});
			}
			if (this.comboBoxEdit25.SelectedIndex == 4)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"ui_mapname mp_paris"
				});
			}
			if (this.comboBoxEdit25.SelectedIndex == 5)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"ui_mapname mp_exchange"
				});
			}
			if (this.comboBoxEdit25.SelectedIndex == 6)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"ui_mapname mp_bootleg"
				});
			}
			if (this.comboBoxEdit25.SelectedIndex == 7)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"ui_mapname mp_carbon"
				});
			}
			if (this.comboBoxEdit25.SelectedIndex == 8)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"ui_mapname mp_hardhat"
				});
			}
			if (this.comboBoxEdit25.SelectedIndex == 9)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"ui_mapname mp_alpha"
				});
			}
			if (this.comboBoxEdit25.SelectedIndex == 10)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"ui_mapname mp_village"
				});
			}
			if (this.comboBoxEdit25.SelectedIndex == 11)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"ui_mapname mp_lambeth"
				});
			}
			if (this.comboBoxEdit25.SelectedIndex == 12)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"ui_mapname mp_radar"
				});
			}
			if (this.comboBoxEdit25.SelectedIndex == 13)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"ui_mapname mp_interchange"
				});
			}
			if (this.comboBoxEdit25.SelectedIndex == 14)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"ui_mapname mp_underground"
				});
			}
			if (this.comboBoxEdit25.SelectedIndex == 15)
			{
				this.ixboxConsole_0.CallVoid(2183692136U, new object[]
				{
					0,
					"ui_mapname mp_bravo"
				});
			}
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00040408 File Offset: 0x0003E608
		private void simpleButton887_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit26.SelectedIndex == 0)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"ui_mapname mp_convoy"
				});
			}
			if (this.comboBoxEdit26.SelectedIndex == 1)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"ui_mapname mp_backlot"
				});
			}
			if (this.comboBoxEdit26.SelectedIndex == 2)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"ui_mapname mp_bloc"
				});
			}
			if (this.comboBoxEdit26.SelectedIndex == 3)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"ui_mapname mp_bog"
				});
			}
			if (this.comboBoxEdit26.SelectedIndex == 4)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"ui_mapname mp_countdown"
				});
			}
			if (this.comboBoxEdit26.SelectedIndex == 5)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"ui_mapname mp_crash"
				});
			}
			if (this.comboBoxEdit26.SelectedIndex == 6)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"ui_mapname mp_crossfire"
				});
			}
			if (this.comboBoxEdit26.SelectedIndex == 7)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"ui_mapname mp_citystreets"
				});
			}
			if (this.comboBoxEdit26.SelectedIndex == 8)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"ui_mapname mp_farm"
				});
			}
			if (this.comboBoxEdit26.SelectedIndex == 9)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"ui_mapname mp_overgrown"
				});
			}
			if (this.comboBoxEdit26.SelectedIndex == 10)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"ui_mapname mp_pipeline"
				});
			}
			if (this.comboBoxEdit26.SelectedIndex == 11)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"ui_mapname mp_shipment"
				});
			}
			if (this.comboBoxEdit26.SelectedIndex == 12)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"ui_mapname mp_showdown"
				});
			}
			if (this.comboBoxEdit26.SelectedIndex == 13)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"ui_mapname mp_strike"
				});
			}
			if (this.comboBoxEdit26.SelectedIndex == 14)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"ui_mapname mp_vacant"
				});
			}
			if (this.comboBoxEdit26.SelectedIndex == 15)
			{
				this.ixboxConsole_0.CallVoid(2183372752U, new object[]
				{
					0,
					"ui_mapname mp_cargoship"
				});
			}
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x000077B0 File Offset: 0x000059B0
		private void xtraTabPage30_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0004078C File Offset: 0x0003E98C
		private void simpleButton888_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit27.SelectedIndex == 0)
			{
				this.ixboxConsole_0.CallVoid(2184440024U, new object[]
				{
					0,
					"map mp_array"
				});
			}
			if (this.comboBoxEdit27.SelectedIndex == 1)
			{
				this.ixboxConsole_0.CallVoid(2184440024U, new object[]
				{
					0,
					"map mp_cracked"
				});
			}
			if (this.comboBoxEdit27.SelectedIndex == 2)
			{
				this.ixboxConsole_0.CallVoid(2184440024U, new object[]
				{
					0,
					"map mp_crisis"
				});
			}
			if (this.comboBoxEdit27.SelectedIndex == 3)
			{
				this.ixboxConsole_0.CallVoid(2184440024U, new object[]
				{
					0,
					"map mp_firingrange"
				});
			}
			if (this.comboBoxEdit27.SelectedIndex == 4)
			{
				this.ixboxConsole_0.CallVoid(2184440024U, new object[]
				{
					0,
					"map mp_duga"
				});
			}
			if (this.comboBoxEdit27.SelectedIndex == 5)
			{
				this.ixboxConsole_0.CallVoid(2184440024U, new object[]
				{
					0,
					"map mp_hanoi"
				});
			}
			if (this.comboBoxEdit27.SelectedIndex == 6)
			{
				this.ixboxConsole_0.CallVoid(2184440024U, new object[]
				{
					0,
					"map mp_cairo"
				});
			}
			if (this.comboBoxEdit27.SelectedIndex == 7)
			{
				this.ixboxConsole_0.CallVoid(2184440024U, new object[]
				{
					0,
					"map mp_havoc"
				});
			}
			if (this.comboBoxEdit27.SelectedIndex == 8)
			{
				this.ixboxConsole_0.CallVoid(2184440024U, new object[]
				{
					0,
					"map mp_cosmodrome"
				});
			}
			if (this.comboBoxEdit27.SelectedIndex == 9)
			{
				this.ixboxConsole_0.CallVoid(2184440024U, new object[]
				{
					0,
					"map mp_nuked"
				});
			}
			if (this.comboBoxEdit27.SelectedIndex == 10)
			{
				this.ixboxConsole_0.CallVoid(2184440024U, new object[]
				{
					0,
					"map mp_radiation"
				});
			}
			if (this.comboBoxEdit27.SelectedIndex == 11)
			{
				this.ixboxConsole_0.CallVoid(2184440024U, new object[]
				{
					0,
					"map mp_mountain"
				});
			}
			if (this.comboBoxEdit27.SelectedIndex == 12)
			{
				this.ixboxConsole_0.CallVoid(2184440024U, new object[]
				{
					0,
					"map mp_villa"
				});
			}
			if (this.comboBoxEdit27.SelectedIndex == 13)
			{
				this.ixboxConsole_0.CallVoid(2184440024U, new object[]
				{
					0,
					"map mp_russianbase"
				});
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00040AA0 File Offset: 0x0003ECA0
		private void simpleButton889_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit28.SelectedIndex == 0)
			{
				this.ixboxConsole_0.CallVoid(2185702272U, new object[]
				{
					0,
					"ui_mapname mp_refraction"
				});
			}
			if (this.comboBoxEdit28.SelectedIndex == 1)
			{
				this.ixboxConsole_0.CallVoid(2185702272U, new object[]
				{
					0,
					"ui_mapname mp_lab2"
				});
			}
			if (this.comboBoxEdit28.SelectedIndex == 2)
			{
				this.ixboxConsole_0.CallVoid(2185702272U, new object[]
				{
					0,
					"ui_mapname mp_comeback"
				});
			}
			if (this.comboBoxEdit28.SelectedIndex == 3)
			{
				this.ixboxConsole_0.CallVoid(2185702272U, new object[]
				{
					0,
					"ui_mapname mp_laser2"
				});
			}
			if (this.comboBoxEdit28.SelectedIndex == 4)
			{
				this.ixboxConsole_0.CallVoid(2185702272U, new object[]
				{
					0,
					"ui_mapname mp_detroit"
				});
			}
			if (this.comboBoxEdit28.SelectedIndex == 5)
			{
				this.ixboxConsole_0.CallVoid(2185702272U, new object[]
				{
					0,
					"ui_mapname mp_greenband"
				});
			}
			if (this.comboBoxEdit28.SelectedIndex == 6)
			{
				this.ixboxConsole_0.CallVoid(2185702272U, new object[]
				{
					0,
					"ui_mapname mp_levity"
				});
			}
			if (this.comboBoxEdit28.SelectedIndex == 7)
			{
				this.ixboxConsole_0.CallVoid(2185702272U, new object[]
				{
					0,
					"ui_mapname mp_instinct"
				});
			}
			if (this.comboBoxEdit28.SelectedIndex == 8)
			{
				this.ixboxConsole_0.CallVoid(2185702272U, new object[]
				{
					0,
					"ui_mapname mp_recovery"
				});
			}
			if (this.comboBoxEdit28.SelectedIndex == 9)
			{
				this.ixboxConsole_0.CallVoid(2185702272U, new object[]
				{
					0,
					"ui_mapname mp_venus"
				});
			}
			if (this.comboBoxEdit28.SelectedIndex == 10)
			{
				this.ixboxConsole_0.CallVoid(2185702272U, new object[]
				{
					0,
					"ui_mapname mp_prison"
				});
			}
			if (this.comboBoxEdit28.SelectedIndex == 11)
			{
				this.ixboxConsole_0.CallVoid(2185702272U, new object[]
				{
					0,
					"ui_mapname mp_solar"
				});
			}
			if (this.comboBoxEdit28.SelectedIndex == 12)
			{
				this.ixboxConsole_0.CallVoid(2185702272U, new object[]
				{
					0,
					"ui_mapname mp_terrace"
				});
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00040D7C File Offset: 0x0003EF7C
		private void simpleButton890_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit29.SelectedIndex == 0)
			{
				this.ixboxConsole_0.CallVoid(2185545528U, new object[]
				{
					0,
					"ui_mapname mp_prisonbreak"
				});
			}
			if (this.comboBoxEdit29.SelectedIndex == 1)
			{
				this.ixboxConsole_0.CallVoid(2185545528U, new object[]
				{
					0,
					"ui_mapname mp_dart"
				});
			}
			if (this.comboBoxEdit29.SelectedIndex == 2)
			{
				this.ixboxConsole_0.CallVoid(2185545528U, new object[]
				{
					0,
					"ui_mapname mp_lonestar"
				});
			}
			if (this.comboBoxEdit29.SelectedIndex == 3)
			{
				this.ixboxConsole_0.CallVoid(2185545528U, new object[]
				{
					0,
					"ui_mapname mp_frag"
				});
			}
			if (this.comboBoxEdit29.SelectedIndex == 4)
			{
				this.ixboxConsole_0.CallVoid(2185545528U, new object[]
				{
					0,
					"ui_mapname mp_snow"
				});
			}
			if (this.comboBoxEdit29.SelectedIndex == 5)
			{
				this.ixboxConsole_0.CallVoid(2185545528U, new object[]
				{
					0,
					"ui_mapname mp_fahrenheit"
				});
			}
			if (this.comboBoxEdit29.SelectedIndex == 6)
			{
				this.ixboxConsole_0.CallVoid(2185545528U, new object[]
				{
					0,
					"ui_mapname mp_hashima"
				});
			}
			if (this.comboBoxEdit29.SelectedIndex == 7)
			{
				this.ixboxConsole_0.CallVoid(2185545528U, new object[]
				{
					0,
					"ui_mapname mp_warhawk"
				});
			}
			if (this.comboBoxEdit29.SelectedIndex == 8)
			{
				this.ixboxConsole_0.CallVoid(2185545528U, new object[]
				{
					0,
					"ui_mapname mp_sovereign"
				});
			}
			if (this.comboBoxEdit29.SelectedIndex == 9)
			{
				this.ixboxConsole_0.CallVoid(2185545528U, new object[]
				{
					0,
					"ui_mapname mp_zebra"
				});
			}
			if (this.comboBoxEdit29.SelectedIndex == 10)
			{
				this.ixboxConsole_0.CallVoid(2185545528U, new object[]
				{
					0,
					"ui_mapname mp_skeleton"
				});
			}
			if (this.comboBoxEdit29.SelectedIndex == 11)
			{
				this.ixboxConsole_0.CallVoid(2185545528U, new object[]
				{
					0,
					"ui_mapname mp_chasm"
				});
			}
			if (this.comboBoxEdit29.SelectedIndex == 12)
			{
				this.ixboxConsole_0.CallVoid(2185545528U, new object[]
				{
					0,
					"ui_mapname mp_flooded"
				});
			}
			if (this.comboBoxEdit29.SelectedIndex == 13)
			{
				this.ixboxConsole_0.CallVoid(2185545528U, new object[]
				{
					0,
					"ui_mapname mp_strikezone"
				});
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x000077B0 File Offset: 0x000059B0
		private void xtraTabPage40_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00041090 File Offset: 0x0003F290
		private void simpleButton906_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"sv_cheats 1"
			});
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x000410BC File Offset: 0x0003F2BC
		private void simpleButton905_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				this.textEdit_194.Text
			});
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x000410F0 File Offset: 0x0003F2F0
		private void simpleButton900_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"noclip"
			});
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0004111C File Offset: 0x0003F31C
		private void simpleButton894_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"buddha"
			});
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x000077B0 File Offset: 0x000059B0
		private void groupControl65_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000077B0 File Offset: 0x000059B0
		private void textEdit_197_EditValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00041148 File Offset: 0x0003F348
		private void simpleButton912_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"explode"
			});
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00041174 File Offset: 0x0003F374
		private void simpleButton891_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				this.textEdit_195.Text
			});
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000411A8 File Offset: 0x0003F3A8
		private void simpleButton901_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"name " + this.textEdit_199.Text
			});
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000411E4 File Offset: 0x0003F3E4
		private void simpleButton911_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"say \"" + this.textEdit_198.Text + "\""
			});
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00041224 File Offset: 0x0003F424
		private void simpleButton913_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"cl_drawfps 1"
			});
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00041250 File Offset: 0x0003F450
		private void simpleButton914_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"toggle net_graph"
			});
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0004127C File Offset: 0x0003F47C
		private void simpleButton915_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"fps_max " + this.textEdit_203.Text
			});
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x000412B8 File Offset: 0x0003F4B8
		private void simpleButton896_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"impulse 101"
			});
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x000412E4 File Offset: 0x0003F4E4
		private void simpleButton892_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"thirdperson"
			});
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00041310 File Offset: 0x0003F510
		private void simpleButton893_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"firstperson"
			});
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0004133C File Offset: 0x0003F53C
		private void simpleButton895_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"fov " + this.textEdit_196.Text
			});
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00041378 File Offset: 0x0003F578
		private void simpleButton897_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"kick " + this.textEdit_197.Text
			});
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x000413B4 File Offset: 0x0003F5B4
		private void simpleButton898_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"kill " + this.textEdit_202.Text
			});
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000413F0 File Offset: 0x0003F5F0
		private void simpleButton899_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"sv_gravity " + this.textEdit_201.Text
			});
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0004142C File Offset: 0x0003F62C
		private void simpleButton902_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"host_timescale " + this.textEdit_200.Text
			});
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00041468 File Offset: 0x0003F668
		private void simpleButton903_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"sv_alltalk 1"
			});
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00041494 File Offset: 0x0003F694
		private void simpleButton904_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"bot 1"
			});
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x000414C0 File Offset: 0x0003F6C0
		private void simpleButton910_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"bot_changeteams"
			});
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x000414EC File Offset: 0x0003F6EC
		private void simpleButton907_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"ent_fire tf_gamerules setredteamrespawnwavetime 0;ent_fire tf_gamerules setblueteamrespawnwavetime 0;spec_freeze_time -1"
			});
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00041518 File Offset: 0x0003F718
		private void simpleButton908_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"mp_allowspectators 0"
			});
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00041544 File Offset: 0x0003F744
		private void simpleButton909_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"mm_minplayers 0"
			});
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00041570 File Offset: 0x0003F770
		private void simpleButton916_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit30.SelectedIndex == 0)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 0 0"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 1)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 0 1"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 2)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 0 2"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 3)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 0 3"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 4)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 0 4"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 5)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 0 5"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 6)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 0 6"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 7)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 0 7"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 8)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 1 0"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 9)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 1 1"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 10)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 1 2"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 11)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 1 3"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 12)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 1 4"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 13)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 1 5"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 14)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 1 6"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 15)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 1 7"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 16)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 2 0"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 17)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 2 1"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 18)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 2 2"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 19)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 2 3"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 20)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 2 4"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 21)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 2 5"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 22)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 2 6"
				});
			}
			if (this.comboBoxEdit30.SelectedIndex == 23)
			{
				this.ixboxConsole_0.CallVoid(2248779848U, new object[]
				{
					"voicemenu 2 7"
				});
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000419DC File Offset: 0x0003FBDC
		private void simpleButton917_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2248779848U, new object[]
			{
				"disconnect"
			});
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00041A08 File Offset: 0x0003FC08
		private void simpleButton933_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2194697640U, new object[]
			{
				0,
				"sv_cheats 1"
			});
			this.ixboxConsole_0.XNotify("Cheats Enabled!");
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00041A4C File Offset: 0x0003FC4C
		private void simpleButton932_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2194697640U, new object[]
			{
				0,
				this.textEdit_204.Text
			});
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00041A88 File Offset: 0x0003FC88
		private void simpleButton926_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2194697640U, new object[]
			{
				0,
				"noclip"
			});
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00041ABC File Offset: 0x0003FCBC
		private void simpleButton928_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2194697640U, new object[]
			{
				0,
				"upgrade_potatogun"
			});
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000077B0 File Offset: 0x000059B0
		private void textEdit_206_EditValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00041AF0 File Offset: 0x0003FCF0
		private void simpleButton927_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2194697640U, new object[]
			{
				0,
				"name " + this.textEdit_207.Text
			});
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00041B34 File Offset: 0x0003FD34
		private void simpleButton918_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2194697640U, new object[]
			{
				0,
				"say \"" + this.textEdit_206.Text + "\""
			});
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00041B80 File Offset: 0x0003FD80
		private void simpleButton919_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2194697640U, new object[]
			{
				0,
				"fps_max " + this.textEdit_205.Text
			});
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00041BC4 File Offset: 0x0003FDC4
		private void simpleButton920_Click(object sender, EventArgs e)
		{
			byte[] data = new byte[]
			{
				10
			};
			uint num;
			this.ixboxConsole_0.DebugTarget.SetMemory(2198506451U, 1U, data, out num);
			byte[] data2 = new byte[]
			{
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				1,
				39,
				0,
				9,
				0,
				0,
				0,
				14,
				0,
				134,
				0,
				0,
				0,
				7,
				0,
				9,
				0,
				0,
				0,
				9,
				0,
				134,
				0,
				0,
				0,
				106,
				0,
				15,
				0,
				17,
				0,
				8,
				0,
				0,
				0,
				97,
				0,
				131,
				0,
				0,
				0,
				94,
				54,
				71,
				117,
				84,
				117,
				94,
				48,
				77,
				111,
				68,
				122,
				0,
				49,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				118,
				0,
				32,
				0,
				32,
				0,
				32,
				0,
				19,
				0,
				20,
				0,
				25,
				0,
				45,
				0,
				38,
				0,
				39,
				0,
				2,
				0,
				0,
				0,
				4,
				0,
				0,
				0,
				6,
				0,
				107,
				0,
				0,
				0,
				0,
				0,
				1,
				39,
				0,
				9,
				0,
				0,
				0,
				0,
				0,
				134,
				0,
				0,
				0,
				7,
				0,
				9,
				0,
				0,
				0,
				7,
				0,
				134,
				0,
				0,
				0,
				106,
				0,
				15,
				0,
				17,
				0,
				8,
				0,
				0,
				0,
				97,
				0,
				131,
				0,
				0,
				0,
				94,
				53,
				73,
				99,
				101,
				94,
				49,
				84,
				101,
				97,
				0,
				122,
				0,
				32,
				50,
				0,
				84,
				32,
				49,
				0,
				0,
				118,
				0,
				32,
				0,
				32,
				0,
				32,
				0,
				19,
				0,
				20,
				0,
				25,
				0,
				45,
				0,
				38,
				0,
				39,
				0,
				2,
				0,
				0,
				0,
				4,
				0,
				0,
				0,
				6,
				0,
				107,
				0,
				0,
				0,
				0,
				0,
				1,
				39,
				0,
				9,
				0,
				0,
				0,
				0,
				0,
				134,
				0,
				0,
				0,
				7,
				0,
				9,
				0,
				0,
				0,
				8,
				0,
				134,
				0,
				0,
				0,
				106,
				0,
				15,
				0,
				17,
				0,
				8,
				0,
				0,
				0,
				97,
				0,
				131,
				0,
				0,
				0,
				94,
				50,
				70,
				97,
				110,
				97,
				94,
				51,
				116,
				105,
				107,
				0,
				0,
				51,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				118,
				0,
				32,
				0,
				32,
				0,
				32,
				0,
				19,
				0,
				20,
				0,
				25,
				0,
				45,
				0,
				38,
				0,
				39,
				0,
				2,
				0,
				0,
				0,
				4,
				0,
				0,
				0,
				6,
				0,
				107,
				0,
				0,
				0,
				0,
				0,
				1,
				32,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				23,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				108,
				0,
				15,
				0,
				78,
				0,
				74,
				0,
				0,
				0,
				95,
				0,
				112,
				0,
				0,
				0,
				79,
				79,
				79,
				77,
				77,
				77,
				71,
				71,
				71,
				71,
				71,
				33,
				33,
				33,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				118,
				0,
				1,
				0,
				3,
				0,
				8,
				0,
				19,
				0,
				23,
				0,
				25,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				2,
				0,
				0,
				0,
				4,
				0,
				0,
				0,
				6,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				1,
				32,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				23,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				108,
				0,
				15,
				0,
				78,
				0,
				74,
				0,
				0,
				0,
				95,
				0,
				112,
				0,
				0,
				0,
				79,
				79,
				79,
				77,
				77,
				77,
				71,
				71,
				71,
				71,
				71,
				33,
				33,
				33,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				118,
				0,
				1,
				0,
				3,
				0,
				8,
				0,
				19,
				0,
				23,
				0,
				25,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				2,
				0,
				0,
				0,
				4,
				0,
				0,
				0,
				6,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				9,
				0
			};
			string str = this.method_92();
			this.ixboxConsole_0.SetMemory(2198499536U, data2);
			this.ixboxConsole_0.WriteString(2198499612U, "^1" + str + " (God)");
			this.ixboxConsole_0.WriteString(2198499710U, "^2" + str + " (God)");
			this.ixboxConsole_0.WriteString(2198499808U, "^3" + str + " (God)");
			this.ixboxConsole_0.WriteString(2198499906U, "^4" + str + " (God)");
			this.ixboxConsole_0.WriteString(2198500004U, "^5" + str + " (God)");
			this.ixboxConsole_0.WriteString(2198500102U, "^1" + str);
			this.ixboxConsole_0.WriteString(2198500200U, "^2" + str);
			this.ixboxConsole_0.WriteString(2198500298U, "^3" + str);
			this.ixboxConsole_0.WriteString(2198500396U, "^4" + str);
			this.ixboxConsole_0.WriteString(2198500494U, "^5" + str);
			this.ixboxConsole_0.WriteString(2198500592U, "^1" + str);
			this.ixboxConsole_0.WriteString(2198500690U, "^2" + str);
			this.ixboxConsole_0.WriteString(2198500788U, "^3" + str);
			this.ixboxConsole_0.WriteString(2198500886U, "^4" + str);
			this.ixboxConsole_0.WriteString(2198500984U, "^5" + str);
			this.ixboxConsole_0.XNotify("15 Classes Unlocked!\nApplied Godmode Classes!");
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00041DF8 File Offset: 0x0003FFF8
		private void simpleButton921_Click(object sender, EventArgs e)
		{
			if (this.simpleButton921.Text.Contains("1"))
			{
				this.ixboxConsole_0.CallVoid(2183481560U, new object[]
				{
					this.listBox9.SelectedIndex,
					0,
					"J 2056 206426"
				});
				this.ixboxConsole_0.XNotify("Quick Stats Part 1 Given!");
				this.simpleButton921.Text = this.simpleButton921.Text.Replace("1", "2");
			}
			else
			{
				this.ixboxConsole_0.CallVoid(2183481560U, new object[]
				{
					this.listBox9.SelectedIndex,
					0,
					"J 2064 0A000"
				});
				this.ixboxConsole_0.XNotify("Quick Stats Part 2 Given!");
				this.simpleButton921.Text = this.simpleButton921.Text.Replace("2", "1");
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00041EFC File Offset: 0x000400FC
		private void simpleButton922_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.XNotify("Unlock All Started");
			int selectedIndex = this.listBox9.SelectedIndex;
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 6525 7F 3500 99 3501 99 3502 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3503 99 3504 99 3505 99 3506 99 3507 99 3508 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3509 99 3510 99 3511 99 3512 99 3513 99 3514 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3515 99 3516 99 3517 99 3518 99 3519 99 3520 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3521 99 3522 99 3523 99 3524 99 3525 99 3526 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3527 99 3528 99 3529 99 3530 99 3531 99 3532 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3533 99 3534 99 3535 99 3536 99 3537 99 3538 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3539 99 3540 99 3541 99 3542 99 3543 99 3544 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3545 99 3546 99 3547 99 3548 99 3549 99 3550 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3550 99 3551 99 3552 99 3553 99 3554 99 3555 99 3556 99 3557 99 3558 99 3559 99 3560 99 3561 99 3562 99 3563 99 3564 99 3565 99 3566 99 3567 99 3568 99 3569 99 3570 99 3571 99 3572 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3573 99 3574 99 3575 99 3576 99 3577 99 3578 99 3579 99 3580 99 3581 99 3582 99 3583 99 3584 99 3585 99 3586 99 3587 99 3588 99 3589 99 3590 99 3591 99 3592 99 3593 99 3594 99 3595 99 3596 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3597 99 3598 99 3599 99 3600 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3600 99 3601 99 3602 99 3603 99 3604 99 3605 99 3606 99 3607 99 3608 99 3609 99 3610 99 3611 99 3612 99 3613 99 3614 99 3615 99 3616 99 3617 99 3618 99 3619 99 3620 99 3621 99 3622 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3623 99 3624 99 3625 99 3626 99 3627 99 3628 99 3629 99 3630 99 3631 99 3632 99 3633 99 3634 99 3635 99 3636 99 3637 99 3638 99 3639 99 3640 99 3641 99 3642 99 3643 99 3644 99 3645 99 3646 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3647 99 3648 99 3649 99 3650 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3650 99 3651 99 3652 99 3653 99 3654 99 3655 99 3656 99 3657 99 3658 99 3659 99 3660 99 3661 99 3662 99 3663 99 3664 99 3665 99 3666 99 3667 99 3668 99 3669 99 3670 99 3671 99 3672 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3673 99 3674 99 3675 99 3676 99 3677 99 3678 99 3679 99 3680 99 3681 99 3682 99 3683 99 3684 99 3685 99 3686 99 3687 99 3688 99 3689 99 3690 99 3691 99 3692 99 3693 99 3694 99 3695 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3696 99 3697 99 3698 99 3699 99 3700 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3700 99 3701 99 3702 99 3703 99 3704 99 3705 99 3706 99 3707 99 3708 99 3709 99 3710 99 3711 99 3712 99 3713 99 3714 99 3715 99 3716 99 3717 99 3718 99 3719 99 3720 99 3721 99 3722 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3723 99 3724 99 3725 99 3726 99 3727 99 3728 99 3729 99 3730 99 3731 99 3732 99 3733 99 3734 99 3735 99 3736 99 3737 99 3738 99 3739 99 3740 99 3741 99 3742 99 3743 99 3744 99 3745 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3746 99 3747 99 3748 99 3749 99 3750 99"
			});
			Thread.Sleep(3000);
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3750 99 3751 99 3752 99 3753 99 3754 99 3755 99 3756 99 3757 99 3758 99 3759 99 3760 99 3761 99 3762 99 3763 99 3764 99 3765 99 3766 99 3767 99 3768 99 3769 99 3770 99 3771 99 3772 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3773 99 3774 99 3775 99 3776 99 3777 99 3778 99 3779 99 3780 99 3781 99 3782 99 3783 99 3784 99 3785 99 3786 99 3787 99 3788 99 3789 99 3790 99 3791 99 3792 99 3793 99 3794 99 3795 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3796 99 3797 99 3798 99 3799 99 3800 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3800 99 3801 99 3802 99 3803 99 3804 99 3805 99 3806 99 3807 99 3808 99 3809 99 3810 99 3811 99 3812 99 3813 99 3814 99 3815 99 3816 99 3817 99 3818 99 3819 99 3820 99 3821 99 3822 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3823 99 3824 99 3825 99 3826 99 3827 99 3828 99 3829 99 3830 99 3831 99 3832 99 3833 99 3834 99 3835 99 3836 99 3837 99 3838 99 3839 99 3840 99 3841 99 3842 99 3843 99 3844 99 3845 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3846 99 3847 99 3848 99 3849 99 3850 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3850 99 3851 99 3852 99 3853 99 3854 99 3855 99 3856 99 3857 99 3858 99 3859 99 3860 99 3861 99 3862 99 3863 99 3864 99 3865 99 3866 99 3867 99 3868 99 3869 99 3870 99 3871 99 3872 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3873 99 3874 99 3875 99 3876 99 3877 99 3878 99 3879 99 3880 99 3881 99 3882 99 3883 99 3884 99 3885 99 3886 99 3887 99 3888 99 3889 99 3890 99 3891 99 3892 99 3893 99 3894 99 3895 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3896 99 3897 99 3898 99 3899 99 3900 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3900 99 3901 99 3902 99 3903 99 3904 99 3905 99 3906 99 3907 99 3908 99 3909 99 3910 99 3911 99 3912 99 3913 99 3914 99 3915 99 3916 99 3917 99 3918 99 3919 99 3920 99 3921 99 3922 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3923 99 3924 99 3925 99 3926 99 3927 99 3928 99 3929 99 3930 99 3931 99 3932 99 3933 99 3934 99 3935 99 3936 99 3937 99 3938 99 3939 99 3940 99 3941 99 3942 99 3943 99 3944 99 3945 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3946 99 3947 99 3948 99 3949 99 3950 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3950 99 3951 99 3952 99 3953 99 3954 99 3955 99 3956 99 3957 99 3958 99 3959 99 3960 99 3961 99 3962 99 3963 99 3964 99 3965 99 3966 99 3967 99 3968 99 3969 99 3970 99 3971 99 3972 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3973 99 3974 99 3975 99 3976 99 3977 99 3978 99 3979 99 3980 99 3981 99 3982 99 3983 99 3984 99 3985 99 3986 99 3987 99 3988 99 3989 99 3990 99 3991 99 3992 99 3993 99 3994 99 3995 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 3996 99 3997 99 3998 99 3999 99 4000 99"
			});
			Thread.Sleep(3000);
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4000 99 4001 99 4002 99 4003 99 4004 99 4005 99 4006 99 4007 99 4008 99 4009 99 4010 99 4011 99 4012 99 4013 99 4014 99 4015 99 4016 99 4017 99 4018 99 4019 99 4020 99 4021 99 4022 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4023 99 4024 99 4025 99 4026 99 4027 99 4028 99 4029 99 4030 99 4031 99 4032 99 4033 99 4034 99 4035 99 4036 99 4037 99 4038 99 4039 99 4040 99 4041 99 4042 99 4043 99 4044 99 4045 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4046 99 4047 99 4048 99 4049 99 4050 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4050 99 4051 99 4052 99 4053 99 4054 99 4055 99 4056 99 4057 99 4058 99 4059 99 4060 99 4061 99 4062 99 4063 99 4064 99 4065 99 4066 99 4067 99 4068 99 4069 99 4070 99 4071 99 4072 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4073 99 4074 99 4075 99 4076 99 4077 99 4078 99 4079 99 4080 99 4081 99 4082 99 4083 99 4084 99 4085 99 4086 99 4087 99 4088 99 4089 99 4090 99 4091 99 4092 99 4093 99 4094 99 4095 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4096 99 4097 99 4098 99 4099 99 4100 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 100 99 4101 99 4102 99 4103 99 4104 99 4105 99 4106 99 4107 99 4108 99 4109 99 4110 99 4111 99 4112 99 4113 99 4114 99 4115 99 4116 99 4117 99 4118 99 4119 99 4120 99 4121 99 4122 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4123 99 4124 99 4125 99 4126 99 4127 99 4128 99 4129 99 4130 99 4131 99 4132 99 4133 99 4134 99 4135 99 4136 99 4137 99 4138 99 4139 99 4140 99 4141 99 4142 99 4143 99 4144 99 4145 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4146 99 4147 99 4148 99 4149 99 4150 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4150 99 4151 99 4152 99 4153 99 4154 99 4155 99 4156 99 4157 99 4158 99 4159 99 4160 99 4161 99 4162 99 4163 99 4164 99 4165 99 4166 99 4167 99 4168 99 4169 99 4170 99 4171 99 4172 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4173 99 4174 99 4175 99 4176 99 4177 99 4178 99 4179 99 4180 99 4181 99 4182 99 4183 99 4184 99 4185 99 4186 99 4187 99 4188 99 4189 99 4190 99 4191 99 4192 99 4193 99 4194 99 4195 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4196 99 4197 99 4198 99 4199 99 4200 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4200 99 4201 99 4202 99 4203 99 4204 99 4205 99 4206 99 4207 99 4208 99 4209 99 4210 99 4211 99 4212 99 4213 99 4214 99 4215 99 4216 99 4217 99 4218 99 4219 99 4220 99 4221 99 4222 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4223 99 4224 99 4225 99 4226 99 4227 99 4228 99 4229 99 4230 99 4231 99 4232 99 4233 99 4234 99 4235 99 4236 99 4237 99 4238 99 4239 99 4240 99 4241 99 4242 99 4243 99 4244 99 4245 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4246 99 4247 99 4248 99 4249 99 4250 99"
			});
			Thread.Sleep(3000);
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4250 99 4251 99 4252 99 4253 99 4254 99 4255 99 4256 99 4257 99 4258 99 4259 99 4260 99 4261 99 4262 99 4263 99 4264 99 4265 99 4266 99 4267 99 4268 99 4269 99 4270 99 4271 99 4272 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4273 99 4274 99 4275 99 4276 99 4277 99 4278 99 4279 99 4280 99 4281 99 4282 99 4283 99 4284 99 4285 99 4286 99 4287 99 4288 99 4289 99 4290 99 4291 99 4292 99 4293 99 4294 99 4295 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4296 99 4297 99 4298 99 4299 99 4300 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4300 99 4301 99 4302 99 4303 99 4304 99 4305 99 4306 99 4307 99 4308 99 4309 99 4310 99 4311 99 4312 99 4313 99 4314 99 4315 99 4316 99 4317 99 4318 99 4319 99 4320 99 4321 99 4322 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4323 99 4324 99 4325 99 4326 99 4327 99 4328 99 4329 99 4330 99 4331 99 4332 99 4333 99 4334 99 4335 99 4336 99 4337 99 4338 99 4339 99 4340 99 4341 99 4342 99 4343 99 4344 99 4345 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4346 99 4347 99 4348 99 4349 99 4350 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4350 99 4351 99 4352 99 4353 99 4354 99 4355 99 4356 99 4357 99 4358 99 4359 99 4360 99 4361 99 4362 99 4363 99 4364 99 4365 99 4366 99 4367 99 4368 99 4369 99 4370 99 4371 99 4372 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4373 99 4374 99 4375 99 4376 99 4377 99 4378 99 4379 99 4380 99 4381 99 4382 99 4383 99 4384 99 4385 99 4386 99 4387 99 4388 99 4389 99 4390 99 4391 99 4392 99 4393 99 4394 99 4395 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4396 99 4397 99 4398 99 4399 99 4400 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4400 99 4401 99 4402 99 4403 99 4404 99 4405 99 4406 99 4407 99 4408 99 4409 99 4410 99 4411 99 4412 99 4413 99 4414 99 4415 99 4416 99 4417 99 4418 99 4419 99 4420 99 4421 99 4422 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4423 99 4424 99 4425 99 4426 99 4427 99 4428 99 4429 99 4430 99 4431 99 4432 99 4433 99 4434 99 4435 99 4436 99 4437 99 4438 99 4439 99 4440 99 4441 99 4442 99 4443 99 4444 99 4445 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4446 99 4447 99 4448 99 4449 99 4450 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4450 99 4451 99 4452 99 4453 99 4454 99 4455 99 4456 99 4457 99 4458 99 4459 99 4460 99 4461 99 4462 99 4463 99 4464 99 4465 99 4466 99 4467 99 4468 99 4469 99 4470 99 4471 99 4472 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4473 99 4474 99 4475 99 4476 99 4477 99 4478 99 4479 99 4480 99 4481 99 4482 99 4483 99 4484 99 4485 99 4486 99 4487 99 4488 99 4489 99 4490 99 4491 99 4492 99 4493 99 4494 99 4495 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4496 99 4497 99 4498 99 4499 99 4500 99"
			});
			Thread.Sleep(3000);
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4500 99 4501 99 4502 99 4503 99 4504 99 4505 99 4506 99 4507 99 4508 99 4509 99 4510 99 4511 99 4512 99 4513 99 4514 99 4515 99 4516 99 4517 99 4518 99 4519 99 4520 99 4521 99 4522 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4523 99 4524 99 4525 99 4526 99 4527 99 4528 99 4529 99 4530 99 4531 99 4532 99 4533 99 4534 99 4535 99 4536 99 4537 99 4538 99 4539 99 4540 99 4541 99 4542 99 4543 99 4544 99 4545 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4546 99 4547 99 4548 99 4549 99 4550 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4550 99 4551 99 4552 99 4553 99 4554 99 4555 99 4556 99 4557 99 4558 99 4559 99 4560 99 4561 99 4562 99 4563 99 4564 99 4565 99 4566 99 4567 99 4568 99 4569 99 4570 99 4571 99 4572 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4596 99 4597 99 4598 99 4599 99 4600 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4573 99 4574 99 4575 99 4576 99 4577 99 4578 99 4579 99 4580 99 4581 99 4582 99 4583 99 4584 99 4585 99 4586 99 4587 99 4588 99 4589 99 4590 99 4591 99 4592 99 4593 99 4594 99 4595 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4600 99 4601 99 4602 99 4603 99 4604 99 4605 99 4606 99 4607 99 4608 99 4609 99 4610 99 4611 99 4612 99 4613 99 4614 99 4615 99 4616 99 4617 99 4618 99 4619 99 4620 99 4621 99 4622 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4623 99 4624 99 4625 99 4626 99 4627 99 4628 99 4629 99 4630 99 4631 99 4632 99 4633 99 4634 99 4635 99 4636 99 4637 99 4638 99 4639 99 4640 99 4641 99 4642 99 4643 99 4644 99 4645 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4646 99 4647 99 4648 99 4649 99 4650 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4650 99 4651 99 4652 99 4653 99 4654 99 4655 99 4656 99 4657 99 4658 99 4659 99 4660 99 4661 99 4662 99 4663 99 4664 99 4665 99 4666 99 4667 99 4668 99 4669 99 4670 99 4671 99 4672 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4673 99 4674 99 4675 99 4676 99 4677 99 4678 99 4679 99 4680 99 4681 99 4682 99 4683 99 4684 99 4685 99 4686 99 4687 99 4688 99 4689 99 4690 99 4691 99 4692 99 4693 99 4694 99 4695 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4696 99 4697 99 4698 99 4699 99 4700 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4700 99 4701 99 4702 99 4703 99 4704 99 4705 99 4706 99 4707 99 4708 99 4709 99 4710 99 4711 99 4712 99 4713 99 4714 99 4715 99 4716 99 4717 99 4718 99 4719 99 4720 99 4721 99 4722 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4723 99 4724 99 4725 99 4726 99 4727 99 4728 99 4729 99 4730 99 4731 99 4732 99 4733 99 4734 99 4735 99 4736 99 4737 99 4738 99 4739 99 4740 99 4741 99 4742 99 4743 99 4744 99 4745 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4746 99 4747 99 4748 99 4749 99 4750 99"
			});
			Thread.Sleep(3000);
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4750 99 4751 99 4752 99 4753 99 4754 99 4755 99 4756 99 4757 99 4758 99 4759 99 4760 99 4761 99 4762 99 4763 99 4764 99 4765 99 4766 99 4767 99 4768 99 4769 99 4770 99 4771 99 4772 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4773 99 4774 99 4775 99 4776 99 4777 99 4778 99 4779 99 4780 99 4781 99 4782 99 4783 99 4784 99 4785 99 4786 99 4787 99 4788 99 4789 99 4790 99 4791 99 4792 99 4793 99 4794 99 4795 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4796 99 4797 99 4798 99 4799 99 4800 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4800 99 4801 99 4802 99 4803 99 4804 99 4805 99 4806 99 4807 99 4808 99 4809 99 4810 99 4811 99 4812 99 4813 99 4814 99 4815 99 4816 99 4817 99 4818 99 4819 99 4820 99 4821 99 4822 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4823 99 4824 99 4825 99 4826 99 4827 99 4828 99 4829 99 4830 99 4831 99 4832 99 4833 99 4834 99 4835 99 4836 99 4837 99 4838 99 4839 99 4840 99 4841 99 4842 99 4843 99 4844 99 4845 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4846 99 4847 99 4848 99 4849 99 4850 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4850 99 4851 99 4852 99 4853 99 4854 99 4855 99 4856 99 4857 99 4858 99 4859 99 4860 99 4861 99 4862 99 4863 99 4864 99 4865 99 4866 99 4867 99 4868 99 4869 99 4870 99 4871 99 4872 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4873 99 4874 99 4875 99 4876 99 4877 99 4878 99 4879 99 4880 99 4881 99 4882 99 4883 99 4884 99 4885 99 4886 99 4887 99 4888 99 4889 99 4890 99 4891 99 4892 99 4893 99 4894 99 4895 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4896 99 4897 99 4898 99 4899 99 4900 99"
			});
			Thread.Sleep(3000);
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4900 99 4901 99 4902 99 4903 99 4904 99 4905 99 4906 99 4907 99 4908 99 4909 99 4910 99 4911 99 4912 99 4913 99 4914 99 4915 99 4916 99 4917 99 4918 99 4919 99 4920 99 4921 99 4922 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4923 99 4924 99 4925 99 4926 99 4927 99 4928 99 4929 99 4930 99 4931 99 4932 99 4933 99 4934 99 4935 99 4936 99 4937 99 4938 99 4939 99 4940 99 4941 99 4942 99 4943 99 4944 99 4945 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4946 99 4947 99 4948 99 4949 99 4950 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4950 99 4951 99 4952 99 4953 99 4954 99 4955 99 4956 99 4957 99 4958 99 4959 99 4960 99 4961 99 4962 99 4963 99 4964 99 4965 99 4966 99 4967 99 4968 99 4969 99 4970 99 4971 99 4972 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4973 99 4974 99 4975 99 4976 99 4977 99 4978 99 4979 99 4980 99 4981 99 4982 99 4983 99 4984 99 4985 99 4986 99 4987 99 4988 99 4989 99 4990 99 4991 99 4992 99 4993 99 4994 99 4995 99"
			});
			this.ixboxConsole_0.CallVoid(2183481560U, new object[]
			{
				selectedIndex,
				0,
				"J 4996 99 4997 99 4998 99 4999 99 5000 99"
			});
			this.ixboxConsole_0.XNotify("Unlock All Finished!\nEnd game to make it stick");
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x000431D4 File Offset: 0x000413D4
		private void simpleButton923_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183692136U, new object[]
			{
				0,
				"toggle cg_thirdperson"
			});
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00043208 File Offset: 0x00041408
		private void simpleButton924_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183692136U, new object[]
			{
				0,
				"toggle cg_draw2d"
			});
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0004323C File Offset: 0x0004143C
		private void simpleButton925_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183692136U, new object[]
			{
				0,
				"toggle cg_scoreboardpingtext"
			});
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00043270 File Offset: 0x00041470
		private void simpleButton929_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists("./Emblems"))
			{
				Directory.CreateDirectory("./Emblems");
			}
			byte[] memory = this.ixboxConsole_0.GetMemory(2210005144U, 1404U);
			File.WriteAllBytes("Emblems\\" + this.textEdit_208.Text + ".bin", memory);
			XtraMessageBox.Show("Emblem file saved to Emblems Folder!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000432E4 File Offset: 0x000414E4
		private void simpleButton930_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Choose Emblem File";
			openFileDialog.Filter = "BIN Files (*.bin)|*.bin";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.ixboxConsole_0.SetMemory(2210005144U, File.ReadAllBytes(openFileDialog.InitialDirectory + openFileDialog.FileName));
				this.ixboxConsole_0.XNotify("Emblem Injected");
			}
			this.ixboxConsole_0.CallVoid(2185237984U, new object[]
			{
				0,
				"updategamerprofile;uploadstats"
			});
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0004337C File Offset: 0x0004157C
		private void method_97(object sender, EventArgs e)
		{
			int selectedIndex = this.listBox3.SelectedIndex;
			this.ixboxConsole_0.WriteInt32(this.method_55(Convert.ToUInt32(selectedIndex) + 19504U), 1);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x000433B8 File Offset: 0x000415B8
		private void simpleButton931_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185545528U, new object[]
			{
				0,
				"lui 9 1 " + this.ixboxConsole_0.ReadInt32(2192922888U).ToString()
			});
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0004340C File Offset: 0x0004160C
		private void simpleButton936_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183692136U, new object[]
			{
				0,
				"cmd mr " + this.ixboxConsole_0.ReadInt32(2188083688U).ToString() + " -1 endround"
			});
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00043464 File Offset: 0x00041664
		private void simpleButton937_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2184440024U, new object[]
			{
				0,
				"cmd mr " + this.ixboxConsole_0.ReadInt32(2191255076U).ToString() + " -1 endround"
			});
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x000434BC File Offset: 0x000416BC
		private void simpleButton938_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2187568800U, new object[]
			{
				0,
				"cmd mr " + this.ixboxConsole_0.ReadInt32(2198239968U).ToString() + " -1 endround"
			});
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00043514 File Offset: 0x00041714
		private void simpleButton939_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2185702272U, new object[]
			{
				0,
				"lui 22 21 " + this.ixboxConsole_0.ReadInt32(2192896468U).ToString()
			});
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00043568 File Offset: 0x00041768
		private void simpleButton934_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183593736U, new object[]
			{
				0,
				"cmd mr " + this.ixboxConsole_0.Call<uint>(2183913816U, new object[]
				{
					"sv_serverid"
				}).ToString() + " -1 endround"
			});
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x000435D0 File Offset: 0x000417D0
		private void simpleButton935_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"cmd mr " + this.ixboxConsole_0.Call<uint>(2182944112U, new object[]
				{
					"sv_serverid"
				}).ToString() + " -1 endround"
			});
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00043638 File Offset: 0x00041838
		private void method_98(string string_3, string string_4)
		{
			this.ixboxConsole_0.CallVoid(2183372752U, new object[]
			{
				0,
				"statset " + string_3 + " " + string_4
			});
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00043678 File Offset: 0x00041878
		private void simpleButton940_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit31.SelectedIndex == 0)
			{
				this.method_98("209", "0");
			}
			if (this.comboBoxEdit31.SelectedIndex == 1)
			{
				this.method_98("209", "1");
			}
			if (this.comboBoxEdit31.SelectedIndex == 2)
			{
				this.method_98("209", "2");
			}
			if (this.comboBoxEdit31.SelectedIndex == 3)
			{
				this.method_98("209", "3");
			}
			if (this.comboBoxEdit31.SelectedIndex == 4)
			{
				this.method_98("209", "4");
			}
			if (this.comboBoxEdit31.SelectedIndex == 5)
			{
				this.method_98("209", "5");
			}
			if (this.comboBoxEdit31.SelectedIndex == 6)
			{
				this.method_98("209", "6");
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00043768 File Offset: 0x00041968
		private void simpleButton942_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit33.SelectedIndex == 0)
			{
				this.method_98("201", "64");
			}
			if (this.comboBoxEdit33.SelectedIndex == 1)
			{
				this.method_98("201", "61");
			}
			if (this.comboBoxEdit33.SelectedIndex == 2)
			{
				this.method_98("201", "60");
			}
			if (this.comboBoxEdit33.SelectedIndex == 3)
			{
				this.method_98("201", "62");
			}
			if (this.comboBoxEdit33.SelectedIndex == 4)
			{
				this.method_98("201", "65");
			}
			if (this.comboBoxEdit33.SelectedIndex == 5)
			{
				this.method_98("201", "20");
			}
			if (this.comboBoxEdit33.SelectedIndex == 6)
			{
				this.method_98("201", "21");
			}
			if (this.comboBoxEdit33.SelectedIndex == 7)
			{
				this.method_98("201", "22");
			}
			if (this.comboBoxEdit33.SelectedIndex == 8)
			{
				this.method_98("201", "23");
			}
			if (this.comboBoxEdit33.SelectedIndex == 9)
			{
				this.method_98("201", "24");
			}
			if (this.comboBoxEdit33.SelectedIndex == 10)
			{
				this.method_98("201", "25");
			}
			if (this.comboBoxEdit33.SelectedIndex == 11)
			{
				this.method_98("201", "26");
			}
			if (this.comboBoxEdit33.SelectedIndex == 12)
			{
				this.method_98("201", "10");
			}
			if (this.comboBoxEdit33.SelectedIndex == 13)
			{
				this.method_98("201", "11");
			}
			if (this.comboBoxEdit33.SelectedIndex == 14)
			{
				this.method_98("201", "12");
			}
			if (this.comboBoxEdit33.SelectedIndex == 15)
			{
				this.method_98("201", "13");
			}
			if (this.comboBoxEdit33.SelectedIndex == 16)
			{
				this.method_98("201", "14");
			}
			if (this.comboBoxEdit33.SelectedIndex == 17)
			{
				this.method_98("201", "70");
			}
			if (this.comboBoxEdit33.SelectedIndex == 18)
			{
				this.method_98("201", "71");
			}
			if (this.comboBoxEdit33.SelectedIndex == 19)
			{
				this.method_98("201", "80");
			}
			if (this.comboBoxEdit33.SelectedIndex == 20)
			{
				this.method_98("201", "81");
			}
			if (this.comboBoxEdit33.SelectedIndex == 21)
			{
				this.method_98("201", "82");
			}
			if (this.comboBoxEdit33.SelectedIndex == 22)
			{
				this.method_98("201", "4");
			}
			if (this.comboBoxEdit33.SelectedIndex == 23)
			{
				this.method_98("201", "2");
			}
			if (this.comboBoxEdit33.SelectedIndex == 24)
			{
				this.method_98("201", "1");
			}
			if (this.comboBoxEdit33.SelectedIndex == 25)
			{
				this.method_98("201", "3");
			}
			if (this.comboBoxEdit33.SelectedIndex == 26)
			{
				this.method_98("201", "0");
			}
			if (this.comboBoxEdit33.SelectedIndex == 27)
			{
				this.method_98("201", "90");
			}
			if (this.comboBoxEdit33.SelectedIndex == 28)
			{
				this.method_98("201", "100");
			}
			if (this.comboBoxEdit33.SelectedIndex == 29)
			{
				this.method_98("201", "91");
			}
			if (this.comboBoxEdit33.SelectedIndex == 30)
			{
				this.method_98("201", "101");
			}
			if (this.comboBoxEdit33.SelectedIndex == 31)
			{
				this.method_98("201", "102");
			}
			if (this.comboBoxEdit33.SelectedIndex == 32)
			{
				this.method_98("201", "103");
			}
			if (this.comboBoxEdit33.SelectedIndex == 33)
			{
				this.method_98("201", "55");
			}
			if (this.comboBoxEdit33.SelectedIndex == 34)
			{
				this.method_98("201", "50");
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00043BF0 File Offset: 0x00041DF0
		private void simpleButton941_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit32.SelectedIndex == 0)
			{
				this.method_98("203", "4");
			}
			if (this.comboBoxEdit32.SelectedIndex == 1)
			{
				this.method_98("203", "2");
			}
			if (this.comboBoxEdit32.SelectedIndex == 2)
			{
				this.method_98("203", "1");
			}
			if (this.comboBoxEdit32.SelectedIndex == 3)
			{
				this.method_98("203", "3");
			}
			if (this.comboBoxEdit32.SelectedIndex == 4)
			{
				this.method_98("203", "0");
			}
			if (this.comboBoxEdit32.SelectedIndex == 5)
			{
				this.method_98("203", "64");
			}
			if (this.comboBoxEdit32.SelectedIndex == 6)
			{
				this.method_98("203", "61");
			}
			if (this.comboBoxEdit32.SelectedIndex == 7)
			{
				this.method_98("203", "60");
			}
			if (this.comboBoxEdit32.SelectedIndex == 8)
			{
				this.method_98("203", "62");
			}
			if (this.comboBoxEdit32.SelectedIndex == 9)
			{
				this.method_98("203", "65");
			}
			if (this.comboBoxEdit32.SelectedIndex == 10)
			{
				this.method_98("203", "20");
			}
			if (this.comboBoxEdit32.SelectedIndex == 11)
			{
				this.method_98("203", "21");
			}
			if (this.comboBoxEdit32.SelectedIndex == 12)
			{
				this.method_98("203", "22");
			}
			if (this.comboBoxEdit32.SelectedIndex == 13)
			{
				this.method_98("203", "23");
			}
			if (this.comboBoxEdit32.SelectedIndex == 14)
			{
				this.method_98("203", "24");
			}
			if (this.comboBoxEdit32.SelectedIndex == 15)
			{
				this.method_98("203", "25");
			}
			if (this.comboBoxEdit32.SelectedIndex == 16)
			{
				this.method_98("203", "26");
			}
			if (this.comboBoxEdit32.SelectedIndex == 17)
			{
				this.method_98("203", "10");
			}
			if (this.comboBoxEdit32.SelectedIndex == 18)
			{
				this.method_98("203", "11");
			}
			if (this.comboBoxEdit32.SelectedIndex == 19)
			{
				this.method_98("203", "12");
			}
			if (this.comboBoxEdit32.SelectedIndex == 20)
			{
				this.method_98("203", "13");
			}
			if (this.comboBoxEdit32.SelectedIndex == 21)
			{
				this.method_98("203", "14");
			}
			if (this.comboBoxEdit32.SelectedIndex == 22)
			{
				this.method_98("203", "70");
			}
			if (this.comboBoxEdit32.SelectedIndex == 23)
			{
				this.method_98("203", "71");
			}
			if (this.comboBoxEdit32.SelectedIndex == 24)
			{
				this.method_98("203", "80");
			}
			if (this.comboBoxEdit32.SelectedIndex == 25)
			{
				this.method_98("203", "81");
			}
			if (this.comboBoxEdit32.SelectedIndex == 26)
			{
				this.method_98("203", "82");
			}
			if (this.comboBoxEdit32.SelectedIndex == 27)
			{
				this.method_98("203", "90");
			}
			if (this.comboBoxEdit32.SelectedIndex == 28)
			{
				this.method_98("203", "100");
			}
			if (this.comboBoxEdit32.SelectedIndex == 29)
			{
				this.method_98("203", "91");
			}
			if (this.comboBoxEdit32.SelectedIndex == 30)
			{
				this.method_98("203", "101");
			}
			if (this.comboBoxEdit32.SelectedIndex == 31)
			{
				this.method_98("203", "102");
			}
			if (this.comboBoxEdit32.SelectedIndex == 32)
			{
				this.method_98("203", "103");
			}
			if (this.comboBoxEdit32.SelectedIndex == 33)
			{
				this.method_98("203", "55");
			}
			if (this.comboBoxEdit32.SelectedIndex == 34)
			{
				this.method_98("203", "50");
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00044078 File Offset: 0x00042278
		private void simpleButton943_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit34.SelectedIndex == 0)
			{
				this.method_98("202", "0");
			}
			if (this.comboBoxEdit34.SelectedIndex == 1)
			{
				this.method_98("202", "1");
			}
			if (this.comboBoxEdit34.SelectedIndex == 2)
			{
				this.method_98("202", "2");
			}
			if (this.comboBoxEdit34.SelectedIndex == 3)
			{
				this.method_98("202", "3");
			}
			if (this.comboBoxEdit34.SelectedIndex == 4)
			{
				this.method_98("202", "4");
			}
			if (this.comboBoxEdit34.SelectedIndex == 5)
			{
				this.method_98("202", "5");
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00044148 File Offset: 0x00042348
		private void simpleButton944_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit35.SelectedIndex == 0)
			{
				this.method_98("204", "0");
			}
			if (this.comboBoxEdit35.SelectedIndex == 1)
			{
				this.method_98("204", "1");
			}
			if (this.comboBoxEdit35.SelectedIndex == 2)
			{
				this.method_98("204", "2");
			}
			if (this.comboBoxEdit35.SelectedIndex == 3)
			{
				this.method_98("204", "3");
			}
			if (this.comboBoxEdit35.SelectedIndex == 4)
			{
				this.method_98("204", "4");
			}
			if (this.comboBoxEdit35.SelectedIndex == 5)
			{
				this.method_98("204", "5");
			}
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00044218 File Offset: 0x00042418
		private void simpleButton947_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit38.SelectedIndex == 0)
			{
				this.method_98("205", "184");
			}
			if (this.comboBoxEdit38.SelectedIndex == 1)
			{
				this.method_98("205", "176");
			}
			if (this.comboBoxEdit38.SelectedIndex == 2)
			{
				this.method_98("205", "186");
			}
			if (this.comboBoxEdit38.SelectedIndex == 3)
			{
				this.method_98("205", "185");
			}
			if (this.comboBoxEdit38.SelectedIndex == 4)
			{
				this.method_98("205", "173");
			}
			if (this.comboBoxEdit38.SelectedIndex == 5)
			{
				this.method_98("205", "165");
			}
			if (this.comboBoxEdit38.SelectedIndex == 6)
			{
				this.method_98("205", "155");
			}
			if (this.comboBoxEdit38.SelectedIndex == 7)
			{
				this.method_98("205", "190");
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00044328 File Offset: 0x00042528
		private void simpleButton945_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit36.SelectedIndex == 0)
			{
				this.method_98("206", "160");
			}
			if (this.comboBoxEdit36.SelectedIndex == 1)
			{
				this.method_98("206", "167");
			}
			if (this.comboBoxEdit36.SelectedIndex == 2)
			{
				this.method_98("206", "164");
			}
			if (this.comboBoxEdit36.SelectedIndex == 3)
			{
				this.method_98("206", "163");
			}
			if (this.comboBoxEdit36.SelectedIndex == 4)
			{
				this.method_98("206", "166");
			}
			if (this.comboBoxEdit36.SelectedIndex == 5)
			{
				this.method_98("206", "151");
			}
			if (this.comboBoxEdit36.SelectedIndex == 6)
			{
				this.method_98("206", "156");
			}
			if (this.comboBoxEdit36.SelectedIndex == 7)
			{
				this.method_98("206", "190");
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00044438 File Offset: 0x00042638
		private void simpleButton946_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit37.SelectedIndex == 0)
			{
				this.method_98("207", "154");
			}
			if (this.comboBoxEdit37.SelectedIndex == 1)
			{
				this.method_98("207", "162");
			}
			if (this.comboBoxEdit37.SelectedIndex == 2)
			{
				this.method_98("207", "157");
			}
			if (this.comboBoxEdit37.SelectedIndex == 3)
			{
				this.method_98("207", "158");
			}
			if (this.comboBoxEdit37.SelectedIndex == 4)
			{
				this.method_98("207", "161");
			}
			if (this.comboBoxEdit37.SelectedIndex == 5)
			{
				this.method_98("207", "152");
			}
			if (this.comboBoxEdit37.SelectedIndex == 6)
			{
				this.method_98("207", "153");
			}
			if (this.comboBoxEdit37.SelectedIndex == 7)
			{
				this.method_98("207", "150");
			}
			if (this.comboBoxEdit37.SelectedIndex == 8)
			{
				this.method_98("207", "190");
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00044568 File Offset: 0x00042768
		private void simpleButton948_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit39.SelectedIndex == 0)
			{
				this.method_98("208", "90");
			}
			if (this.comboBoxEdit39.SelectedIndex == 1)
			{
				this.method_98("208", "100");
			}
			if (this.comboBoxEdit39.SelectedIndex == 2)
			{
				this.method_98("208", "91");
			}
			if (this.comboBoxEdit39.SelectedIndex == 3)
			{
				this.method_98("208", "101");
			}
			if (this.comboBoxEdit39.SelectedIndex == 4)
			{
				this.method_98("208", "102");
			}
			if (this.comboBoxEdit39.SelectedIndex == 5)
			{
				this.method_98("208", "103");
			}
			if (this.comboBoxEdit39.SelectedIndex == 6)
			{
				this.method_98("208", "55");
			}
			if (this.comboBoxEdit39.SelectedIndex == 7)
			{
				this.method_98("208", "50");
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00044678 File Offset: 0x00042878
		private void simpleButton949_Click(object sender, EventArgs e)
		{
			try
			{
				this.simpleButton940_Click(sender, null);
				this.simpleButton942_Click(sender, null);
				this.simpleButton941_Click(sender, null);
				this.simpleButton943_Click(sender, null);
				this.simpleButton944_Click(sender, null);
				this.simpleButton947_Click(sender, null);
				this.simpleButton945_Click(sender, null);
				this.simpleButton946_Click(sender, null);
				this.simpleButton948_Click(sender, null);
				this.ixboxConsole_0.XNotify("All Class Info Set To Class 1!");
			}
			catch (Exception)
			{
				XtraMessageBox.Show("Failed to set all class info, this might indicate you dont have an option set for every function.");
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00044700 File Offset: 0x00042900
		private void simpleButton990_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("Not all weapons and attachments etc can be applied. But I won't prevent you from trying. If a gun or perk doesn't load that means the attachment is not possible, or the camo isn't.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00044700 File Offset: 0x00042900
		private void simpleButton991_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("Not all weapons and attachments etc can be applied. But I won't prevent you from trying. If a gun or perk doesn't load that means the attachment is not possible, or the camo isn't.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00044700 File Offset: 0x00042900
		private void simpleButton992_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("Not all weapons and attachments etc can be applied. But I won't prevent you from trying. If a gun or perk doesn't load that means the attachment is not possible, or the camo isn't.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00044700 File Offset: 0x00042900
		private void simpleButton993_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("Not all weapons and attachments etc can be applied. But I won't prevent you from trying. If a gun or perk doesn't load that means the attachment is not possible, or the camo isn't.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00044700 File Offset: 0x00042900
		private void simpleButton994_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("Not all weapons and attachments etc can be applied. But I won't prevent you from trying. If a gun or perk doesn't load that means the attachment is not possible, or the camo isn't.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00044720 File Offset: 0x00042920
		private void simpleButton959_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit48.SelectedIndex == 0)
			{
				this.method_98("219", "0");
			}
			if (this.comboBoxEdit48.SelectedIndex == 1)
			{
				this.method_98("219", "1");
			}
			if (this.comboBoxEdit48.SelectedIndex == 2)
			{
				this.method_98("219", "2");
			}
			if (this.comboBoxEdit48.SelectedIndex == 3)
			{
				this.method_98("219", "3");
			}
			if (this.comboBoxEdit48.SelectedIndex == 4)
			{
				this.method_98("219", "4");
			}
			if (this.comboBoxEdit48.SelectedIndex == 5)
			{
				this.method_98("219", "5");
			}
			if (this.comboBoxEdit48.SelectedIndex == 6)
			{
				this.method_98("219", "6");
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00044810 File Offset: 0x00042A10
		private void simpleButton957_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit46.SelectedIndex == 0)
			{
				this.method_98("211", "64");
			}
			if (this.comboBoxEdit46.SelectedIndex == 1)
			{
				this.method_98("211", "61");
			}
			if (this.comboBoxEdit46.SelectedIndex == 2)
			{
				this.method_98("211", "60");
			}
			if (this.comboBoxEdit46.SelectedIndex == 3)
			{
				this.method_98("211", "62");
			}
			if (this.comboBoxEdit46.SelectedIndex == 4)
			{
				this.method_98("211", "65");
			}
			if (this.comboBoxEdit46.SelectedIndex == 5)
			{
				this.method_98("211", "20");
			}
			if (this.comboBoxEdit46.SelectedIndex == 6)
			{
				this.method_98("211", "21");
			}
			if (this.comboBoxEdit46.SelectedIndex == 7)
			{
				this.method_98("211", "22");
			}
			if (this.comboBoxEdit46.SelectedIndex == 8)
			{
				this.method_98("211", "23");
			}
			if (this.comboBoxEdit46.SelectedIndex == 9)
			{
				this.method_98("211", "24");
			}
			if (this.comboBoxEdit46.SelectedIndex == 10)
			{
				this.method_98("211", "25");
			}
			if (this.comboBoxEdit46.SelectedIndex == 11)
			{
				this.method_98("211", "26");
			}
			if (this.comboBoxEdit46.SelectedIndex == 12)
			{
				this.method_98("211", "10");
			}
			if (this.comboBoxEdit46.SelectedIndex == 13)
			{
				this.method_98("211", "11");
			}
			if (this.comboBoxEdit46.SelectedIndex == 14)
			{
				this.method_98("211", "12");
			}
			if (this.comboBoxEdit46.SelectedIndex == 15)
			{
				this.method_98("211", "13");
			}
			if (this.comboBoxEdit46.SelectedIndex == 16)
			{
				this.method_98("211", "14");
			}
			if (this.comboBoxEdit46.SelectedIndex == 17)
			{
				this.method_98("211", "70");
			}
			if (this.comboBoxEdit46.SelectedIndex == 18)
			{
				this.method_98("211", "71");
			}
			if (this.comboBoxEdit46.SelectedIndex == 19)
			{
				this.method_98("211", "80");
			}
			if (this.comboBoxEdit46.SelectedIndex == 20)
			{
				this.method_98("211", "81");
			}
			if (this.comboBoxEdit46.SelectedIndex == 21)
			{
				this.method_98("211", "82");
			}
			if (this.comboBoxEdit46.SelectedIndex == 22)
			{
				this.method_98("211", "4");
			}
			if (this.comboBoxEdit46.SelectedIndex == 23)
			{
				this.method_98("211", "2");
			}
			if (this.comboBoxEdit46.SelectedIndex == 24)
			{
				this.method_98("211", "1");
			}
			if (this.comboBoxEdit46.SelectedIndex == 25)
			{
				this.method_98("211", "3");
			}
			if (this.comboBoxEdit46.SelectedIndex == 26)
			{
				this.method_98("211", "0");
			}
			if (this.comboBoxEdit46.SelectedIndex == 27)
			{
				this.method_98("211", "90");
			}
			if (this.comboBoxEdit46.SelectedIndex == 28)
			{
				this.method_98("211", "100");
			}
			if (this.comboBoxEdit46.SelectedIndex == 29)
			{
				this.method_98("211", "91");
			}
			if (this.comboBoxEdit46.SelectedIndex == 30)
			{
				this.method_98("211", "101");
			}
			if (this.comboBoxEdit46.SelectedIndex == 31)
			{
				this.method_98("211", "102");
			}
			if (this.comboBoxEdit46.SelectedIndex == 32)
			{
				this.method_98("211", "103");
			}
			if (this.comboBoxEdit46.SelectedIndex == 33)
			{
				this.method_98("211", "55");
			}
			if (this.comboBoxEdit46.SelectedIndex == 34)
			{
				this.method_98("211", "50");
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00044C98 File Offset: 0x00042E98
		private void simpleButton958_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit47.SelectedIndex == 0)
			{
				this.method_98("213", "4");
			}
			if (this.comboBoxEdit47.SelectedIndex == 1)
			{
				this.method_98("213", "2");
			}
			if (this.comboBoxEdit47.SelectedIndex == 2)
			{
				this.method_98("213", "1");
			}
			if (this.comboBoxEdit47.SelectedIndex == 3)
			{
				this.method_98("213", "3");
			}
			if (this.comboBoxEdit47.SelectedIndex == 4)
			{
				this.method_98("213", "0");
			}
			if (this.comboBoxEdit47.SelectedIndex == 5)
			{
				this.method_98("213", "64");
			}
			if (this.comboBoxEdit47.SelectedIndex == 6)
			{
				this.method_98("213", "61");
			}
			if (this.comboBoxEdit47.SelectedIndex == 7)
			{
				this.method_98("213", "60");
			}
			if (this.comboBoxEdit47.SelectedIndex == 8)
			{
				this.method_98("213", "62");
			}
			if (this.comboBoxEdit47.SelectedIndex == 9)
			{
				this.method_98("213", "65");
			}
			if (this.comboBoxEdit47.SelectedIndex == 10)
			{
				this.method_98("213", "20");
			}
			if (this.comboBoxEdit47.SelectedIndex == 11)
			{
				this.method_98("213", "21");
			}
			if (this.comboBoxEdit47.SelectedIndex == 12)
			{
				this.method_98("213", "22");
			}
			if (this.comboBoxEdit47.SelectedIndex == 13)
			{
				this.method_98("213", "23");
			}
			if (this.comboBoxEdit47.SelectedIndex == 14)
			{
				this.method_98("213", "24");
			}
			if (this.comboBoxEdit47.SelectedIndex == 15)
			{
				this.method_98("213", "25");
			}
			if (this.comboBoxEdit47.SelectedIndex == 16)
			{
				this.method_98("213", "26");
			}
			if (this.comboBoxEdit47.SelectedIndex == 17)
			{
				this.method_98("213", "10");
			}
			if (this.comboBoxEdit47.SelectedIndex == 18)
			{
				this.method_98("213", "11");
			}
			if (this.comboBoxEdit47.SelectedIndex == 19)
			{
				this.method_98("213", "12");
			}
			if (this.comboBoxEdit47.SelectedIndex == 20)
			{
				this.method_98("213", "13");
			}
			if (this.comboBoxEdit47.SelectedIndex == 21)
			{
				this.method_98("213", "14");
			}
			if (this.comboBoxEdit47.SelectedIndex == 22)
			{
				this.method_98("213", "70");
			}
			if (this.comboBoxEdit47.SelectedIndex == 23)
			{
				this.method_98("213", "71");
			}
			if (this.comboBoxEdit47.SelectedIndex == 24)
			{
				this.method_98("213", "80");
			}
			if (this.comboBoxEdit47.SelectedIndex == 25)
			{
				this.method_98("213", "81");
			}
			if (this.comboBoxEdit47.SelectedIndex == 26)
			{
				this.method_98("213", "82");
			}
			if (this.comboBoxEdit47.SelectedIndex == 27)
			{
				this.method_98("213", "90");
			}
			if (this.comboBoxEdit47.SelectedIndex == 28)
			{
				this.method_98("213", "100");
			}
			if (this.comboBoxEdit47.SelectedIndex == 29)
			{
				this.method_98("213", "91");
			}
			if (this.comboBoxEdit47.SelectedIndex == 30)
			{
				this.method_98("213", "101");
			}
			if (this.comboBoxEdit47.SelectedIndex == 31)
			{
				this.method_98("213", "102");
			}
			if (this.comboBoxEdit47.SelectedIndex == 32)
			{
				this.method_98("213", "103");
			}
			if (this.comboBoxEdit47.SelectedIndex == 33)
			{
				this.method_98("213", "55");
			}
			if (this.comboBoxEdit47.SelectedIndex == 34)
			{
				this.method_98("213", "50");
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00045120 File Offset: 0x00043320
		private void simpleButton955_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit44.SelectedIndex == 0)
			{
				this.method_98("212", "0");
			}
			if (this.comboBoxEdit44.SelectedIndex == 1)
			{
				this.method_98("212", "1");
			}
			if (this.comboBoxEdit44.SelectedIndex == 2)
			{
				this.method_98("212", "2");
			}
			if (this.comboBoxEdit44.SelectedIndex == 3)
			{
				this.method_98("212", "3");
			}
			if (this.comboBoxEdit44.SelectedIndex == 4)
			{
				this.method_98("212", "4");
			}
			if (this.comboBoxEdit44.SelectedIndex == 5)
			{
				this.method_98("212", "5");
			}
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x000451F0 File Offset: 0x000433F0
		private void simpleButton956_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit45.SelectedIndex == 0)
			{
				this.method_98("214", "0");
			}
			if (this.comboBoxEdit45.SelectedIndex == 1)
			{
				this.method_98("214", "1");
			}
			if (this.comboBoxEdit45.SelectedIndex == 2)
			{
				this.method_98("214", "2");
			}
			if (this.comboBoxEdit45.SelectedIndex == 3)
			{
				this.method_98("214", "3");
			}
			if (this.comboBoxEdit45.SelectedIndex == 4)
			{
				this.method_98("214", "4");
			}
			if (this.comboBoxEdit45.SelectedIndex == 5)
			{
				this.method_98("214", "5");
			}
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x000452C0 File Offset: 0x000434C0
		private void simpleButton952_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit41.SelectedIndex == 0)
			{
				this.method_98("215", "184");
			}
			if (this.comboBoxEdit41.SelectedIndex == 1)
			{
				this.method_98("215", "176");
			}
			if (this.comboBoxEdit41.SelectedIndex == 2)
			{
				this.method_98("215", "186");
			}
			if (this.comboBoxEdit41.SelectedIndex == 3)
			{
				this.method_98("215", "185");
			}
			if (this.comboBoxEdit41.SelectedIndex == 4)
			{
				this.method_98("215", "173");
			}
			if (this.comboBoxEdit41.SelectedIndex == 5)
			{
				this.method_98("215", "165");
			}
			if (this.comboBoxEdit41.SelectedIndex == 6)
			{
				this.method_98("215", "155");
			}
			if (this.comboBoxEdit41.SelectedIndex == 7)
			{
				this.method_98("215", "190");
			}
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x000453D0 File Offset: 0x000435D0
		private void simpleButton954_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit43.SelectedIndex == 0)
			{
				this.method_98("216", "160");
			}
			if (this.comboBoxEdit43.SelectedIndex == 1)
			{
				this.method_98("216", "167");
			}
			if (this.comboBoxEdit43.SelectedIndex == 2)
			{
				this.method_98("216", "164");
			}
			if (this.comboBoxEdit43.SelectedIndex == 3)
			{
				this.method_98("216", "163");
			}
			if (this.comboBoxEdit43.SelectedIndex == 4)
			{
				this.method_98("216", "166");
			}
			if (this.comboBoxEdit43.SelectedIndex == 5)
			{
				this.method_98("216", "151");
			}
			if (this.comboBoxEdit43.SelectedIndex == 6)
			{
				this.method_98("216", "156");
			}
			if (this.comboBoxEdit43.SelectedIndex == 7)
			{
				this.method_98("216", "190");
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x000454E0 File Offset: 0x000436E0
		private void simpleButton953_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit42.SelectedIndex == 0)
			{
				this.method_98("217", "154");
			}
			if (this.comboBoxEdit42.SelectedIndex == 1)
			{
				this.method_98("217", "162");
			}
			if (this.comboBoxEdit42.SelectedIndex == 2)
			{
				this.method_98("217", "157");
			}
			if (this.comboBoxEdit42.SelectedIndex == 3)
			{
				this.method_98("217", "158");
			}
			if (this.comboBoxEdit42.SelectedIndex == 4)
			{
				this.method_98("217", "161");
			}
			if (this.comboBoxEdit42.SelectedIndex == 5)
			{
				this.method_98("217", "152");
			}
			if (this.comboBoxEdit42.SelectedIndex == 6)
			{
				this.method_98("217", "153");
			}
			if (this.comboBoxEdit42.SelectedIndex == 7)
			{
				this.method_98("217", "150");
			}
			if (this.comboBoxEdit42.SelectedIndex == 8)
			{
				this.method_98("217", "190");
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00045610 File Offset: 0x00043810
		private void simpleButton951_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit40.SelectedIndex == 0)
			{
				this.method_98("218", "90");
			}
			if (this.comboBoxEdit40.SelectedIndex == 1)
			{
				this.method_98("218", "100");
			}
			if (this.comboBoxEdit40.SelectedIndex == 2)
			{
				this.method_98("218", "91");
			}
			if (this.comboBoxEdit40.SelectedIndex == 3)
			{
				this.method_98("218", "101");
			}
			if (this.comboBoxEdit40.SelectedIndex == 4)
			{
				this.method_98("218", "102");
			}
			if (this.comboBoxEdit40.SelectedIndex == 5)
			{
				this.method_98("218", "103");
			}
			if (this.comboBoxEdit40.SelectedIndex == 6)
			{
				this.method_98("218", "55");
			}
			if (this.comboBoxEdit40.SelectedIndex == 7)
			{
				this.method_98("218", "50");
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00045720 File Offset: 0x00043920
		private void simpleButton950_Click(object sender, EventArgs e)
		{
			try
			{
				this.simpleButton959_Click(sender, null);
				this.simpleButton957_Click(sender, null);
				this.simpleButton958_Click(sender, null);
				this.simpleButton955_Click(sender, null);
				this.simpleButton956_Click(sender, null);
				this.simpleButton952_Click(sender, null);
				this.simpleButton954_Click(sender, null);
				this.simpleButton953_Click(sender, null);
				this.simpleButton951_Click(sender, null);
				this.ixboxConsole_0.XNotify("All Class Info Set To Class 2!");
			}
			catch (Exception)
			{
				XtraMessageBox.Show("Failed to set all class info, this might indicate you dont have an option set for every function.");
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x000457A8 File Offset: 0x000439A8
		private void simpleButton960_Click(object sender, EventArgs e)
		{
			try
			{
				this.simpleButton969_Click(sender, null);
				this.simpleButton967_Click(sender, null);
				this.simpleButton968_Click(sender, null);
				this.simpleButton965_Click(sender, null);
				this.simpleButton966_Click(sender, null);
				this.simpleButton962_Click(sender, null);
				this.simpleButton964_Click(sender, null);
				this.simpleButton963_Click(sender, null);
				this.simpleButton961_Click(sender, null);
				this.ixboxConsole_0.XNotify("All Class Info Set To Class 3!");
			}
			catch (Exception)
			{
				XtraMessageBox.Show("Failed to set all class info, this might indicate you dont have an option set for every function.");
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00045830 File Offset: 0x00043A30
		private void simpleButton970_Click(object sender, EventArgs e)
		{
			try
			{
				this.simpleButton979_Click(sender, null);
				this.simpleButton977_Click(sender, null);
				this.simpleButton978_Click(sender, null);
				this.simpleButton975_Click(sender, null);
				this.simpleButton976_Click(sender, null);
				this.simpleButton972_Click(sender, null);
				this.simpleButton974_Click(sender, null);
				this.simpleButton973_Click(sender, null);
				this.simpleButton971_Click(sender, null);
				this.ixboxConsole_0.XNotify("All Class Info Set To Class 4!");
			}
			catch (Exception)
			{
				XtraMessageBox.Show("Failed to set all class info, this might indicate you dont have an option set for every function.");
			}
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x000458B8 File Offset: 0x00043AB8
		private void simpleButton969_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit57.SelectedIndex == 0)
			{
				this.method_98("229", "0");
			}
			if (this.comboBoxEdit57.SelectedIndex == 1)
			{
				this.method_98("229", "1");
			}
			if (this.comboBoxEdit57.SelectedIndex == 2)
			{
				this.method_98("229", "2");
			}
			if (this.comboBoxEdit57.SelectedIndex == 3)
			{
				this.method_98("229", "3");
			}
			if (this.comboBoxEdit57.SelectedIndex == 4)
			{
				this.method_98("229", "4");
			}
			if (this.comboBoxEdit57.SelectedIndex == 5)
			{
				this.method_98("229", "5");
			}
			if (this.comboBoxEdit57.SelectedIndex == 6)
			{
				this.method_98("229", "6");
			}
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x000459A8 File Offset: 0x00043BA8
		private void simpleButton967_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit55.SelectedIndex == 0)
			{
				this.method_98("221", "64");
			}
			if (this.comboBoxEdit55.SelectedIndex == 1)
			{
				this.method_98("221", "61");
			}
			if (this.comboBoxEdit55.SelectedIndex == 2)
			{
				this.method_98("221", "60");
			}
			if (this.comboBoxEdit55.SelectedIndex == 3)
			{
				this.method_98("221", "62");
			}
			if (this.comboBoxEdit55.SelectedIndex == 4)
			{
				this.method_98("221", "65");
			}
			if (this.comboBoxEdit55.SelectedIndex == 5)
			{
				this.method_98("221", "20");
			}
			if (this.comboBoxEdit55.SelectedIndex == 6)
			{
				this.method_98("221", "21");
			}
			if (this.comboBoxEdit55.SelectedIndex == 7)
			{
				this.method_98("221", "22");
			}
			if (this.comboBoxEdit55.SelectedIndex == 8)
			{
				this.method_98("221", "23");
			}
			if (this.comboBoxEdit55.SelectedIndex == 9)
			{
				this.method_98("221", "24");
			}
			if (this.comboBoxEdit55.SelectedIndex == 10)
			{
				this.method_98("221", "25");
			}
			if (this.comboBoxEdit55.SelectedIndex == 11)
			{
				this.method_98("221", "26");
			}
			if (this.comboBoxEdit55.SelectedIndex == 12)
			{
				this.method_98("221", "10");
			}
			if (this.comboBoxEdit55.SelectedIndex == 13)
			{
				this.method_98("221", "11");
			}
			if (this.comboBoxEdit55.SelectedIndex == 14)
			{
				this.method_98("221", "12");
			}
			if (this.comboBoxEdit55.SelectedIndex == 15)
			{
				this.method_98("221", "13");
			}
			if (this.comboBoxEdit55.SelectedIndex == 16)
			{
				this.method_98("221", "14");
			}
			if (this.comboBoxEdit55.SelectedIndex == 17)
			{
				this.method_98("221", "70");
			}
			if (this.comboBoxEdit55.SelectedIndex == 18)
			{
				this.method_98("221", "71");
			}
			if (this.comboBoxEdit55.SelectedIndex == 19)
			{
				this.method_98("221", "80");
			}
			if (this.comboBoxEdit55.SelectedIndex == 20)
			{
				this.method_98("221", "81");
			}
			if (this.comboBoxEdit55.SelectedIndex == 21)
			{
				this.method_98("221", "82");
			}
			if (this.comboBoxEdit55.SelectedIndex == 22)
			{
				this.method_98("221", "4");
			}
			if (this.comboBoxEdit55.SelectedIndex == 23)
			{
				this.method_98("221", "2");
			}
			if (this.comboBoxEdit55.SelectedIndex == 24)
			{
				this.method_98("221", "1");
			}
			if (this.comboBoxEdit55.SelectedIndex == 25)
			{
				this.method_98("221", "3");
			}
			if (this.comboBoxEdit55.SelectedIndex == 26)
			{
				this.method_98("221", "0");
			}
			if (this.comboBoxEdit55.SelectedIndex == 27)
			{
				this.method_98("221", "90");
			}
			if (this.comboBoxEdit55.SelectedIndex == 28)
			{
				this.method_98("221", "100");
			}
			if (this.comboBoxEdit55.SelectedIndex == 29)
			{
				this.method_98("221", "91");
			}
			if (this.comboBoxEdit55.SelectedIndex == 30)
			{
				this.method_98("221", "101");
			}
			if (this.comboBoxEdit55.SelectedIndex == 31)
			{
				this.method_98("221", "102");
			}
			if (this.comboBoxEdit55.SelectedIndex == 32)
			{
				this.method_98("221", "103");
			}
			if (this.comboBoxEdit55.SelectedIndex == 33)
			{
				this.method_98("221", "55");
			}
			if (this.comboBoxEdit55.SelectedIndex == 34)
			{
				this.method_98("221", "50");
			}
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00045E30 File Offset: 0x00044030
		private void simpleButton968_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit56.SelectedIndex == 0)
			{
				this.method_98("223", "4");
			}
			if (this.comboBoxEdit56.SelectedIndex == 1)
			{
				this.method_98("223", "2");
			}
			if (this.comboBoxEdit56.SelectedIndex == 2)
			{
				this.method_98("223", "1");
			}
			if (this.comboBoxEdit56.SelectedIndex == 3)
			{
				this.method_98("223", "3");
			}
			if (this.comboBoxEdit56.SelectedIndex == 4)
			{
				this.method_98("223", "0");
			}
			if (this.comboBoxEdit56.SelectedIndex == 5)
			{
				this.method_98("223", "64");
			}
			if (this.comboBoxEdit56.SelectedIndex == 6)
			{
				this.method_98("223", "61");
			}
			if (this.comboBoxEdit56.SelectedIndex == 7)
			{
				this.method_98("223", "60");
			}
			if (this.comboBoxEdit56.SelectedIndex == 8)
			{
				this.method_98("223", "62");
			}
			if (this.comboBoxEdit56.SelectedIndex == 9)
			{
				this.method_98("223", "65");
			}
			if (this.comboBoxEdit56.SelectedIndex == 10)
			{
				this.method_98("223", "20");
			}
			if (this.comboBoxEdit56.SelectedIndex == 11)
			{
				this.method_98("223", "21");
			}
			if (this.comboBoxEdit56.SelectedIndex == 12)
			{
				this.method_98("223", "22");
			}
			if (this.comboBoxEdit56.SelectedIndex == 13)
			{
				this.method_98("223", "23");
			}
			if (this.comboBoxEdit56.SelectedIndex == 14)
			{
				this.method_98("223", "24");
			}
			if (this.comboBoxEdit56.SelectedIndex == 15)
			{
				this.method_98("223", "25");
			}
			if (this.comboBoxEdit56.SelectedIndex == 16)
			{
				this.method_98("223", "26");
			}
			if (this.comboBoxEdit56.SelectedIndex == 17)
			{
				this.method_98("223", "10");
			}
			if (this.comboBoxEdit56.SelectedIndex == 18)
			{
				this.method_98("223", "11");
			}
			if (this.comboBoxEdit56.SelectedIndex == 19)
			{
				this.method_98("223", "12");
			}
			if (this.comboBoxEdit56.SelectedIndex == 20)
			{
				this.method_98("223", "13");
			}
			if (this.comboBoxEdit56.SelectedIndex == 21)
			{
				this.method_98("223", "14");
			}
			if (this.comboBoxEdit56.SelectedIndex == 22)
			{
				this.method_98("223", "70");
			}
			if (this.comboBoxEdit56.SelectedIndex == 23)
			{
				this.method_98("223", "71");
			}
			if (this.comboBoxEdit56.SelectedIndex == 24)
			{
				this.method_98("223", "80");
			}
			if (this.comboBoxEdit56.SelectedIndex == 25)
			{
				this.method_98("223", "81");
			}
			if (this.comboBoxEdit56.SelectedIndex == 26)
			{
				this.method_98("223", "82");
			}
			if (this.comboBoxEdit56.SelectedIndex == 27)
			{
				this.method_98("223", "90");
			}
			if (this.comboBoxEdit56.SelectedIndex == 28)
			{
				this.method_98("223", "100");
			}
			if (this.comboBoxEdit56.SelectedIndex == 29)
			{
				this.method_98("223", "91");
			}
			if (this.comboBoxEdit56.SelectedIndex == 30)
			{
				this.method_98("223", "101");
			}
			if (this.comboBoxEdit56.SelectedIndex == 31)
			{
				this.method_98("223", "102");
			}
			if (this.comboBoxEdit56.SelectedIndex == 32)
			{
				this.method_98("223", "103");
			}
			if (this.comboBoxEdit56.SelectedIndex == 33)
			{
				this.method_98("223", "55");
			}
			if (this.comboBoxEdit56.SelectedIndex == 34)
			{
				this.method_98("223", "50");
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000462B8 File Offset: 0x000444B8
		private void simpleButton965_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit53.SelectedIndex == 0)
			{
				this.method_98("222", "0");
			}
			if (this.comboBoxEdit53.SelectedIndex == 1)
			{
				this.method_98("222", "1");
			}
			if (this.comboBoxEdit53.SelectedIndex == 2)
			{
				this.method_98("222", "2");
			}
			if (this.comboBoxEdit53.SelectedIndex == 3)
			{
				this.method_98("222", "3");
			}
			if (this.comboBoxEdit53.SelectedIndex == 4)
			{
				this.method_98("222", "4");
			}
			if (this.comboBoxEdit53.SelectedIndex == 5)
			{
				this.method_98("222", "5");
			}
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00046388 File Offset: 0x00044588
		private void simpleButton966_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit54.SelectedIndex == 0)
			{
				this.method_98("224", "0");
			}
			if (this.comboBoxEdit54.SelectedIndex == 1)
			{
				this.method_98("224", "1");
			}
			if (this.comboBoxEdit54.SelectedIndex == 2)
			{
				this.method_98("224", "2");
			}
			if (this.comboBoxEdit54.SelectedIndex == 3)
			{
				this.method_98("224", "3");
			}
			if (this.comboBoxEdit54.SelectedIndex == 4)
			{
				this.method_98("224", "4");
			}
			if (this.comboBoxEdit54.SelectedIndex == 5)
			{
				this.method_98("224", "5");
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00046458 File Offset: 0x00044658
		private void simpleButton962_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit50.SelectedIndex == 0)
			{
				this.method_98("225", "184");
			}
			if (this.comboBoxEdit50.SelectedIndex == 1)
			{
				this.method_98("225", "176");
			}
			if (this.comboBoxEdit50.SelectedIndex == 2)
			{
				this.method_98("225", "186");
			}
			if (this.comboBoxEdit50.SelectedIndex == 3)
			{
				this.method_98("225", "185");
			}
			if (this.comboBoxEdit50.SelectedIndex == 4)
			{
				this.method_98("225", "173");
			}
			if (this.comboBoxEdit50.SelectedIndex == 5)
			{
				this.method_98("225", "165");
			}
			if (this.comboBoxEdit50.SelectedIndex == 6)
			{
				this.method_98("225", "155");
			}
			if (this.comboBoxEdit50.SelectedIndex == 7)
			{
				this.method_98("225", "190");
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00046568 File Offset: 0x00044768
		private void simpleButton964_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit52.SelectedIndex == 0)
			{
				this.method_98("226", "160");
			}
			if (this.comboBoxEdit52.SelectedIndex == 1)
			{
				this.method_98("226", "167");
			}
			if (this.comboBoxEdit52.SelectedIndex == 2)
			{
				this.method_98("226", "164");
			}
			if (this.comboBoxEdit52.SelectedIndex == 3)
			{
				this.method_98("226", "163");
			}
			if (this.comboBoxEdit52.SelectedIndex == 4)
			{
				this.method_98("226", "166");
			}
			if (this.comboBoxEdit52.SelectedIndex == 5)
			{
				this.method_98("226", "151");
			}
			if (this.comboBoxEdit52.SelectedIndex == 6)
			{
				this.method_98("226", "156");
			}
			if (this.comboBoxEdit52.SelectedIndex == 7)
			{
				this.method_98("226", "190");
			}
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00046678 File Offset: 0x00044878
		private void simpleButton963_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit51.SelectedIndex == 0)
			{
				this.method_98("227", "154");
			}
			if (this.comboBoxEdit51.SelectedIndex == 1)
			{
				this.method_98("227", "162");
			}
			if (this.comboBoxEdit51.SelectedIndex == 2)
			{
				this.method_98("227", "157");
			}
			if (this.comboBoxEdit51.SelectedIndex == 3)
			{
				this.method_98("227", "158");
			}
			if (this.comboBoxEdit51.SelectedIndex == 4)
			{
				this.method_98("227", "161");
			}
			if (this.comboBoxEdit51.SelectedIndex == 5)
			{
				this.method_98("227", "152");
			}
			if (this.comboBoxEdit51.SelectedIndex == 6)
			{
				this.method_98("227", "153");
			}
			if (this.comboBoxEdit51.SelectedIndex == 7)
			{
				this.method_98("227", "150");
			}
			if (this.comboBoxEdit51.SelectedIndex == 8)
			{
				this.method_98("227", "190");
			}
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x000467A8 File Offset: 0x000449A8
		private void simpleButton961_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit49.SelectedIndex == 0)
			{
				this.method_98("228", "90");
			}
			if (this.comboBoxEdit49.SelectedIndex == 1)
			{
				this.method_98("228", "100");
			}
			if (this.comboBoxEdit49.SelectedIndex == 2)
			{
				this.method_98("228", "91");
			}
			if (this.comboBoxEdit49.SelectedIndex == 3)
			{
				this.method_98("228", "101");
			}
			if (this.comboBoxEdit49.SelectedIndex == 4)
			{
				this.method_98("228", "102");
			}
			if (this.comboBoxEdit49.SelectedIndex == 5)
			{
				this.method_98("228", "103");
			}
			if (this.comboBoxEdit49.SelectedIndex == 6)
			{
				this.method_98("228", "55");
			}
			if (this.comboBoxEdit49.SelectedIndex == 7)
			{
				this.method_98("228", "50");
			}
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000468B8 File Offset: 0x00044AB8
		private void simpleButton979_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit66.SelectedIndex == 0)
			{
				this.method_98("239", "0");
			}
			if (this.comboBoxEdit66.SelectedIndex == 1)
			{
				this.method_98("239", "1");
			}
			if (this.comboBoxEdit66.SelectedIndex == 2)
			{
				this.method_98("239", "2");
			}
			if (this.comboBoxEdit66.SelectedIndex == 3)
			{
				this.method_98("239", "3");
			}
			if (this.comboBoxEdit66.SelectedIndex == 4)
			{
				this.method_98("239", "4");
			}
			if (this.comboBoxEdit66.SelectedIndex == 5)
			{
				this.method_98("239", "5");
			}
			if (this.comboBoxEdit66.SelectedIndex == 6)
			{
				this.method_98("239", "6");
			}
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x000469A8 File Offset: 0x00044BA8
		private void simpleButton977_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit64.SelectedIndex == 0)
			{
				this.method_98("231", "64");
			}
			if (this.comboBoxEdit64.SelectedIndex == 1)
			{
				this.method_98("231", "61");
			}
			if (this.comboBoxEdit64.SelectedIndex == 2)
			{
				this.method_98("231", "60");
			}
			if (this.comboBoxEdit64.SelectedIndex == 3)
			{
				this.method_98("231", "62");
			}
			if (this.comboBoxEdit64.SelectedIndex == 4)
			{
				this.method_98("231", "65");
			}
			if (this.comboBoxEdit64.SelectedIndex == 5)
			{
				this.method_98("231", "20");
			}
			if (this.comboBoxEdit64.SelectedIndex == 6)
			{
				this.method_98("231", "21");
			}
			if (this.comboBoxEdit64.SelectedIndex == 7)
			{
				this.method_98("231", "22");
			}
			if (this.comboBoxEdit64.SelectedIndex == 8)
			{
				this.method_98("231", "23");
			}
			if (this.comboBoxEdit64.SelectedIndex == 9)
			{
				this.method_98("231", "24");
			}
			if (this.comboBoxEdit64.SelectedIndex == 10)
			{
				this.method_98("231", "25");
			}
			if (this.comboBoxEdit64.SelectedIndex == 11)
			{
				this.method_98("231", "26");
			}
			if (this.comboBoxEdit64.SelectedIndex == 12)
			{
				this.method_98("231", "10");
			}
			if (this.comboBoxEdit64.SelectedIndex == 13)
			{
				this.method_98("231", "11");
			}
			if (this.comboBoxEdit64.SelectedIndex == 14)
			{
				this.method_98("231", "12");
			}
			if (this.comboBoxEdit64.SelectedIndex == 15)
			{
				this.method_98("231", "13");
			}
			if (this.comboBoxEdit64.SelectedIndex == 16)
			{
				this.method_98("231", "14");
			}
			if (this.comboBoxEdit64.SelectedIndex == 17)
			{
				this.method_98("231", "70");
			}
			if (this.comboBoxEdit64.SelectedIndex == 18)
			{
				this.method_98("231", "71");
			}
			if (this.comboBoxEdit64.SelectedIndex == 19)
			{
				this.method_98("231", "80");
			}
			if (this.comboBoxEdit64.SelectedIndex == 20)
			{
				this.method_98("231", "81");
			}
			if (this.comboBoxEdit64.SelectedIndex == 21)
			{
				this.method_98("231", "82");
			}
			if (this.comboBoxEdit64.SelectedIndex == 22)
			{
				this.method_98("231", "4");
			}
			if (this.comboBoxEdit64.SelectedIndex == 23)
			{
				this.method_98("231", "2");
			}
			if (this.comboBoxEdit64.SelectedIndex == 24)
			{
				this.method_98("231", "1");
			}
			if (this.comboBoxEdit64.SelectedIndex == 25)
			{
				this.method_98("231", "3");
			}
			if (this.comboBoxEdit64.SelectedIndex == 26)
			{
				this.method_98("231", "0");
			}
			if (this.comboBoxEdit64.SelectedIndex == 27)
			{
				this.method_98("231", "90");
			}
			if (this.comboBoxEdit64.SelectedIndex == 28)
			{
				this.method_98("231", "100");
			}
			if (this.comboBoxEdit64.SelectedIndex == 29)
			{
				this.method_98("231", "91");
			}
			if (this.comboBoxEdit64.SelectedIndex == 30)
			{
				this.method_98("231", "101");
			}
			if (this.comboBoxEdit64.SelectedIndex == 31)
			{
				this.method_98("231", "102");
			}
			if (this.comboBoxEdit64.SelectedIndex == 32)
			{
				this.method_98("231", "103");
			}
			if (this.comboBoxEdit64.SelectedIndex == 33)
			{
				this.method_98("231", "55");
			}
			if (this.comboBoxEdit64.SelectedIndex == 34)
			{
				this.method_98("231", "50");
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00046E30 File Offset: 0x00045030
		private void simpleButton978_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit65.SelectedIndex == 0)
			{
				this.method_98("233", "4");
			}
			if (this.comboBoxEdit65.SelectedIndex == 1)
			{
				this.method_98("233", "2");
			}
			if (this.comboBoxEdit65.SelectedIndex == 2)
			{
				this.method_98("233", "1");
			}
			if (this.comboBoxEdit65.SelectedIndex == 3)
			{
				this.method_98("233", "3");
			}
			if (this.comboBoxEdit65.SelectedIndex == 4)
			{
				this.method_98("233", "0");
			}
			if (this.comboBoxEdit65.SelectedIndex == 5)
			{
				this.method_98("233", "64");
			}
			if (this.comboBoxEdit65.SelectedIndex == 6)
			{
				this.method_98("233", "61");
			}
			if (this.comboBoxEdit65.SelectedIndex == 7)
			{
				this.method_98("233", "60");
			}
			if (this.comboBoxEdit65.SelectedIndex == 8)
			{
				this.method_98("233", "62");
			}
			if (this.comboBoxEdit65.SelectedIndex == 9)
			{
				this.method_98("233", "65");
			}
			if (this.comboBoxEdit65.SelectedIndex == 10)
			{
				this.method_98("233", "20");
			}
			if (this.comboBoxEdit65.SelectedIndex == 11)
			{
				this.method_98("233", "21");
			}
			if (this.comboBoxEdit65.SelectedIndex == 12)
			{
				this.method_98("233", "22");
			}
			if (this.comboBoxEdit65.SelectedIndex == 13)
			{
				this.method_98("233", "23");
			}
			if (this.comboBoxEdit65.SelectedIndex == 14)
			{
				this.method_98("233", "24");
			}
			if (this.comboBoxEdit65.SelectedIndex == 15)
			{
				this.method_98("233", "25");
			}
			if (this.comboBoxEdit65.SelectedIndex == 16)
			{
				this.method_98("233", "26");
			}
			if (this.comboBoxEdit65.SelectedIndex == 17)
			{
				this.method_98("233", "10");
			}
			if (this.comboBoxEdit65.SelectedIndex == 18)
			{
				this.method_98("233", "11");
			}
			if (this.comboBoxEdit65.SelectedIndex == 19)
			{
				this.method_98("233", "12");
			}
			if (this.comboBoxEdit65.SelectedIndex == 20)
			{
				this.method_98("233", "13");
			}
			if (this.comboBoxEdit65.SelectedIndex == 21)
			{
				this.method_98("233", "14");
			}
			if (this.comboBoxEdit65.SelectedIndex == 22)
			{
				this.method_98("233", "70");
			}
			if (this.comboBoxEdit65.SelectedIndex == 23)
			{
				this.method_98("233", "71");
			}
			if (this.comboBoxEdit65.SelectedIndex == 24)
			{
				this.method_98("233", "80");
			}
			if (this.comboBoxEdit65.SelectedIndex == 25)
			{
				this.method_98("233", "81");
			}
			if (this.comboBoxEdit65.SelectedIndex == 26)
			{
				this.method_98("233", "82");
			}
			if (this.comboBoxEdit65.SelectedIndex == 27)
			{
				this.method_98("233", "90");
			}
			if (this.comboBoxEdit65.SelectedIndex == 28)
			{
				this.method_98("233", "100");
			}
			if (this.comboBoxEdit65.SelectedIndex == 29)
			{
				this.method_98("233", "91");
			}
			if (this.comboBoxEdit65.SelectedIndex == 30)
			{
				this.method_98("233", "101");
			}
			if (this.comboBoxEdit65.SelectedIndex == 31)
			{
				this.method_98("233", "102");
			}
			if (this.comboBoxEdit65.SelectedIndex == 32)
			{
				this.method_98("233", "103");
			}
			if (this.comboBoxEdit65.SelectedIndex == 33)
			{
				this.method_98("233", "55");
			}
			if (this.comboBoxEdit65.SelectedIndex == 34)
			{
				this.method_98("233", "50");
			}
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x000472B8 File Offset: 0x000454B8
		private void simpleButton975_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit62.SelectedIndex == 0)
			{
				this.method_98("232", "0");
			}
			if (this.comboBoxEdit62.SelectedIndex == 1)
			{
				this.method_98("232", "1");
			}
			if (this.comboBoxEdit62.SelectedIndex == 2)
			{
				this.method_98("232", "2");
			}
			if (this.comboBoxEdit62.SelectedIndex == 3)
			{
				this.method_98("232", "3");
			}
			if (this.comboBoxEdit62.SelectedIndex == 4)
			{
				this.method_98("232", "4");
			}
			if (this.comboBoxEdit62.SelectedIndex == 5)
			{
				this.method_98("232", "5");
			}
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00047388 File Offset: 0x00045588
		private void simpleButton976_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit63.SelectedIndex == 0)
			{
				this.method_98("234", "0");
			}
			if (this.comboBoxEdit63.SelectedIndex == 1)
			{
				this.method_98("234", "1");
			}
			if (this.comboBoxEdit63.SelectedIndex == 2)
			{
				this.method_98("234", "2");
			}
			if (this.comboBoxEdit63.SelectedIndex == 3)
			{
				this.method_98("234", "3");
			}
			if (this.comboBoxEdit63.SelectedIndex == 4)
			{
				this.method_98("234", "4");
			}
			if (this.comboBoxEdit63.SelectedIndex == 5)
			{
				this.method_98("234", "5");
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00047458 File Offset: 0x00045658
		private void simpleButton972_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit59.SelectedIndex == 0)
			{
				this.method_98("235", "184");
			}
			if (this.comboBoxEdit59.SelectedIndex == 1)
			{
				this.method_98("235", "176");
			}
			if (this.comboBoxEdit59.SelectedIndex == 2)
			{
				this.method_98("235", "186");
			}
			if (this.comboBoxEdit59.SelectedIndex == 3)
			{
				this.method_98("235", "185");
			}
			if (this.comboBoxEdit59.SelectedIndex == 4)
			{
				this.method_98("235", "173");
			}
			if (this.comboBoxEdit59.SelectedIndex == 5)
			{
				this.method_98("235", "165");
			}
			if (this.comboBoxEdit59.SelectedIndex == 6)
			{
				this.method_98("235", "155");
			}
			if (this.comboBoxEdit59.SelectedIndex == 7)
			{
				this.method_98("235", "190");
			}
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00047568 File Offset: 0x00045768
		private void simpleButton974_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit61.SelectedIndex == 0)
			{
				this.method_98("236", "160");
			}
			if (this.comboBoxEdit61.SelectedIndex == 1)
			{
				this.method_98("236", "167");
			}
			if (this.comboBoxEdit61.SelectedIndex == 2)
			{
				this.method_98("236", "164");
			}
			if (this.comboBoxEdit61.SelectedIndex == 3)
			{
				this.method_98("236", "163");
			}
			if (this.comboBoxEdit61.SelectedIndex == 4)
			{
				this.method_98("236", "166");
			}
			if (this.comboBoxEdit61.SelectedIndex == 5)
			{
				this.method_98("236", "151");
			}
			if (this.comboBoxEdit61.SelectedIndex == 6)
			{
				this.method_98("236", "156");
			}
			if (this.comboBoxEdit61.SelectedIndex == 7)
			{
				this.method_98("236", "190");
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00047678 File Offset: 0x00045878
		private void simpleButton973_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit60.SelectedIndex == 0)
			{
				this.method_98("237", "154");
			}
			if (this.comboBoxEdit60.SelectedIndex == 1)
			{
				this.method_98("237", "162");
			}
			if (this.comboBoxEdit60.SelectedIndex == 2)
			{
				this.method_98("237", "157");
			}
			if (this.comboBoxEdit60.SelectedIndex == 3)
			{
				this.method_98("237", "158");
			}
			if (this.comboBoxEdit60.SelectedIndex == 4)
			{
				this.method_98("237", "161");
			}
			if (this.comboBoxEdit60.SelectedIndex == 5)
			{
				this.method_98("237", "152");
			}
			if (this.comboBoxEdit60.SelectedIndex == 6)
			{
				this.method_98("237", "153");
			}
			if (this.comboBoxEdit60.SelectedIndex == 7)
			{
				this.method_98("237", "150");
			}
			if (this.comboBoxEdit60.SelectedIndex == 8)
			{
				this.method_98("237", "190");
			}
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000477A8 File Offset: 0x000459A8
		private void simpleButton971_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit58.SelectedIndex == 0)
			{
				this.method_98("238", "90");
			}
			if (this.comboBoxEdit58.SelectedIndex == 1)
			{
				this.method_98("238", "100");
			}
			if (this.comboBoxEdit58.SelectedIndex == 2)
			{
				this.method_98("238", "91");
			}
			if (this.comboBoxEdit58.SelectedIndex == 3)
			{
				this.method_98("238", "101");
			}
			if (this.comboBoxEdit58.SelectedIndex == 4)
			{
				this.method_98("238", "102");
			}
			if (this.comboBoxEdit58.SelectedIndex == 5)
			{
				this.method_98("238", "103");
			}
			if (this.comboBoxEdit58.SelectedIndex == 6)
			{
				this.method_98("238", "55");
			}
			if (this.comboBoxEdit58.SelectedIndex == 7)
			{
				this.method_98("238", "50");
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x000478B8 File Offset: 0x00045AB8
		private void simpleButton989_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit75.SelectedIndex == 0)
			{
				this.method_98("249", "0");
			}
			if (this.comboBoxEdit75.SelectedIndex == 1)
			{
				this.method_98("249", "1");
			}
			if (this.comboBoxEdit75.SelectedIndex == 2)
			{
				this.method_98("249", "2");
			}
			if (this.comboBoxEdit75.SelectedIndex == 3)
			{
				this.method_98("249", "3");
			}
			if (this.comboBoxEdit75.SelectedIndex == 4)
			{
				this.method_98("249", "4");
			}
			if (this.comboBoxEdit75.SelectedIndex == 5)
			{
				this.method_98("249", "5");
			}
			if (this.comboBoxEdit75.SelectedIndex == 6)
			{
				this.method_98("249", "6");
			}
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000479A8 File Offset: 0x00045BA8
		private void simpleButton987_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit73.SelectedIndex == 0)
			{
				this.method_98("241", "64");
			}
			if (this.comboBoxEdit73.SelectedIndex == 1)
			{
				this.method_98("241", "61");
			}
			if (this.comboBoxEdit73.SelectedIndex == 2)
			{
				this.method_98("241", "60");
			}
			if (this.comboBoxEdit73.SelectedIndex == 3)
			{
				this.method_98("241", "62");
			}
			if (this.comboBoxEdit73.SelectedIndex == 4)
			{
				this.method_98("241", "65");
			}
			if (this.comboBoxEdit73.SelectedIndex == 5)
			{
				this.method_98("241", "20");
			}
			if (this.comboBoxEdit73.SelectedIndex == 6)
			{
				this.method_98("241", "21");
			}
			if (this.comboBoxEdit73.SelectedIndex == 7)
			{
				this.method_98("241", "22");
			}
			if (this.comboBoxEdit73.SelectedIndex == 8)
			{
				this.method_98("241", "23");
			}
			if (this.comboBoxEdit73.SelectedIndex == 9)
			{
				this.method_98("241", "24");
			}
			if (this.comboBoxEdit73.SelectedIndex == 10)
			{
				this.method_98("241", "25");
			}
			if (this.comboBoxEdit73.SelectedIndex == 11)
			{
				this.method_98("241", "26");
			}
			if (this.comboBoxEdit73.SelectedIndex == 12)
			{
				this.method_98("241", "10");
			}
			if (this.comboBoxEdit73.SelectedIndex == 13)
			{
				this.method_98("241", "11");
			}
			if (this.comboBoxEdit73.SelectedIndex == 14)
			{
				this.method_98("241", "12");
			}
			if (this.comboBoxEdit73.SelectedIndex == 15)
			{
				this.method_98("241", "13");
			}
			if (this.comboBoxEdit73.SelectedIndex == 16)
			{
				this.method_98("241", "14");
			}
			if (this.comboBoxEdit73.SelectedIndex == 17)
			{
				this.method_98("241", "70");
			}
			if (this.comboBoxEdit73.SelectedIndex == 18)
			{
				this.method_98("241", "71");
			}
			if (this.comboBoxEdit73.SelectedIndex == 19)
			{
				this.method_98("241", "80");
			}
			if (this.comboBoxEdit73.SelectedIndex == 20)
			{
				this.method_98("241", "81");
			}
			if (this.comboBoxEdit73.SelectedIndex == 21)
			{
				this.method_98("241", "82");
			}
			if (this.comboBoxEdit73.SelectedIndex == 22)
			{
				this.method_98("241", "4");
			}
			if (this.comboBoxEdit73.SelectedIndex == 23)
			{
				this.method_98("241", "2");
			}
			if (this.comboBoxEdit73.SelectedIndex == 24)
			{
				this.method_98("241", "1");
			}
			if (this.comboBoxEdit73.SelectedIndex == 25)
			{
				this.method_98("241", "3");
			}
			if (this.comboBoxEdit73.SelectedIndex == 26)
			{
				this.method_98("241", "0");
			}
			if (this.comboBoxEdit73.SelectedIndex == 27)
			{
				this.method_98("241", "90");
			}
			if (this.comboBoxEdit73.SelectedIndex == 28)
			{
				this.method_98("241", "100");
			}
			if (this.comboBoxEdit73.SelectedIndex == 29)
			{
				this.method_98("241", "91");
			}
			if (this.comboBoxEdit73.SelectedIndex == 30)
			{
				this.method_98("241", "101");
			}
			if (this.comboBoxEdit73.SelectedIndex == 31)
			{
				this.method_98("241", "102");
			}
			if (this.comboBoxEdit73.SelectedIndex == 32)
			{
				this.method_98("241", "103");
			}
			if (this.comboBoxEdit73.SelectedIndex == 33)
			{
				this.method_98("241", "55");
			}
			if (this.comboBoxEdit73.SelectedIndex == 34)
			{
				this.method_98("241", "50");
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00047E30 File Offset: 0x00046030
		private void simpleButton988_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit74.SelectedIndex == 0)
			{
				this.method_98("243", "4");
			}
			if (this.comboBoxEdit74.SelectedIndex == 1)
			{
				this.method_98("243", "2");
			}
			if (this.comboBoxEdit74.SelectedIndex == 2)
			{
				this.method_98("243", "1");
			}
			if (this.comboBoxEdit74.SelectedIndex == 3)
			{
				this.method_98("243", "3");
			}
			if (this.comboBoxEdit74.SelectedIndex == 4)
			{
				this.method_98("243", "0");
			}
			if (this.comboBoxEdit74.SelectedIndex == 5)
			{
				this.method_98("243", "64");
			}
			if (this.comboBoxEdit74.SelectedIndex == 6)
			{
				this.method_98("243", "61");
			}
			if (this.comboBoxEdit74.SelectedIndex == 7)
			{
				this.method_98("243", "60");
			}
			if (this.comboBoxEdit74.SelectedIndex == 8)
			{
				this.method_98("243", "62");
			}
			if (this.comboBoxEdit74.SelectedIndex == 9)
			{
				this.method_98("243", "65");
			}
			if (this.comboBoxEdit74.SelectedIndex == 10)
			{
				this.method_98("243", "20");
			}
			if (this.comboBoxEdit74.SelectedIndex == 11)
			{
				this.method_98("243", "21");
			}
			if (this.comboBoxEdit74.SelectedIndex == 12)
			{
				this.method_98("243", "22");
			}
			if (this.comboBoxEdit74.SelectedIndex == 13)
			{
				this.method_98("243", "23");
			}
			if (this.comboBoxEdit74.SelectedIndex == 14)
			{
				this.method_98("243", "24");
			}
			if (this.comboBoxEdit74.SelectedIndex == 15)
			{
				this.method_98("243", "25");
			}
			if (this.comboBoxEdit74.SelectedIndex == 16)
			{
				this.method_98("243", "26");
			}
			if (this.comboBoxEdit74.SelectedIndex == 17)
			{
				this.method_98("243", "10");
			}
			if (this.comboBoxEdit74.SelectedIndex == 18)
			{
				this.method_98("243", "11");
			}
			if (this.comboBoxEdit74.SelectedIndex == 19)
			{
				this.method_98("243", "12");
			}
			if (this.comboBoxEdit74.SelectedIndex == 20)
			{
				this.method_98("243", "13");
			}
			if (this.comboBoxEdit74.SelectedIndex == 21)
			{
				this.method_98("243", "14");
			}
			if (this.comboBoxEdit74.SelectedIndex == 22)
			{
				this.method_98("243", "70");
			}
			if (this.comboBoxEdit74.SelectedIndex == 23)
			{
				this.method_98("243", "71");
			}
			if (this.comboBoxEdit74.SelectedIndex == 24)
			{
				this.method_98("243", "80");
			}
			if (this.comboBoxEdit74.SelectedIndex == 25)
			{
				this.method_98("243", "81");
			}
			if (this.comboBoxEdit74.SelectedIndex == 26)
			{
				this.method_98("243", "82");
			}
			if (this.comboBoxEdit74.SelectedIndex == 27)
			{
				this.method_98("243", "90");
			}
			if (this.comboBoxEdit74.SelectedIndex == 28)
			{
				this.method_98("243", "100");
			}
			if (this.comboBoxEdit74.SelectedIndex == 29)
			{
				this.method_98("243", "91");
			}
			if (this.comboBoxEdit74.SelectedIndex == 30)
			{
				this.method_98("243", "101");
			}
			if (this.comboBoxEdit74.SelectedIndex == 31)
			{
				this.method_98("243", "102");
			}
			if (this.comboBoxEdit74.SelectedIndex == 32)
			{
				this.method_98("243", "103");
			}
			if (this.comboBoxEdit74.SelectedIndex == 33)
			{
				this.method_98("243", "55");
			}
			if (this.comboBoxEdit74.SelectedIndex == 34)
			{
				this.method_98("243", "50");
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x000482B8 File Offset: 0x000464B8
		private void simpleButton985_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit71.SelectedIndex == 0)
			{
				this.method_98("242", "0");
			}
			if (this.comboBoxEdit71.SelectedIndex == 1)
			{
				this.method_98("242", "1");
			}
			if (this.comboBoxEdit71.SelectedIndex == 2)
			{
				this.method_98("242", "2");
			}
			if (this.comboBoxEdit71.SelectedIndex == 3)
			{
				this.method_98("242", "3");
			}
			if (this.comboBoxEdit71.SelectedIndex == 4)
			{
				this.method_98("242", "4");
			}
			if (this.comboBoxEdit71.SelectedIndex == 5)
			{
				this.method_98("242", "5");
			}
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00048388 File Offset: 0x00046588
		private void simpleButton986_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit72.SelectedIndex == 0)
			{
				this.method_98("244", "0");
			}
			if (this.comboBoxEdit72.SelectedIndex == 1)
			{
				this.method_98("244", "1");
			}
			if (this.comboBoxEdit72.SelectedIndex == 2)
			{
				this.method_98("244", "2");
			}
			if (this.comboBoxEdit72.SelectedIndex == 3)
			{
				this.method_98("244", "3");
			}
			if (this.comboBoxEdit72.SelectedIndex == 4)
			{
				this.method_98("244", "4");
			}
			if (this.comboBoxEdit72.SelectedIndex == 5)
			{
				this.method_98("244", "5");
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00048458 File Offset: 0x00046658
		private void simpleButton982_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit68.SelectedIndex == 0)
			{
				this.method_98("245", "184");
			}
			if (this.comboBoxEdit68.SelectedIndex == 1)
			{
				this.method_98("245", "176");
			}
			if (this.comboBoxEdit68.SelectedIndex == 2)
			{
				this.method_98("245", "186");
			}
			if (this.comboBoxEdit68.SelectedIndex == 3)
			{
				this.method_98("245", "185");
			}
			if (this.comboBoxEdit68.SelectedIndex == 4)
			{
				this.method_98("245", "173");
			}
			if (this.comboBoxEdit68.SelectedIndex == 5)
			{
				this.method_98("245", "165");
			}
			if (this.comboBoxEdit68.SelectedIndex == 6)
			{
				this.method_98("245", "155");
			}
			if (this.comboBoxEdit68.SelectedIndex == 7)
			{
				this.method_98("245", "190");
			}
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00048568 File Offset: 0x00046768
		private void simpleButton984_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit70.SelectedIndex == 0)
			{
				this.method_98("246", "160");
			}
			if (this.comboBoxEdit70.SelectedIndex == 1)
			{
				this.method_98("246", "167");
			}
			if (this.comboBoxEdit70.SelectedIndex == 2)
			{
				this.method_98("246", "164");
			}
			if (this.comboBoxEdit70.SelectedIndex == 3)
			{
				this.method_98("246", "163");
			}
			if (this.comboBoxEdit70.SelectedIndex == 4)
			{
				this.method_98("246", "166");
			}
			if (this.comboBoxEdit70.SelectedIndex == 5)
			{
				this.method_98("246", "151");
			}
			if (this.comboBoxEdit70.SelectedIndex == 6)
			{
				this.method_98("246", "156");
			}
			if (this.comboBoxEdit70.SelectedIndex == 7)
			{
				this.method_98("246", "190");
			}
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00048678 File Offset: 0x00046878
		private void simpleButton983_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit69.SelectedIndex == 0)
			{
				this.method_98("247", "154");
			}
			if (this.comboBoxEdit69.SelectedIndex == 1)
			{
				this.method_98("247", "162");
			}
			if (this.comboBoxEdit69.SelectedIndex == 2)
			{
				this.method_98("247", "157");
			}
			if (this.comboBoxEdit69.SelectedIndex == 3)
			{
				this.method_98("247", "158");
			}
			if (this.comboBoxEdit69.SelectedIndex == 4)
			{
				this.method_98("247", "161");
			}
			if (this.comboBoxEdit69.SelectedIndex == 5)
			{
				this.method_98("247", "152");
			}
			if (this.comboBoxEdit69.SelectedIndex == 6)
			{
				this.method_98("247", "153");
			}
			if (this.comboBoxEdit69.SelectedIndex == 7)
			{
				this.method_98("247", "150");
			}
			if (this.comboBoxEdit69.SelectedIndex == 8)
			{
				this.method_98("247", "190");
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000487A8 File Offset: 0x000469A8
		private void simpleButton981_Click(object sender, EventArgs e)
		{
			if (this.comboBoxEdit67.SelectedIndex == 0)
			{
				this.method_98("248", "90");
			}
			if (this.comboBoxEdit67.SelectedIndex == 1)
			{
				this.method_98("248", "100");
			}
			if (this.comboBoxEdit67.SelectedIndex == 2)
			{
				this.method_98("248", "91");
			}
			if (this.comboBoxEdit67.SelectedIndex == 3)
			{
				this.method_98("248", "101");
			}
			if (this.comboBoxEdit67.SelectedIndex == 4)
			{
				this.method_98("248", "102");
			}
			if (this.comboBoxEdit67.SelectedIndex == 5)
			{
				this.method_98("248", "103");
			}
			if (this.comboBoxEdit67.SelectedIndex == 6)
			{
				this.method_98("248", "55");
			}
			if (this.comboBoxEdit67.SelectedIndex == 7)
			{
				this.method_98("248", "50");
			}
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x000488B8 File Offset: 0x00046AB8
		private void simpleButton980_Click(object sender, EventArgs e)
		{
			try
			{
				this.simpleButton989_Click(sender, null);
				this.simpleButton987_Click(sender, null);
				this.simpleButton988_Click(sender, null);
				this.simpleButton985_Click(sender, null);
				this.simpleButton986_Click(sender, null);
				this.simpleButton982_Click(sender, null);
				this.simpleButton984_Click(sender, null);
				this.simpleButton983_Click(sender, null);
				this.simpleButton981_Click(sender, null);
				this.ixboxConsole_0.XNotify("All Class Info Set To Class 5!");
			}
			catch (Exception)
			{
				XtraMessageBox.Show("Failed to set all class info, this might indicate you dont have an option set for every function.");
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x000900B4 File Offset: 0x0008E2B4
		static Form1()
		{
			
			Form1.timer7 = new System.Timers.Timer(241.0);
			Form1.timer8 = new System.Timers.Timer(120.0);
			Form1.timer2 = new System.Timers.Timer(1000.0);
			Form1.DiscoTimer = new System.Timers.Timer(1000.0);
			Form1.DiscoTimerWAW = new System.Timers.Timer(1000.0);
			Form1.FlashTimer = new System.Timers.Timer(1000.0);
			Form1.timer4 = new System.Timers.Timer(1.0);
			Form1.timer5 = new System.Timers.Timer(25.0);
			Form1.timer3 = new System.Timers.Timer(250.0);
			Form1.flashgtmw2 = new System.Timers.Timer(550.0);
			Form1.timer15 = new System.Timers.Timer(550.0);
			Form1.playerState = 2197394816U;
			Form1.mw3rtegt = new System.Timers.Timer(1.0);
			Form1.flashgamertagmw3 = new System.Timers.Timer(250.0);
			Form1.rainbowgtmw3timer = new System.Timers.Timer(550.0);
			Form1.halocheckpointloop = new System.Timers.Timer(60000.0);
			Form1.awsurftimer = new System.Timers.Timer(2500.0);
			Form1.timer17 = new System.Timers.Timer(3000.0);
			Form1.timer16 = new System.Timers.Timer(5000.0);
			Form1.rtetimerbo2 = new System.Timers.Timer(1.0);
			Form1.rtetimerbo1 = new System.Timers.Timer(1.0);
			Form1.randomgtbo2timer = new System.Timers.Timer(25.0);
			Form1.randomgtbo1timer = new System.Timers.Timer(25.0);
			Form1.flashtimerbo2 = new System.Timers.Timer(250.0);
			Form1.flashtimerbo1 = new System.Timers.Timer(250.0);
			Form1.rainbowgtpregametimer = new System.Timers.Timer(550.0);
			Form1.rainbowgtpregametimerbo1 = new System.Timers.Timer(550.0);
			Form1.rainbowgtingametimer = new System.Timers.Timer(550.0);
			Form1.rainbowgtingametimerbo1 = new System.Timers.Timer(550.0);
			Form1.coloredgtbo2timer = new System.Timers.Timer(550.0);
			Form1.coloredgtbo1timer = new System.Timers.Timer(550.0);
			Form1.LockPreGameBo2 = new System.Timers.Timer(5000.0);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00007813 File Offset: 0x00005A13
		[CompilerGenerated]
		private bool method_99(string string_3)
		{
			return string_3 != this.listBox7.SelectedItem.ToString();
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0000782B File Offset: 0x00005A2B
		internal static bool smethod_0()
		{
			return Form1.form1_0 == null;
		}

		// Token: 0x04000124 RID: 292
		private IXboxConsole ixboxConsole_0;

		// Token: 0x04000125 RID: 293
		public bool TimerEnabled;

		// Token: 0x04000126 RID: 294
		private INI ini_0;

		// Token: 0x04000127 RID: 295
		private INI ini_1;

		// Token: 0x04000128 RID: 296
		private DiscordRpcClient discordRpcClient_0;

		// Token: 0x04000129 RID: 297
		private DiscordWebhookClient discordWebhookClient_0;

		// Token: 0x0400012A RID: 298
		private System.Windows.Forms.Timer timer_0;

		// Token: 0x0400012B RID: 299
		private string string_0;

		// Token: 0x0400012C RID: 300
		private string string_1;

		// Token: 0x0400012D RID: 301
		private System.Windows.Forms.Timer timer_1;

		// Token: 0x0400012E RID: 302
		public static System.Timers.Timer timer7;

		// Token: 0x0400012F RID: 303
		public static System.Timers.Timer timer8;

		// Token: 0x04000130 RID: 304
		private List<string> list_0;

		// Token: 0x04000131 RID: 305
		private INI ini_2;

		// Token: 0x04000132 RID: 306
		public static System.Timers.Timer timer2;

		// Token: 0x04000133 RID: 307
		public static System.Timers.Timer DiscoTimer;

		// Token: 0x04000134 RID: 308
		public static System.Timers.Timer DiscoTimerWAW;

		// Token: 0x04000135 RID: 309
		public static System.Timers.Timer FlashTimer;

		// Token: 0x04000136 RID: 310
		public static System.Timers.Timer timer4;

		// Token: 0x04000137 RID: 311
		public static System.Timers.Timer timer5;

		// Token: 0x04000138 RID: 312
		public static System.Timers.Timer timer3;

		// Token: 0x04000139 RID: 313
		public static System.Timers.Timer flashgtmw2;

		// Token: 0x0400013A RID: 314
		public static System.Timers.Timer timer15;

		// Token: 0x0400013B RID: 315
		public static uint playerState;

		// Token: 0x0400013C RID: 316
		public static System.Timers.Timer mw3rtegt;

		// Token: 0x0400013D RID: 317
		public static System.Timers.Timer flashgamertagmw3;

		// Token: 0x0400013E RID: 318
		public static System.Timers.Timer rainbowgtmw3timer;

		// Token: 0x0400013F RID: 319
		public static System.Timers.Timer halocheckpointloop;

		// Token: 0x04000140 RID: 320
		public static System.Timers.Timer awsurftimer;

		// Token: 0x04000141 RID: 321
		private string[] string_2;

		// Token: 0x04000142 RID: 322
		private bool bool_0;

		// Token: 0x04000143 RID: 323
		public static System.Timers.Timer timer17;

		// Token: 0x04000144 RID: 324
		public static System.Timers.Timer timer16;

		// Token: 0x04000145 RID: 325
		public static System.Timers.Timer rtetimerbo2;

		// Token: 0x04000146 RID: 326
		public static System.Timers.Timer rtetimerbo1;

		// Token: 0x04000147 RID: 327
		public static System.Timers.Timer randomgtbo2timer;

		// Token: 0x04000148 RID: 328
		public static System.Timers.Timer randomgtbo1timer;

		// Token: 0x04000149 RID: 329
		public static System.Timers.Timer flashtimerbo2;

		// Token: 0x0400014A RID: 330
		public static System.Timers.Timer flashtimerbo1;

		// Token: 0x0400014B RID: 331
		public static System.Timers.Timer rainbowgtpregametimer;

		// Token: 0x0400014C RID: 332
		public static System.Timers.Timer rainbowgtpregametimerbo1;

		// Token: 0x0400014D RID: 333
		public static System.Timers.Timer rainbowgtingametimer;

		// Token: 0x0400014E RID: 334
		public static System.Timers.Timer rainbowgtingametimerbo1;

		// Token: 0x0400014F RID: 335
		public static System.Timers.Timer coloredgtbo2timer;

		// Token: 0x04000150 RID: 336
		public static System.Timers.Timer coloredgtbo1timer;

		// Token: 0x04000151 RID: 337
		public static System.Timers.Timer LockPreGameBo2;

		// Token: 0x04000152 RID: 338
		public uint PlayerLevel;

		// Token: 0x04000153 RID: 339
		public uint Souls;

		// Token: 0x04000154 RID: 340
		public uint Vigor;

		// Token: 0x04000155 RID: 341
		public uint Endurance;

		// Token: 0x04000156 RID: 342
		public uint Vitality;

		// Token: 0x04000157 RID: 343
		public uint Attunement;

		// Token: 0x04000158 RID: 344
		public uint Strength;

		// Token: 0x04000159 RID: 345
		public uint Dexterity;

		// Token: 0x0400015A RID: 346
		public uint Intelligence;

		// Token: 0x0400015B RID: 347
		public uint Adaptability;

		// Token: 0x0400015C RID: 348
		public uint Faith;

		// Token: 0x0400015D RID: 349
		public uint[] healthstuff;

		// Token: 0x0400015E RID: 350
		private System.Windows.Forms.Timer timer_2;

		// Token: 0x0400015F RID: 351
		private System.Windows.Forms.Timer timer_3;

		// Token: 0x04000877 RID: 2167
		private static Form1 form1_0;

		// Token: 0x0200000B RID: 11
		public class playerStateInfo
		{
			// Token: 0x0600054F RID: 1359 RVA: 0x00008E4C File Offset: 0x0000704C
			public playerStateInfo()
			{

			}

			// Token: 0x06000550 RID: 1360 RVA: 0x00090324 File Offset: 0x0008E524
			static playerStateInfo()
			{
				
				Form1.playerStateInfo.Location1 = 28U;
				Form1.playerStateInfo.Location2 = 32U;
				Form1.playerStateInfo.Location3 = 36U;
				Form1.playerStateInfo.getGamertags = 13332U;
				Form1.playerStateInfo.difference = 14720U;
			}

			// Token: 0x06000551 RID: 1361 RVA: 0x00007835 File Offset: 0x00005A35
			internal static bool smethod_0()
			{
				return Form1.playerStateInfo.playerStateInfo_0 == null;
			}

			// Token: 0x04000878 RID: 2168
			public static uint Location1;

			// Token: 0x04000879 RID: 2169
			public static uint Location2;

			// Token: 0x0400087A RID: 2170
			public static uint Location3;

			// Token: 0x0400087B RID: 2171
			public static uint getGamertags;

			// Token: 0x0400087C RID: 2172
			public static uint difference;

			// Token: 0x0400087D RID: 2173
			private static Form1.playerStateInfo playerStateInfo_0;
		}

		// Token: 0x0200000C RID: 12
		public class MW3Offsets
		{
			// Token: 0x06000552 RID: 1362 RVA: 0x00008E4C File Offset: 0x0000704C
			public MW3Offsets()
			{
			}

			// Token: 0x06000553 RID: 1363 RVA: 0x00090364 File Offset: 0x0008E564
			static MW3Offsets()
			{
				Form1.MW3Offsets.Prestige = 2198498668U;
				Form1.MW3Offsets.Entry = 2198258784U;
				Form1.MW3Offsets.Experience = 2198498140U;
				Form1.MW3Offsets.Score = 2198498676U;
				Form1.MW3Offsets.Kills = 2198498716U;
				Form1.MW3Offsets.Deaths = 2198498724U;
				Form1.MW3Offsets.Assists = 2198498732U;
				Form1.MW3Offsets.KillStreak = 2198498720U;
				Form1.MW3Offsets.KDRatio = 2198498764U;
				Form1.MW3Offsets.HeadShots = 2198498736U;
				Form1.MW3Offsets.Wins = 2198498768U;
				Form1.MW3Offsets.Losses = 2198498772U;
				Form1.MW3Offsets.Ties = 2198498776U;
				Form1.MW3Offsets.WinStreak = 2198498780U;
				Form1.MW3Offsets.Hits = 2198498792U;
				Form1.MW3Offsets.Misses = 2198498796U;
				Form1.MW3Offsets.Accuracy = 2198498804U;
				Form1.MW3Offsets.PrestigeTokens = 2198506443U;
				Form1.MW3Offsets.DoubleXP = 2198506529U;
				Form1.MW3Offsets.DoubleWeaponXP = 2198506537U;
				Form1.MW3Offsets.TimePlayeds = 2198498750U;
				Form1.MW3Offsets.TimePlayed = 2198498758U;
			}

			// Token: 0x06000554 RID: 1364 RVA: 0x0000783F File Offset: 0x00005A3F
			internal static bool smethod_0()
			{
				return Form1.MW3Offsets.mw3Offsets_0 == null;
			}

			// Token: 0x0400087E RID: 2174
			public static uint Prestige;

			// Token: 0x0400087F RID: 2175
			public static uint Entry;

			// Token: 0x04000880 RID: 2176
			public static uint Experience;

			// Token: 0x04000881 RID: 2177
			public static uint Score;

			// Token: 0x04000882 RID: 2178
			public static uint Kills;

			// Token: 0x04000883 RID: 2179
			public static uint Deaths;

			// Token: 0x04000884 RID: 2180
			public static uint Assists;

			// Token: 0x04000885 RID: 2181
			public static uint KillStreak;

			// Token: 0x04000886 RID: 2182
			public static uint KDRatio;

			// Token: 0x04000887 RID: 2183
			public static uint HeadShots;

			// Token: 0x04000888 RID: 2184
			public static uint Wins;

			// Token: 0x04000889 RID: 2185
			public static uint Losses;

			// Token: 0x0400088A RID: 2186
			public static uint Ties;

			// Token: 0x0400088B RID: 2187
			public static uint WinStreak;

			// Token: 0x0400088C RID: 2188
			public static uint Hits;

			// Token: 0x0400088D RID: 2189
			public static uint Misses;

			// Token: 0x0400088E RID: 2190
			public static uint Accuracy;

			// Token: 0x0400088F RID: 2191
			public static uint PrestigeTokens;

			// Token: 0x04000890 RID: 2192
			public static uint DoubleXP;

			// Token: 0x04000891 RID: 2193
			public static uint DoubleWeaponXP;

			// Token: 0x04000892 RID: 2194
			public static uint TimePlayeds;

			// Token: 0x04000893 RID: 2195
			public static uint TimePlayed;

			// Token: 0x04000894 RID: 2196
			internal static Form1.MW3Offsets mw3Offsets_0;
		}
	}
}
