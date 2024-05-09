using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

public class MstSerializationBinder : SerializationBinder
{
    public override Type BindToType(string assemblyName, string typeName) =>
        typeName switch
        {
            "Shock.AchievementMst" => typeof(AchievementMst),
            "Shock.AdjustTrackingListMst" => typeof(AdjustTrackingListMst),
            "Shock.AlbumCardMMst" => typeof(AlbumCardMMst),
            "Shock.AlbumMemberTagMMst" => typeof(AlbumMemberTagMMst),
            "Shock.AlbumMultiUnitMMst" => typeof(AlbumMultiUnitMMst),
            "Shock.AlbumSeriesMMst" => typeof(AlbumSeriesMMst),
            "Shock.AlbumSeriesThumbnailAssetMMst" => typeof(AlbumSeriesThumbnailAssetMMst),
            "Shock.AlbumUnitMMst" => typeof(AlbumUnitMMst),
            "Shock.AlbumUnitPairMMst" => typeof(AlbumUnitPairMMst),
            "Shock.AlbumUnitSeriesMMst" => typeof(AlbumUnitSeriesMMst),
            "Shock.AlbumUnitTypeMemberTagMMst" => typeof(AlbumUnitTypeMemberTagMMst),
            "Shock.AlbumUnitTypeMst" => typeof(AlbumUnitTypeMst),
            "Shock.BeginnerMissionMst" => typeof(BeginnerMissionMst),
            "Shock.BeginnerMissionRewardMst" => typeof(BeginnerMissionRewardMst),
            "Shock.BeginnerMissionRewardSettingMst" => typeof(BeginnerMissionRewardSettingMst),
            "Shock.BgmMst" => typeof(BgmMst),
            "Shock.BillingProductMst" => typeof(BillingProductMst),
            "Shock.BillingProductRewardMst" => typeof(BillingProductRewardMst),
            "Shock.BillingShopMst" => typeof(BillingShopMst),
            "Shock.BillingSubscriptionMst" => typeof(BillingSubscriptionMst),
            "Shock.BillingSubscriptionRewardMst" => typeof(BillingSubscriptionRewardMst),
            "Shock.CardCollectionRewardMst" => typeof(CardCollectionRewardMst),
            "Shock.CardEvolveConditionMst" => typeof(CardEvolveConditionMst),
            "Shock.CardEvolveMst" => typeof(CardEvolveMst),
            "Shock.CardGetMst" => typeof(CardGetMst),
            "Shock.CardLevelMst" => typeof(CardLevelMst),
            "Shock.CardMst" => typeof(CardMst),
            "Shock.CardRarityMst" => typeof(CardRarityMst),
            "Shock.CardSkillLevelMst" => typeof(CardSkillLevelMst),
            "Shock.CardSysVoiceMst" => typeof(CardSysVoiceMst),
            "Shock.CharacterGroupMst" => typeof(CharacterGroupMst),
            "Shock.CharacterMst" => typeof(CharacterMst),
            "Shock.CharacterSysVoiceMst" => typeof(CharacterSysVoiceMst),
            "Shock.ChatAttachmentMst" => typeof(ChatAttachmentMst),
            "Shock.ChatChapterMst" => typeof(ChatChapterMst),
            "Shock.ChatCharacterMst" => typeof(ChatCharacterMst),
            "Shock.ChatMst" => typeof(ChatMst),
            "Shock.ChatRewardMst" => typeof(ChatRewardMst),
            "Shock.ChatRoomMst" => typeof(ChatRoomMst),
            "Shock.ChatStampMst" => typeof(ChatStampMst),
            "Shock.ChatVoiceKeyMst" => typeof(ChatVoiceKeyMst),
            "Shock.ChipsterResultCodeMst" => typeof(ChipsterResultCodeMst),
            "Shock.ComicMst" => typeof(ComicMst),
            "Shock.CommonBgMovieMst" => typeof(CommonBgMovieMst),
            "Shock.ConstMst" => typeof(ConstMst),
            "Shock.DateConditionMst" => typeof(DateConditionMst),
            "Shock.DateConditionOthersMst" => typeof(DateConditionOthersMst),
            "Shock.DialogButtonMst" => typeof(DialogButtonMst),
            "Shock.DialogMst" => typeof(DialogMst),
            "Shock.EventCardBonusMst" => typeof(EventCardBonusMst),
            "Shock.EventLiveMst" => typeof(EventLiveMst),
            "Shock.EventMemberRankingMst" => typeof(EventMemberRankingMst),
            "Shock.EventMemberRankingRewardMst" => typeof(EventMemberRankingRewardMst),
            "Shock.EventMst" => typeof(EventMst),
            "Shock.EventPointMst" => typeof(EventPointMst),
            "Shock.EventPointRankingMst" => typeof(EventPointRankingMst),
            "Shock.EventPointRankingRewardMst" => typeof(EventPointRankingRewardMst),
            "Shock.EventPointRewardMst" => typeof(EventPointRewardMst),
            "Shock.EventPointSettingsMst" => typeof(EventPointSettingsMst),
            "Shock.EventScoreMst" => typeof(EventScoreMst),
            "Shock.EventScoreRankingMst" => typeof(EventScoreRankingMst),
            "Shock.EventScoreRankingRewardMst" => typeof(EventScoreRankingRewardMst),
            "Shock.EventStoryMst" => typeof(EventStoryMst),
            "Shock.EventTipsMst" => typeof(EventTipsMst),
            "Shock.EventTipsPageMst" => typeof(EventTipsPageMst),
            "Shock.EventTopBannerMst" => typeof(EventTopBannerMst),
            "Shock.EventTypeMst" => typeof(EventTypeMst),
            "Shock.EvolveItemAmountMst" => typeof(EvolveItemAmountMst),
            "Shock.EvolveItemConditionMst" => typeof(EvolveItemConditionMst),
            "Shock.ExchangeItemMst" => typeof(ExchangeItemMst),
            "Shock.ExchangeItemRewardMst" => typeof(ExchangeItemRewardMst),
            "Shock.ExchangeMst" => typeof(ExchangeMst),
            "Shock.FunctionLockMst" => typeof(FunctionLockMst),
            "Shock.GamelibResultCodeMst" => typeof(GamelibResultCodeMst),
            "Shock.GroupMst" => typeof(GroupMst),
            "Shock.HomeBannerMst" => typeof(HomeBannerMst),
            "Shock.HomeBgMst" => typeof(HomeBgMst),
            "Shock.ItemMst" => typeof(ItemMst),
            "Shock.LimitedLiveMst" => typeof(LimitedLiveMst),
            "Shock.LiveBoostMst" => typeof(LiveBoostMst),
            "Shock.LiveClearRewardMst" => typeof(LiveClearRewardMst),
            "Shock.LiveComboMst" => typeof(LiveComboMst),
            "Shock.LiveConditionMst" => typeof(LiveConditionMst),
            "Shock.LiveEffectValueMst" => typeof(LiveEffectValueMst),
            "Shock.LiveInputResultMst" => typeof(LiveInputResultMst),
            "Shock.LiveLaneSkinMst" => typeof(LiveLaneSkinMst),
            "Shock.LiveMissionComboMst" => typeof(LiveMissionComboMst),
            "Shock.LiveMissionMst" => typeof(LiveMissionMst),
            "Shock.LiveMissionRewardMst" => typeof(LiveMissionRewardMst),
            "Shock.LiveMst" => typeof(LiveMst),
            "Shock.LiveRankingRewardMst" => typeof(LiveRankingRewardMst),
            "Shock.LiveRecommendListMst" => typeof(LiveRecommendListMst),
            "Shock.LiveRecommendMst" => typeof(LiveRecommendMst),
            "Shock.LiveRewardMst" => typeof(LiveRewardMst),
            "Shock.LiveRewardSettingMst" => typeof(LiveRewardSettingMst),
            "Shock.LiveRuleMst" => typeof(LiveRuleMst),
            "Shock.LiveTapEffectMst" => typeof(LiveTapEffectMst),
            "Shock.LiveTapSeMst" => typeof(LiveTapSeMst),
            "Shock.LocationMst" => typeof(LocationMst),
            "Shock.LocationRewardMst" => typeof(LocationRewardMst),
            "Shock.LoginBonusMst" => typeof(LoginBonusMst),
            "Shock.LoginBonusRewardMst" => typeof(LoginBonusRewardMst),
            "Shock.LoginBonusRewardSettingMst" => typeof(LoginBonusRewardSettingMst),
            "Shock.LotteryCautionMst" => typeof(LotteryCautionMst),
            "Shock.LotteryEffMovieMst" => typeof(LotteryEffMovieMst),
            "Shock.LotteryEffMovieRatioMst" => typeof(LotteryEffMovieRatioMst),
            "Shock.LotteryImageMst" => typeof(LotteryImageMst),
            "Shock.LotteryInfoMst" => typeof(LotteryInfoMst),
            "Shock.LotteryItemMst" => typeof(LotteryItemMst),
            "Shock.LotteryMst" => typeof(LotteryMst),
            "Shock.LotteryPriceMst" => typeof(LotteryPriceMst),
            "Shock.LotteryRarityMst" => typeof(LotteryRarityMst),
            "Shock.LotteryRewardMst" => typeof(LotteryRewardMst),
            "Shock.LotteryStepupMst" => typeof(LotteryStepupMst),
            "Shock.MembershipWallpaperMst" => typeof(MembershipWallpaperMst),
            "Shock.MissionBannerMst" => typeof(MissionBannerMst),
            "Shock.MissionMst" => typeof(MissionMst),
            "Shock.MissionRewardMst" => typeof(MissionRewardMst),
            "Shock.MovieKeyMst" => typeof(MovieKeyMst),
            "Shock.MovieMst" => typeof(MovieMst),
            "Shock.MultieventCardBonusMst" => typeof(MultieventCardBonusMst),
            "Shock.MultieventMatchingrangeMst" => typeof(MultieventMatchingrangeMst),
            "Shock.MultieventPenaltyMst" => typeof(MultieventPenaltyMst),
            "Shock.MultieventRankbonusMst" => typeof(MultieventRankbonusMst),
            "Shock.MultieventSettingMst" => typeof(MultieventSettingMst),
            "Shock.MusicLevelMst" => typeof(MusicLevelMst),
            "Shock.MusicMst" => typeof(MusicMst),
            "Shock.MusicShopPriceMst" => typeof(MusicShopPriceMst),
            "Shock.NavigationConditionMst" => typeof(NavigationConditionMst),
            "Shock.NavigationDialogPageMst" => typeof(NavigationDialogPageMst),
            "Shock.NavigationMst" => typeof(NavigationMst),
            "Shock.NewSkillMst" => typeof(NewSkillMst),
            "Shock.NoticeBirthdayMst" => typeof(NoticeBirthdayMst),
            "Shock.NoticeCardImageMst" => typeof(NoticeCardImageMst),
            "Shock.NoticeCardMst" => typeof(NoticeCardMst),
            "Shock.NoticeGachaMst" => typeof(NoticeGachaMst),
            "Shock.NoticeGeneralMst" => typeof(NoticeGeneralMst),
            "Shock.NoticeGeneralNavigationMst" => typeof(NoticeGeneralNavigationMst),
            "Shock.NoticeGeneralSequenceMst" => typeof(NoticeGeneralSequenceMst),
            "Shock.NoticeMusicImageMst" => typeof(NoticeMusicImageMst),
            "Shock.NoticeMusicMst" => typeof(NoticeMusicMst),
            "Shock.PartVoiceKeyMst" => typeof(PartVoiceKeyMst),
            "Shock.PresetBackgroundMst" => typeof(PresetBackgroundMst),
            "Shock.PresetForegroundMst" => typeof(PresetForegroundMst),
            "Shock.ReleaseLabelMst" => typeof(ReleaseLabelMst),
            "Shock.ResourceDownloadMst" => typeof(ResourceDownloadMst),
            "Shock.ResultCodeMst" => typeof(ResultCodeMst),
            "Shock.RhythmIconMst" => typeof(RhythmIconMst),
            "Shock.SceneTitleMst" => typeof(SceneTitleMst),
            "Shock.SeMst" => typeof(SeMst),
            "Shock.ShopItemMst" => typeof(ShopItemMst),
            "Shock.ShopRewardMst" => typeof(ShopRewardMst),
            "Shock.SkillCenterEffectMst" => typeof(SkillCenterEffectMst),
            "Shock.SkillCenterMst" => typeof(SkillCenterMst),
            "Shock.SoundKeyMst" => typeof(SoundKeyMst),
            "Shock.StampMst" => typeof(StampMst),
            "Shock.StarEventCardBonusMst" => typeof(StarEventCardBonusMst),
            "Shock.StarEventLevelRewardMst" => typeof(StarEventLevelRewardMst),
            "Shock.StarEventLevelRewardSettingMst" => typeof(StarEventLevelRewardSettingMst),
            "Shock.StarEventSettingMst" => typeof(StarEventSettingMst),
            "Shock.StoryMst" => typeof(StoryMst),
            "Shock.StoryPartMst" => typeof(StoryPartMst),
            "Shock.StoryReleaseMst" => typeof(StoryReleaseMst),
            "Shock.StoryRewardMst" => typeof(StoryRewardMst),
            "Shock.SubscriptionImageMst" => typeof(SubscriptionImageMst),
            "Shock.SysVoiceKeyMst" => typeof(SysVoiceKeyMst),
            "Shock.TextMst" => typeof(TextMst),
            "Shock.TitleMst" => typeof(TitleMst),
            "Shock.TitleScreenMst" => typeof(TitleScreenMst),
            "Shock.UrlMst" => typeof(UrlMst),
            "Shock.UserRankMst" => typeof(UserRankMst),
            "Shock.UserRankRewardMst" => typeof(UserRankRewardMst),
            "Shock.VoiceKeyMst" => typeof(VoiceKeyMst),
            "Shock.VoiceMst" => typeof(VoiceMst),
            "Shock.WipeMst" => typeof(WipeMst),
            "Shock.WipePlayListMst" => typeof(WipePlayListMst),
            "Shock.BAND_CATEGORY" => typeof(BandCategory),
            "Shock.BILLING_PRODUCT_TYPE" => typeof(BillingProductType),
            "Shock.CARD_TYPE" => typeof(CardType),
            "Shock.CONSUME_TYPE" => typeof(ConsumeType),
            "Shock.DATE_CONDITION_TYPE" => typeof(DateConditionType),
            "Shock.EVENT_TYPE" => typeof(EventType),
            "Shock.EVOLVE_ITEM_CONDITION_TYPE" => typeof(EvolveItemConditionType),
            "Shock.EXCHANGE_TAB" => typeof(ExchangeTab),
            "Shock.EXCHANGE_TYPE" => typeof(ExchangeType),
            "Shock.GET_CATEGORY" => typeof(GetCategory),
            "Shock.GIVE_TYPE" => typeof(GiveType),
            "Shock.HOME_BANNER_TYPE" => typeof(HomeBannerType),
            "Shock.HOME_BG_TYPE" => typeof(HomeBgType),
            "Shock.INPUT_RESULT_TYPE" => typeof(InputResultType),
            "Shock.ITEM_CATEGORY" => typeof(ItemCategory),
            "Shock.ITEM_EFFECT_TYPE" => typeof(ItemEffectType),
            "Shock.ITEM_EXPIRE_TYPE" => typeof(ItemExpireType),
            "Shock.ITEM_TAB" => typeof(ItemTab),
            "Shock.LIVE_CONDITION_TYPE" => typeof(LiveConditionType),
            "Shock.LIVE_LEVEL" => typeof(LiveLevel),
            "Shock.LIVE_MISSION_TYPE" => typeof(LiveMissionType),
            "Shock.LIVE_MODE" => typeof(LiveMode),
            "Shock.LIVE_RULE_TYPE" => typeof(LiveRuleType),
            "Shock.LOGIN_BONUS_TYPE" => typeof(LoginBonusType),
            "Shock.LOGIN_NOTICE_PHASE" => typeof(LoginNoticePhase),
            "Shock.LOGIN_NOTICE_TRANSITION" => typeof(LoginNoticeTransition),
            "Shock.LOGIN_NOTICE_TYPE" => typeof(LoginNoticeType),
            "Shock.LOTTERY_TYPE" => typeof(LotteryType),
            "Shock.MEMBER_RANKING_TYPE" => typeof(MemberRankingType),
            "Shock.MEMBERSHIP_WALLPAPER_CONDITION_TYPE" => typeof(MembershipWallpaperConditionType),
            "Shock.MISSION_CONDITION_TYPE" => typeof(MissionConditionType),
            "Shock.MISSION_TYPE" => typeof(MissionType),
            "Shock.MOVIE_LENGTH_TYPE" => typeof(MovieLengthType),
            "Shock.MOVIE_SCREEN_TYPE" => typeof(MovieScreenType),
            "Shock.NAVIGATION_CONDITION_TYPE" => typeof(NavigationConditionType),
            "Shock.OBTAIN_TYPE" => typeof(ObtainType),
            "Shock.PRESET_BACKGROUND_TYPE" => typeof(PresetBackgroundType),
            "Shock.PRESET_FOREGROUND_TYPE" => typeof(PresetForegroundType),
            "Shock.RARITY" => typeof(Rarity),
            "Shock.RESULT_CODE" => typeof(ResultCode),
            "Shock.REWARD_TYPE" => typeof(RewardType),
            "Shock.SCORE_RANK" => typeof(ScoreRank),
            "Shock.SKILL_CARD_TYPE" => typeof(SkillCardType),
            "Shock.SKILL_MAIN_EFFECT_TYPE" => typeof(SkillMainEffectType),
            "Shock.SKILL_MAIN_TRIGGER_TYPE" => typeof(SkillMainTriggerType),
            "Shock.SKILL_SUB_TARGET_TYPE" => typeof(SkillSubTargetType),
            "Shock.SOUND_TYPE" => typeof(SoundType),
            "Shock.STATUS_UP_TYPE" => typeof(StatusUpType),
            "Shock.STORY_TYPE" => typeof(StoryType),
            "Shock.SUBSCRIPTION_REWARD_TYPE" => typeof(SubscriptionRewardType),
            "Shock.SUBSCRIPTION_TYPE" => typeof(SubscriptionType),
            "Shock.SYSTEM_VOICE_TYPE" => typeof(SystemVoiceType),
            "Shock.TIME_RESET_TYPE" => typeof(TimeResetType),
            "Shock.TITLE_CATEGORY" => typeof(TitleCategory),
            "Shock.TRACKING_TYPE" => typeof(TrackingType),
            // Note: Next classes/enums are not present in game
            "Shock.MultiDailyDropEffectMst" => typeof(MultiDailyDropEffectMst),
            "Shock.DAY_OF_WEEK" => typeof(DayOfWeek),
            "Shock.MultiPenaltyMst" => typeof(MultiPenaltyMst),
            "Shock.MultiRoomConditionMst" => typeof(MultiRoomConditionMst),
            "Shock.MULTI_CONDITION_TYPE" => typeof(MultiConditionType),
            "Shock.MultiRoomSelectMst" => typeof(MultiRoomSelectMst),
            "Shock.StarEventLevelMst" => typeof(StarEventLevelMst),
            _ => throw new NotImplementedException()
        };

    public override void BindToName(Type serializedType, out string? assemblyName, out string? typeName)
    {
        if (serializedType.FullName!.StartsWith("System."))
        {
            assemblyName = "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
            typeName = serializedType.FullName;
            return;
        }

        assemblyName = "master_serializer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null";

        typeName = serializedType.Name switch
        {
            nameof(AchievementMst) => "Shock.AchievementMst",
            nameof(AdjustTrackingListMst) => "Shock.AdjustTrackingListMst",
            nameof(AlbumCardMMst) => "Shock.AlbumCardMMst",
            nameof(AlbumMemberTagMMst) => "Shock.AlbumMemberTagMMst",
            nameof(AlbumMultiUnitMMst) => "Shock.AlbumMultiUnitMMst",
            nameof(AlbumSeriesMMst) => "Shock.AlbumSeriesMMst",
            nameof(AlbumSeriesThumbnailAssetMMst) => "Shock.AlbumSeriesThumbnailAssetMMst",
            nameof(AlbumUnitMMst) => "Shock.AlbumUnitMMst",
            nameof(AlbumUnitPairMMst) => "Shock.AlbumUnitPairMMst",
            nameof(AlbumUnitSeriesMMst) => "Shock.AlbumUnitSeriesMMst",
            nameof(AlbumUnitTypeMemberTagMMst) => "Shock.AlbumUnitTypeMemberTagMMst",
            nameof(AlbumUnitTypeMst) => "Shock.AlbumUnitTypeMst",
            nameof(BeginnerMissionMst) => "Shock.BeginnerMissionMst",
            nameof(BeginnerMissionRewardMst) => "Shock.BeginnerMissionRewardMst",
            nameof(BeginnerMissionRewardSettingMst) => "Shock.BeginnerMissionRewardSettingMst",
            nameof(BgmMst) => "Shock.BgmMst",
            nameof(BillingProductMst) => "Shock.BillingProductMst",
            nameof(BillingProductRewardMst) => "Shock.BillingProductRewardMst",
            nameof(BillingShopMst) => "Shock.BillingShopMst",
            nameof(BillingSubscriptionMst) => "Shock.BillingSubscriptionMst",
            nameof(BillingSubscriptionRewardMst) => "Shock.BillingSubscriptionRewardMst",
            nameof(CardCollectionRewardMst) => "Shock.CardCollectionRewardMst",
            nameof(CardEvolveConditionMst) => "Shock.CardEvolveConditionMst",
            nameof(CardEvolveMst) => "Shock.CardEvolveMst",
            nameof(CardGetMst) => "Shock.CardGetMst",
            nameof(CardLevelMst) => "Shock.CardLevelMst",
            nameof(CardMst) => "Shock.CardMst",
            nameof(CardRarityMst) => "Shock.CardRarityMst",
            nameof(CardSkillLevelMst) => "Shock.CardSkillLevelMst",
            nameof(CardSysVoiceMst) => "Shock.CardSysVoiceMst",
            nameof(CharacterGroupMst) => "Shock.CharacterGroupMst",
            nameof(CharacterMst) => "Shock.CharacterMst",
            nameof(CharacterSysVoiceMst) => "Shock.CharacterSysVoiceMst",
            nameof(ChatAttachmentMst) => "Shock.ChatAttachmentMst",
            nameof(ChatChapterMst) => "Shock.ChatChapterMst",
            nameof(ChatCharacterMst) => "Shock.ChatCharacterMst",
            nameof(ChatMst) => "Shock.ChatMst",
            nameof(ChatRewardMst) => "Shock.ChatRewardMst",
            nameof(ChatRoomMst) => "Shock.ChatRoomMst",
            nameof(ChatStampMst) => "Shock.ChatStampMst",
            nameof(ChatVoiceKeyMst) => "Shock.ChatVoiceKeyMst",
            nameof(ChipsterResultCodeMst) => "Shock.ChipsterResultCodeMst",
            nameof(ComicMst) => "Shock.ComicMst",
            nameof(CommonBgMovieMst) => "Shock.CommonBgMovieMst",
            nameof(ConstMst) => "Shock.ConstMst",
            nameof(DateConditionMst) => "Shock.DateConditionMst",
            nameof(DateConditionOthersMst) => "Shock.DateConditionOthersMst",
            nameof(DialogButtonMst) => "Shock.DialogButtonMst",
            nameof(DialogMst) => "Shock.DialogMst",
            nameof(EventCardBonusMst) => "Shock.EventCardBonusMst",
            nameof(EventLiveMst) => "Shock.EventLiveMst",
            nameof(EventMemberRankingMst) => "Shock.EventMemberRankingMst",
            nameof(EventMemberRankingRewardMst) => "Shock.EventMemberRankingRewardMst",
            nameof(EventMst) => "Shock.EventMst",
            nameof(EventPointMst) => "Shock.EventPointMst",
            nameof(EventPointRankingMst) => "Shock.EventPointRankingMst",
            nameof(EventPointRankingRewardMst) => "Shock.EventPointRankingRewardMst",
            nameof(EventPointRewardMst) => "Shock.EventPointRewardMst",
            nameof(EventPointSettingsMst) => "Shock.EventPointSettingsMst",
            nameof(EventScoreMst) => "Shock.EventScoreMst",
            nameof(EventScoreRankingMst) => "Shock.EventScoreRankingMst",
            nameof(EventScoreRankingRewardMst) => "Shock.EventScoreRankingRewardMst",
            nameof(EventStoryMst) => "Shock.EventStoryMst",
            nameof(EventTipsMst) => "Shock.EventTipsMst",
            nameof(EventTipsPageMst) => "Shock.EventTipsPageMst",
            nameof(EventTopBannerMst) => "Shock.EventTopBannerMst",
            nameof(EventTypeMst) => "Shock.EventTypeMst",
            nameof(EvolveItemAmountMst) => "Shock.EvolveItemAmountMst",
            nameof(EvolveItemConditionMst) => "Shock.EvolveItemConditionMst",
            nameof(ExchangeItemMst) => "Shock.ExchangeItemMst",
            nameof(ExchangeItemRewardMst) => "Shock.ExchangeItemRewardMst",
            nameof(ExchangeMst) => "Shock.ExchangeMst",
            nameof(FunctionLockMst) => "Shock.FunctionLockMst",
            nameof(GamelibResultCodeMst) => "Shock.GamelibResultCodeMst",
            nameof(GroupMst) => "Shock.GroupMst",
            nameof(HomeBannerMst) => "Shock.HomeBannerMst",
            nameof(HomeBgMst) => "Shock.HomeBgMst",
            nameof(ItemMst) => "Shock.ItemMst",
            nameof(LimitedLiveMst) => "Shock.LimitedLiveMst",
            nameof(LiveBoostMst) => "Shock.LiveBoostMst",
            nameof(LiveClearRewardMst) => "Shock.LiveClearRewardMst",
            nameof(LiveComboMst) => "Shock.LiveComboMst",
            nameof(LiveConditionMst) => "Shock.LiveConditionMst",
            nameof(LiveEffectValueMst) => "Shock.LiveEffectValueMst",
            nameof(LiveInputResultMst) => "Shock.LiveInputResultMst",
            nameof(LiveLaneSkinMst) => "Shock.LiveLaneSkinMst",
            nameof(LiveMissionComboMst) => "Shock.LiveMissionComboMst",
            nameof(LiveMissionMst) => "Shock.LiveMissionMst",
            nameof(LiveMissionRewardMst) => "Shock.LiveMissionRewardMst",
            nameof(LiveMst) => "Shock.LiveMst",
            nameof(LiveRankingRewardMst) => "Shock.LiveRankingRewardMst",
            nameof(LiveRecommendListMst) => "Shock.LiveRecommendListMst",
            nameof(LiveRecommendMst) => "Shock.LiveRecommendMst",
            nameof(LiveRewardMst) => "Shock.LiveRewardMst",
            nameof(LiveRewardSettingMst) => "Shock.LiveRewardSettingMst",
            nameof(LiveRuleMst) => "Shock.LiveRuleMst",
            nameof(LiveTapEffectMst) => "Shock.LiveTapEffectMst",
            nameof(LiveTapSeMst) => "Shock.LiveTapSeMst",
            nameof(LocationMst) => "Shock.LocationMst",
            nameof(LocationRewardMst) => "Shock.LocationRewardMst",
            nameof(LoginBonusMst) => "Shock.LoginBonusMst",
            nameof(LoginBonusRewardMst) => "Shock.LoginBonusRewardMst",
            nameof(LoginBonusRewardSettingMst) => "Shock.LoginBonusRewardSettingMst",
            nameof(LotteryCautionMst) => "Shock.LotteryCautionMst",
            nameof(LotteryEffMovieMst) => "Shock.LotteryEffMovieMst",
            nameof(LotteryEffMovieRatioMst) => "Shock.LotteryEffMovieRatioMst",
            nameof(LotteryImageMst) => "Shock.LotteryImageMst",
            nameof(LotteryInfoMst) => "Shock.LotteryInfoMst",
            nameof(LotteryItemMst) => "Shock.LotteryItemMst",
            nameof(LotteryMst) => "Shock.LotteryMst",
            nameof(LotteryPriceMst) => "Shock.LotteryPriceMst",
            nameof(LotteryRarityMst) => "Shock.LotteryRarityMst",
            nameof(LotteryRewardMst) => "Shock.LotteryRewardMst",
            nameof(LotteryStepupMst) => "Shock.LotteryStepupMst",
            nameof(MembershipWallpaperMst) => "Shock.MembershipWallpaperMst",
            nameof(MissionBannerMst) => "Shock.MissionBannerMst",
            nameof(MissionMst) => "Shock.MissionMst",
            nameof(MissionRewardMst) => "Shock.MissionRewardMst",
            nameof(MovieKeyMst) => "Shock.MovieKeyMst",
            nameof(MovieMst) => "Shock.MovieMst",
            nameof(MultieventCardBonusMst) => "Shock.MultieventCardBonusMst",
            nameof(MultieventMatchingrangeMst) => "Shock.MultieventMatchingrangeMst",
            nameof(MultieventPenaltyMst) => "Shock.MultieventPenaltyMst",
            nameof(MultieventRankbonusMst) => "Shock.MultieventRankbonusMst",
            nameof(MultieventSettingMst) => "Shock.MultieventSettingMst",
            nameof(MusicLevelMst) => "Shock.MusicLevelMst",
            nameof(MusicMst) => "Shock.MusicMst",
            nameof(MusicShopPriceMst) => "Shock.MusicShopPriceMst",
            nameof(NavigationConditionMst) => "Shock.NavigationConditionMst",
            nameof(NavigationDialogPageMst) => "Shock.NavigationDialogPageMst",
            nameof(NavigationMst) => "Shock.NavigationMst",
            nameof(NewSkillMst) => "Shock.NewSkillMst",
            nameof(NoticeBirthdayMst) => "Shock.NoticeBirthdayMst",
            nameof(NoticeCardImageMst) => "Shock.NoticeCardImageMst",
            nameof(NoticeCardMst) => "Shock.NoticeCardMst",
            nameof(NoticeGachaMst) => "Shock.NoticeGachaMst",
            nameof(NoticeGeneralMst) => "Shock.NoticeGeneralMst",
            nameof(NoticeGeneralNavigationMst) => "Shock.NoticeGeneralNavigationMst",
            nameof(NoticeGeneralSequenceMst) => "Shock.NoticeGeneralSequenceMst",
            nameof(NoticeMusicImageMst) => "Shock.NoticeMusicImageMst",
            nameof(NoticeMusicMst) => "Shock.NoticeMusicMst",
            nameof(PartVoiceKeyMst) => "Shock.PartVoiceKeyMst",
            nameof(PresetBackgroundMst) => "Shock.PresetBackgroundMst",
            nameof(PresetForegroundMst) => "Shock.PresetForegroundMst",
            nameof(ReleaseLabelMst) => "Shock.ReleaseLabelMst",
            nameof(ResourceDownloadMst) => "Shock.ResourceDownloadMst",
            nameof(ResultCodeMst) => "Shock.ResultCodeMst",
            nameof(RhythmIconMst) => "Shock.RhythmIconMst",
            nameof(SceneTitleMst) => "Shock.SceneTitleMst",
            nameof(SeMst) => "Shock.SeMst",
            nameof(ShopItemMst) => "Shock.ShopItemMst",
            nameof(ShopRewardMst) => "Shock.ShopRewardMst",
            nameof(SkillCenterEffectMst) => "Shock.SkillCenterEffectMst",
            nameof(SkillCenterMst) => "Shock.SkillCenterMst",
            nameof(SoundKeyMst) => "Shock.SoundKeyMst",
            nameof(StampMst) => "Shock.StampMst",
            nameof(StarEventCardBonusMst) => "Shock.StarEventCardBonusMst",
            nameof(StarEventLevelRewardMst) => "Shock.StarEventLevelRewardMst",
            nameof(StarEventLevelRewardSettingMst) => "Shock.StarEventLevelRewardSettingMst",
            nameof(StarEventSettingMst) => "Shock.StarEventSettingMst",
            nameof(StoryMst) => "Shock.StoryMst",
            nameof(StoryPartMst) => "Shock.StoryPartMst",
            nameof(StoryReleaseMst) => "Shock.StoryReleaseMst",
            nameof(StoryRewardMst) => "Shock.StoryRewardMst",
            nameof(SubscriptionImageMst) => "Shock.SubscriptionImageMst",
            nameof(SysVoiceKeyMst) => "Shock.SysVoiceKeyMst",
            nameof(TextMst) => "Shock.TextMst",
            nameof(TitleMst) => "Shock.TitleMst",
            nameof(TitleScreenMst) => "Shock.TitleScreenMst",
            nameof(UrlMst) => "Shock.UrlMst",
            nameof(UserRankMst) => "Shock.UserRankMst",
            nameof(UserRankRewardMst) => "Shock.UserRankRewardMst",
            nameof(VoiceKeyMst) => "Shock.VoiceKeyMst",
            nameof(VoiceMst) => "Shock.VoiceMst",
            nameof(WipeMst) => "Shock.WipeMst",
            nameof(WipePlayListMst) => "Shock.WipePlayListMst",
            nameof(BandCategory) => "Shock.BAND_CATEGORY",
            nameof(BillingProductType) => "Shock.BILLING_PRODUCT_TYPE",
            nameof(CardType) => "Shock.CARD_TYPE",
            nameof(ConsumeType) => "Shock.CONSUME_TYPE",
            nameof(DateConditionType) => "Shock.DATE_CONDITION_TYPE",
            nameof(EventType) => "Shock.EVENT_TYPE",
            nameof(EvolveItemConditionType) => "Shock.EVOLVE_ITEM_CONDITION_TYPE",
            nameof(ExchangeTab) => "Shock.EXCHANGE_TAB",
            nameof(ExchangeType) => "Shock.EXCHANGE_TYPE",
            nameof(GetCategory) => "Shock.GET_CATEGORY",
            nameof(GiveType) => "Shock.GIVE_TYPE",
            nameof(HomeBannerType) => "Shock.HOME_BANNER_TYPE",
            nameof(HomeBgType) => "Shock.HOME_BG_TYPE",
            nameof(InputResultType) => "Shock.INPUT_RESULT_TYPE",
            nameof(ItemCategory) => "Shock.ITEM_CATEGORY",
            nameof(ItemEffectType) => "Shock.ITEM_EFFECT_TYPE",
            nameof(ItemExpireType) => "Shock.ITEM_EXPIRE_TYPE",
            nameof(ItemTab) => "Shock.ITEM_TAB",
            nameof(LiveConditionType) => "Shock.LIVE_CONDITION_TYPE",
            nameof(LiveLevel) => "Shock.LIVE_LEVEL",
            nameof(LiveMissionType) => "Shock.LIVE_MISSION_TYPE",
            nameof(LiveMode) => "Shock.LIVE_MODE",
            nameof(LiveRuleType) => "Shock.LIVE_RULE_TYPE",
            nameof(LoginBonusType) => "Shock.LOGIN_BONUS_TYPE",
            nameof(LoginNoticePhase) => "Shock.LOGIN_NOTICE_PHASE",
            nameof(LoginNoticeTransition) => "Shock.LOGIN_NOTICE_TRANSITION",
            nameof(LoginNoticeType) => "Shock.LOGIN_NOTICE_TYPE",
            nameof(LotteryType) => "Shock.LOTTERY_TYPE",
            nameof(MemberRankingType) => "Shock.MEMBER_RANKING_TYPE",
            nameof(MembershipWallpaperConditionType) => "Shock.MEMBERSHIP_WALLPAPER_CONDITION_TYPE",
            nameof(MissionConditionType) => "Shock.MISSION_CONDITION_TYPE",
            nameof(MissionType) => "Shock.MISSION_TYPE",
            nameof(MovieLengthType) => "Shock.MOVIE_LENGTH_TYPE",
            nameof(MovieScreenType) => "Shock.MOVIE_SCREEN_TYPE",
            nameof(NavigationConditionType) => "Shock.NAVIGATION_CONDITION_TYPE",
            nameof(ObtainType) => "Shock.OBTAIN_TYPE",
            nameof(PresetBackgroundType) => "Shock.PRESET_BACKGROUND_TYPE",
            nameof(PresetForegroundType) => "Shock.PRESET_FOREGROUND_TYPE",
            nameof(Rarity) => "Shock.RARITY",
            nameof(ResultCode) => "Shock.RESULT_CODE",
            nameof(RewardType) => "Shock.REWARD_TYPE",
            nameof(ScoreRank) => "Shock.SCORE_RANK",
            nameof(SkillCardType) => "Shock.SKILL_CARD_TYPE",
            nameof(SkillMainEffectType) => "Shock.SKILL_MAIN_EFFECT_TYPE",
            nameof(SkillMainTriggerType) => "Shock.SKILL_MAIN_TRIGGER_TYPE",
            nameof(SkillSubTargetType) => "Shock.SKILL_SUB_TARGET_TYPE",
            nameof(SoundType) => "Shock.SOUND_TYPE",
            nameof(StatusUpType) => "Shock.STATUS_UP_TYPE",
            nameof(StoryType) => "Shock.STORY_TYPE",
            nameof(SubscriptionRewardType) => "Shock.SUBSCRIPTION_REWARD_TYPE",
            nameof(SubscriptionType) => "Shock.SUBSCRIPTION_TYPE",
            nameof(SystemVoiceType) => "Shock.SYSTEM_VOICE_TYPE",
            nameof(TimeResetType) => "Shock.TIME_RESET_TYPE",
            nameof(TitleCategory) => "Shock.TITLE_CATEGORY",
            nameof(TrackingType) => "Shock.TRACKING_TYPE",
            // Note: Next classes/enums are not present in game
            nameof(MultiDailyDropEffectMst) => "Shock.MultiDailyDropEffectMst",
            nameof(DayOfWeek) => "Shock.DAY_OF_WEEK",
            nameof(MultiPenaltyMst) => "Shock.MultiPenaltyMst",
            nameof(MultiRoomConditionMst) => "Shock.MultiRoomConditionMst",
            nameof(MultiConditionType) => "Shock.MULTI_CONDITION_TYPE",
            nameof(MultiRoomSelectMst) => "Shock.MultiRoomSelectMst",
            nameof(StarEventLevelMst) => "Shock.StarEventLevelMst",
            _ => throw new NotImplementedException()
        };
    }
}
