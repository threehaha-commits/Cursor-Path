mergeInto(LibraryManager.library, {

  ShowFullscreen: function () {
      ysdk.adv.showFullscreenAdv({
      callbacks: {
          onOpen: function(wasShown) {
          myGameInstance.SendMessage("StartAds", "WebAdShow");
            console.log('Реклама Fullscreen открылась.');
          },
          onClose: function(wasShown) {
          myGameInstance.SendMessage("StartAds", "WebAdClose");
            console.log("Реклама Fullscreen закрылась.");
          },
          onError: function(error) {
            console.log("Ошибка по рекламе Fullscreen.");
          }
      }
      })
  },

  ShowRewarded: function () {
      ysdk.adv.showRewardedVideo({
      callbacks: {
          onOpen: () => {
          myGameInstance.SendMessage("StartAds", "WebAdShow");
            console.log('Реклама Rewarded открылась.');
          },
          onRewarded: () => {
            console.log('Реклама Rewarded просмотрена, и производим награду игроку за просмотр.');
            myGameInstance.SendMessage("StartAds", "ResumeGame");
          },
          onClose: () => {
          myGameInstance.SendMessage("StartAds", "WebAdClose");
            console.log('Реклама Rewarded закрылась.');
          }, 
          onError: (e) => {
            console.log('Ошибка по рекламе Rewarded:', e);
          }
      }
  })
  },

});