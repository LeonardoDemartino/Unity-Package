﻿using System;

namespace PurchaselyRuntime
{
	internal interface IPurchasely
	{
		void Init(string apiKey, string userId, bool readyToPurchase, int logLevel, int runningMode,
			Action<bool, string> onStartCompleted, Action<PurchaselyEvent> onEventReceived);

		void UserLogin(string userId, Action<bool> onCompleted);

		void SetIsReadyToPurchase(bool ready);

		void PresentContentForPlacement(string placementId, bool displayCloseButton,
			Action<ProductViewResult, PurchaselyPlan> onResult, Action<bool> onContentLoaded,
			Action onCloseButtonClicked, string contentId);
	}
}