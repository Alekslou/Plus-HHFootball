﻿namespace Plus.Communication.Packets.Outgoing
{
    public static class ServerPacketHeader
    {
        ////////////////////////////////////////////////////////
        //PRODUCTION-201602082203-712976078////
        //UPDATED BY Wesleyy @retronet////////
        ///////////////////////////////////////////////////////
        public const int UnknownGroupMessageComposer = 3440; //updated by: wesley66101
        public const int QuestionParserMessageComposer = 3851; //updated by: wesley66101
        public const int CatalogItemDiscountMessageComposer = 3737; //updated by: wesley66101
        public const int HelperToolMessageComposer = 1929; //updated by: wesley66101
        public const int RoomErrorNotifMessageComposer = 768; //updated by: wesley66101
        public const int FollowFriendFailedMessageComposer = 3617; //updated by: wesley66101
        public const int PurchaseOKMessageComposer = 2669; //updated by: wesley66101
        public const int GroupMembershipRequestedMessageComposer = 613; //updated by: wesley66101
        public const int ModeratorInitMessageComposer = 3879; //updated by: wesley66101
        public const int CatalogOfferMessageComposer = 620; //updated by: wesley66101
        public const int FindFriendsProcessResultMessageComposer = 521; //updated by: wesley66101
        public const int ThreadsListDataMessageComposer = 3955; //updated by: wesley66101
        public const int UserChangeMessageComposer = 2191; //updated by: wesley66101
        public const int FloorHeightMapMessageComposer = 3591; //updated by: wesley66101
        public const int RoomInfoUpdatedMessageComposer = 3484; //updated by: wesley66101
        public const int PresentDeliverErrorMessageComposer = 442; //updated by: wesley66101
        public const int AvatarEffectAddedMessageComposer = 2924; //updated by: wesley66101
        public const int MessengerErrorMessageComposer = 2880; //updated by: wesley66101
        public const int MarketplaceCanMakeOfferResultMessageComposer = 1408; //updated by: wesley66101
        public const int ScrSendUserInfoMessageComposer = 3112; //updated by: wesley66101
        public const int GameAccountStatusMessageComposer = 2244; //updated by: wesley66101
        public const int RoomSettingsDataMessageComposer = 2970; //updated by: wesley66101
        public const int GuestRoomSearchResultMessageComposer = 1334; //updated by: wesley66101
        public const int OpenGiftMessageComposer = 1699; //updated by: wesley66101
        public const int NewUserExperienceGiftOfferMessageComposer = 2146; //updated by: wesley66101
        public const int UpdateUsernameMessageComposer = 3741; //updated by: wesley66101
        public const int VoucherRedeemOkMessageComposer = 1160; //updated by: wesley66101
        public const int FigureSetIdsMessageComposer = 3153; //updated by: wesley66101
        public const int SlideObjectBundleMessageComposer = 139; //updated by: wesley66101
        public const int StickyNoteMessageComposer = 1080; //updated by: wesley66101
        public const int UserRemoveMessageComposer = 1554; //updated by: wesley66101
        public const int GetGuestRoomResultMessageComposer = 1099; //updated by: wesley66101
        public const int DoorbellMessageComposer = 1041; //updated by: wesley66101
        public const int YouAreNotControllerMessageComposer = 2486; //updated by: wesley66101
        public const int AvailabilityStatusMessageComposer = 855; //updated by: wesley66101
        public const int GiftWrappingConfigurationMessageComposer = 3160; //updated by: wesley66101
        public const int QuestStartedMessageComposer = 3170; //updated by: wesley66101
        public const int NavigatorLiftedRoomsMessageComposer = 2873; //updated by: wesley66101
        public const int NavigatorPreferencesMessageComposer = 483; //updated by: wesley66101
        public const int TradingFinishMessageComposer = 2757; //updated by: wesley66101
        public const int GetRelationshipsMessageComposer = 1479; //updated by: wesley66101
        public const int FriendNotificationMessageComposer = 90; //updated by: wesley66101
        public const int WhisperMessageComposer = 590; //updated by: wesley66101
        public const int BadgeEditorPartsMessageComposer = 624; //updated by: wesley66101
        public const int TraxSongInfoMessageComposer = 366; //updated by: wesley66101
        public const int GroupFurniConfigMessageComposer = 3406; //updated by: wesley66101
        public const int PostUpdatedMessageComposer = 1491; //updated by: wesley66101
        public const int UserUpdateMessageComposer = 448; //updated by: wesley66101
        public const int ModeratorUserRoomVisitsMessageComposer = 371; //updated by: wesley66101
        public const int MutedMessageComposer = 2650; //updated by: wesley66101
        public const int MarketplaceConfigurationMessageComposer = 3093; //updated by: wesley66101
        public const int ChatMessageComposer = 3510; //updated by: wesley66101
        public const int ShoutMessageComposer = 980; //updated by: wesley66101
        public const int TradingConfirmedMessageComposer = 3697; //updated by: wesley66101
        public const int ThreadCreatedMessageComposer = 1096; //updated by: wesley66101
        public const int CheckGnomeNameMessageComposer = 282; //updated by: wesley66101
        public const int GroupCreationWindowMessageComposer = 1670; //updated by: wesley66101
        public const int SetGroupIdMessageComposer = 1503; //updated by: wesley66101
        public const int OpenBotActionMessageComposer = 510; //updated by: wesley66101
        public const int ThreadDataMessageComposer = 2484; //updated by: wesley66101
        public const int YouAreOwnerMessageComposer = 2013; //updated by: wesley66101
        public const int RoomForwardMessageComposer = 2639; //updated by: wesley66101
        public const int FavouritesMessageComposer = 3481; //updated by: wesley66101
        public const int TalentLevelUpMessageComposer = 1478; //updated by: wesley66101
        public const int RoomSettingsSavedMessageComposer = 3078; //updated by: wesley66101
        public const int RoomReadyMessageComposer = 1309; //updated by: wesley66101
        public const int BCBorrowedItemsMessageComposer = 144; //updated by: wesley66101
        public const int UserTagsMessageComposer = 1847; //updated by: wesley66101
        public const int QuestAbortedMessageComposer = 642; //updated by: wesley66101
        public const int CampaignMessageComposer = 203; //updated by: wesley66101
        public const int CatalogPageMessageComposer = 3885; //updated by: wesley66101
        public const int RoomEventMessageComposer = 3459; //updated by: wesley66101
        public const int ObjectRemoveMessageComposer = 1836; //updated by: wesley66101
        public const int AchievementScoreMessageComposer = 2923; //updated by: wesley66101
        public const int UpdateFavouriteRoomMessageComposer = 3067; //updated by: wesley66101
        public const int ModeratorRoomChatlogMessageComposer = 2993; //updated by: wesley66101
        public const int MarketplaceItemStatsMessageComposer = 2183; //updated by: wesley66101
        public const int WiredConditionConfigMessageComposer = 3430; //updated by: wesley66101
        public const int SellablePetBreedsMessageComposer = 2044; //updated by: wesley66101
        public const int BuddyListMessageComposer = 3374; //updated by: wesley66101
        public const int HabboSearchResultMessageComposer = 1818; //updated by: wesley66101
        public const int ItemUpdateMessageComposer = 2384; //updated by: wesley66101
        public const int PetHorseFigureInformationMessageComposer = 3436; //updated by: wesley66101
        public const int PetInventoryMessageComposer = 2347; //updated by: wesley66101
        public const int MoodlightConfigMessageComposer = 1290; //updated by: wesley66101
        public const int PongMessageComposer = 2851; //updated by: wesley66101
        public const int GroupMembersMessageComposer = 1143; //updated by: wesley66101
        public const int RentableSpaceMessageComposer = 2926; //updated by: wesley66101
        public const int GetYouTubePlaylistMessageComposer = 1144; //updated by: wesley66101
        public const int RespectNotificationMessageComposer = 1110; //updated by: wesley66101
        public const int RecyclerRewardsMessageComposer = 1908; //updated by: wesley66101
        public const int SleepMessageComposer = 3962; //updated by: wesley66101
        public const int GetRoomBannedUsersMessageComposer = 1094; //updated by: wesley66101
        public const int ModeratorUserInfoMessageComposer = 878; //updated by: wesley66101
        public const int WiredTriggerConfigMessageComposer = 503; //updated by: wesley66101
        public const int RoomRatingMessageComposer = 1489; //updated by: wesley66101
        public const int ModeratorSupportTicketResponseMessageComposer = 2427; //updated by: wesley66101
        public const int PlayableGamesMessageComposer = 264; //updated by: wesley66101
        public const int TalentTrackLevelMessageComposer = 3466; //updated by: wesley66101
        public const int JoinQueueMessageComposer = 3074; //updated by: wesley66101
        public const int UserObjectMessageComposer = 3247; //updated by: wesley66101
        public const int MarketPlaceOwnOffersMessageComposer = 3228; //updated by: wesley66101
        public const int PetBreedingMessageComposer = 233; //updated by: wesley66101
        public const int SubmitBullyReportMessageComposer = 1142; //updated by: wesley66101
        public const int UserNameChangeMessageComposer = 1563; //updated by: wesley66101
        public const int WardrobeMessageComposer = 2924; //updated by: wesley66101
        public const int FlatAccessibleMessageComposer = 3651; //updated by: wesley66101
        public const int FurniListNotificationMessageComposer = 3667; //updated by: wesley66101
        public const int ModeratorUserChatlogMessageComposer = 166; //updated by: wesley66101
        public const int ThreadUpdatedMessageComposer = 3348; //updated by: wesley66101
        public const int LoveLockDialogueMessageComposer = 1064; //updated by: wesley66101
        public const int SendBullyReportMessageComposer = 1665; //updated by: wesley66101
        public const int VoucherRedeemErrorMessageComposer = 257; //updated by: wesley66101
        public const int CantConnectMessageComposer = 2357; //updated by: wesley66101
        public const int PurchaseErrorMessageComposer = 3003; //updated by: wesley66101
        public const int ThreadReplyMessageComposer = 3373; //updated by: wesley66101
        public const int UnknownCalendarMessageComposer = 460; //updated by: wesley66101
        public const int QuestListMessageComposer = 92; //updated by: wesley66101
        public const int AvatarEffectExpiredMessageComposer = 1812; //updated by: wesley66101
        public const int FriendListUpdateMessageComposer = 634; //updated by: wesley66101
        public const int NavigatorFlatCatsMessageComposer = 269; //updated by: wesley66101
        public const int UserFlatCatsMessageComposer = 2092; //updated by: wesley66101
        public const int HideWiredConfigMessageComposer = 2965; //updated by: wesley66101
        public const int UpdateFreezeLivesMessageComposer = 3537; //updated by: wesley66101
        public const int ActivityPointsMessageComposer = 1296; //updated by: wesley66101
        public const int UnbanUserFromRoomMessageComposer = 3214; //updated by: wesley66101
        public const int AvatarEffectMessageComposer = 3220; //updated by: wesley66101
        public const int PetTrainingPanelMessageComposer = 3451; //updated by: wesley66101
        public const int LoveLockDialogueCloseMessageComposer = 2525; //updated by: wesley66101
        public const int FurniListRemoveMessageComposer = 1810; //updated by: wesley66101
        public const int BuildersClubMembershipMessageComposer = 3095; //updated by: wesley66101
        public const int SecretKeyMessageComposer = 3963; //updated by: wesley66101
        public const int CloseConnectionMessageComposer = 1787; //updated by: wesley66101
        public const int HabboActivityPointNotificationMessageComposer = 1042; //updated by: wesley66101
        public const int NavigatorMetaDataParserMessageComposer = 1280; //updated by: wesley66101
        public const int NavigatorCollapsedCategoriesMessageComposer = 401; //updated by: wesley66101
        public const int UpdateFavouriteGroupMessageComposer = 2490; //updated by: wesley66101
        public const int FlatAccessDeniedMessageComposer = 2882; //updated by: wesley66101
        public const int LatencyResponseMessageComposer = 754; //updated by: wesley66101
        public const int BuddyRequestsMessageComposer = 2925; //updated by: wesley66101
        public const int HabboUserBadgesMessageComposer = 2620; //updated by: wesley66101
        public const int HeightMapMessageComposer = 2737; //updated by: wesley66101
        public const int ObjectUpdateMessageComposer = 699; //updated by: wesley66101
        public const int YouAreControllerMessageComposer = 2645; //updated by: wesley66101
        public const int CatalogIndexMessageComposer = 690; //updated by: wesley66101
        public const int FlatControllerRemovedMessageComposer = 2878; //updated by: wesley66101
        public const int NewBuddyRequestMessageComposer = 1870; //updated by: wesley66101
        public const int CanCreateRoomMessageComposer = 385; //updated by: wesley66101
        public const int ModeratorRoomInfoMessageComposer = 2677; //updated by: wesley66101
        public const int GroupMemberUpdatedMessageComposer = 438; //updated by: wesley66101
        public const int FloodControlMessageComposer = 731; //updated by: wesley66101
        public const int RoomRightsListMessageComposer = 57; //updated by: wesley66101
        public const int AvatarEffectActivatedMessageComposer = 1001; //updated by: wesley66101
        public const int InstantMessageErrorMessageComposer = 2085; //updated by: wesley66101
        public const int GnomeBoxMessageComposer = 3985; //updated by: wesley66101
        public const int CfhTopicsInitMessageComposer = 1481; //updated by: wesley66101
        public const int IgnoreStatusMessageComposer = 770; //updated by: wesley66101
        public const int PetInformationMessageComposer = 3390; //updated by: wesley66101
        public const int NavigatorSearchResultSetMessageComposer = 972; //updated by: wesley66101
        public const int GroupInfoMessageComposer = 1848; //updated by: wesley66101
        public const int ConcurrentUsersGoalProgressMessageComposer = 3773; //updated by: wesley66101
        public const int UsersMessageComposer = 2185; //updated by: wesley66101
        public const int VideoOffersRewardsMessageComposer = 3080; //updated by: wesley66101
        public const int ItemRemoveMessageComposer = 2746; //updated by: wesley66101
        public const int SanctionStatusMessageComposer = 1630; //updated by: wesley66101
        public const int GetYouTubeVideoMessageComposer = 2730; //updated by: wesley66101
        public const int GenericErrorMessageComposer = 3439; //updated by: wesley66101
        public const int UserRightsMessageComposer = 809; //updated by: wesley66101
        public const int ItemAddMessageComposer = 874; //updated by: wesley66101
        public const int CheckPetNameMessageComposer = 3789; //updated by: wesley66101
        public const int RespectPetNotificationMessageComposer = 1574; //updated by: wesley66101
        public const int EnforceCategoryUpdateMessageComposer = 1199; //updated by: wesley66101
        public const int ActionMessageComposer = 2588; //updated by: wesley66101
        public const int CommunityGoalHallOfFameMessageComposer = 806; //updated by: wesley66101
        public const int ModeratorSupportTicketMessageComposer = 881; //updated by: wesley66101
        public const int AchievementsMessageComposer = 585; //updated by: wesley66101
        public const int FloorPlanFloorMapMessageComposer = 3539; //updated by: wesley66101
        public const int SendGameInvitationMessageComposer = 1537; //updated by: wesley66101
        public const int AchievementUnlockedMessageComposer = 246; //updated by: wesley66101
        public const int GiftWrappingErrorMessageComposer = 3391; //updated by: wesley66101
        public const int OpenConnectionMessageComposer = 1620; //updated by: wesley66101
        public const int TradingClosedMessageComposer = 3176; //updated by: wesley66101
        public const int PromoArticlesMessageComposer = 2950; //updated by: wesley66101
        public const int Game1WeeklyLeaderboardMessageComposer = 1264; //updated by: wesley66101
        public const int RentableSpacesErrorMessageComposer = 748; //updated by: wesley66101
        public const int AddExperiencePointsMessageComposer = 2555; //updated by: wesley66101
        public const int OpenHelpToolMessageComposer = 3132; //updated by: wesley66101
        public const int CreditBalanceMessageComposer = 3782; //updated by: wesley66101
        public const int QuestCompletedMessageComposer = 1431; //updated by: wesley66101
        public const int GetRoomFilterListMessageComposer = 3676; //updated by: wesley66101
        public const int GameAchievementListMessageComposer = 1120; //updated by: wesley66101
        public const int CarryObjectMessageComposer = 1095; //updated by: wesley66101
        public const int InitCryptoMessageComposer = 1621; //updated by: wesley66101
        public const int PromotableRoomsMessageComposer = 1260; //updated by: wesley66101
        public const int TradingCompleteMessageComposer = 2934; //updated by: wesley66101
        public const int FloorPlanSendDoorMessageComposer = 1288; //updated by: wesley66101
        public const int FurniListMessageComposer = 1442; //updated by: wesley66101
        public const int RoomEntryInfoMessageComposer = 1089; //updated by: wesley66101
        public const int CatalogUpdatedMessageComposer = 1079; //updated by: wesley66101
        public const int SetUniqueIdMessageComposer = 1774; //updated by: wesley66101
        public const int FurniListUpdateMessageComposer = 582; //updated by: wesley66101
        public const int NewGroupInfoMessageComposer = 3837; //updated by: wesley66101
        public const int RoomNotificationMessageComposer = 480; //updated by: wesley66101
        public const int ClubGiftsMessageComposer = 3248; //updated by: wesley66101
        public const int FurniListAddMessageComposer = 108; //updated by: wesley66101
        public const int MOTDNotificationMessageComposer = 1952; //updated by: wesley66101
        public const int HabboGroupBadgesMessageComposer = 2610; //updated by: wesley66101
        public const int PopularRoomTagsResultMessageComposer = 698; //updated by: wesley66101
        public const int NewConsoleMessageMessageComposer = 3447; //updated by: wesley66101
        public const int RoomPropertyMessageComposer = 2155; //updated by: wesley66101
        public const int TradingUpdateMessageComposer = 3583; //updated by: wesley66101
        public const int MarketPlaceOffersMessageComposer = 1690; //updated by: wesley66101
        public const int TalentTrackMessageComposer = 1332; //updated by: wesley66101
        public const int GroupFurniSettingsMessageComposer = 3799; //updated by: wesley66101
        public const int ProfileInformationMessageComposer = 1591; //updated by: wesley66101
        public const int BadgeDefinitionsMessageComposer = 1616; //updated by: wesley66101
        public const int SoundSettingsMessageComposer = 3429; //updated by: wesley66101
        public const int UserTypingMessageComposer = 2292; //updated by: wesley66101
        public const int Game2WeeklyLeaderboardMessageComposer = 1802; //updated by: wesley66101
        public const int NameChangeUpdateMessageComposer = 2694; //updated by: wesley66101
        public const int RoomVisualizationSettingsMessageComposer = 3700; //updated by: wesley66101
        public const int MarketplaceMakeOfferResultMessageComposer = 1357; //updated by: wesley66101
        public const int UserPerksMessageComposer = 573; //updated by: wesley66101
        public const int ForumsListDataMessageComposer = 2673; //updated by: wesley66101
        public const int DanceMessageComposer = 1501; //updated by: wesley66101
        public const int FlatCreatedMessageComposer = 1439; //updated by: wesley66101
        public const int BotInventoryMessageComposer = 2530; //updated by: wesley66101
        public const int ObjectsMessageComposer = 468; //updated by: wesley66101
        public const int ItemsMessageComposer = 610; //updated by: wesley66101
        public const int LoadGameMessageComposer = 1506; //updated by: wesley66101
        public const int AvatarEffectsMessageComposer = 2460; //updated by: wesley66101
        public const int ManageGroupMessageComposer = 1683; //updated by: wesley66101
        public const int UpdateMagicTileMessageComposer = 1122; //updated by: wesley66101
        public const int CampaignCalendarDataMessageComposer = 1608; //updated by: wesley66101
        public const int FurnitureAliasesMessageComposer = 2188; //updated by: wesley66101
        public const int MaintenanceStatusMessageComposer = 3921; //updated by: wesley66101
        public const int Game3WeeklyLeaderboardMessageComposer = 2084; //updated by: wesley66101
        public const int BadgesMessageComposer = 1242; //updated by: wesley66101
        public const int WiredEffectConfigMessageComposer = 1413; //updated by: wesley66101
        public const int GameListMessageComposer = 1154; //updated by: wesley66101
        public const int RoomMuteSettingsMessageComposer = 2496; //updated by: wesley66101
        public const int RoomInviteMessageComposer = 3410; //updated by: wesley66101
        public const int LoveLockDialogueSetLockedMessageComposer = 2525; //updated by: wesley66101
        public const int BroadcastMessageAlertMessageComposer = 3856; //updated by: wesley66101
        public const int MarketplaceCancelOfferResultMessageComposer = 436; //updated by: wesley66101
        public const int ForumDataMessageComposer = 1273; //updated by: wesley66101
        public const int AchievementProgressedMessageComposer = 1482; //updated by: wesley66101
        public const int RefreshFavouriteGroupMessageComposer = 879; //updated by: wesley66101
        public const int TradingErrorMessageComposer = 1169; //updated by: wesley66101
        public const int ObjectAddMessageComposer = 470; //updated by: wesley66101
        public const int TradingAcceptMessageComposer = 3697; //updated by: wesley66101
        public const int AuthenticationOKMessageComposer = 456; //updated by: wesley66101
        public const int TradingStartMessageComposer = 3008; //updated by: wesley66101
        public const int NavigatorSettingsMessageComposer = 357; //updated by: wesley66101
        public const int FlatControllerAddedMessageComposer = 1297; //updated by: wesley66101
        public const int ModeratorTicketChatlogMessageComposer = 2198; //updated by: wesley66101
        public const int MessengerInitMessageComposer = 805; //updated by: wesley66101
    }
}