#各オブジェクトから値もらってMainで処理したい


# unitypro
##AR神経衰弱マニュアル
* 必要なもの
  * PC1台(windows 10/64bit/メモリ 8.00GBにて動作確認済み)
  * Webカメラ(HD webcam C615)
  * Unity(ゲームエンジン)
  * ARマーカー20枚

* 作業手順
  * 1.Unityのダウンロードとアカウント登録
  * 2.ゲームのプロジェクトのダウンロード
  * 3.ARマーカーのダウンロード
  * 4.ゲームの起動


* 1.Unityのダウンロードとアカウント登録
  * 1-1.Unityのダウンロード
    * https://unity3d.com/jp/get-unity/download
      上記のURLのページにて「リソース/過去バージョンのUnity」を選択し、「Unity 5.1.2」の「Downloads(Win)」から
      「Unity Editor 32-bit」を選択し、ダウンロードする(PCが64bitであっても上記の32bitを選択すること)
  * 1-2.Unityのインストール
    * ダウンロードしたファイルを実行する
    * Unityのセットアップが開始されるので「next」を選択し、
      ライセンスの内容を確認したうえで「I Agree」を選択する
      次の画面では各種設定は変更せず、「next」を選択し、次の画面ではインストールする場所を確認されるので、
      変更せずに「Install」を選択するとインストールが開始される
    * インストール終了後、画面に表示される「Run Unity 5.1.2f1(32-bit)」のチェックを外し、「Finish」を選択する
  * 1-3.Unityのアカウント登録
    * デスクトップ上に「Unity5.1.2f1(32-bit)」と書かれたアイコンが出現するので、起動する
    * 「Welcome to Unity」と表示されアカウントの確認をされるので「Sign into your Unity Account」の下にある
      「create one」を選択する
    * ブラウザが起動し、アカウント作成画面が表示されるので各項目を入力し、「I agree to the Unity ...」チェックを入れ
      「Create account」を選択する
      指定したメールアドレスに「Unity Accounts」からメールが来るので、
      「Confirm email」を選択し、登録したメールアドレスとパスワードを入力する
    * デスクトップの「Unity5.1.2f1(32-bit)」と書かれたアイコンからUnityを起動し、
      先ほど登録したメールアドレスとパスワードを入力しログインする
    * 「License management」と表示されるので「Unity PERSONAL EDITION」にチェックを入れ「Next」を選択する
    * 「License agreement」と表示されるので「I agree」を選択する
    * 「Quick and easy survey;)」と表示されるので各質問に答え、「OK」を選択
    * 「Thank you!:)」と表示されるので「Start Using Unity」を選択し、右上の「×」を選択し、画面を閉じる
  * 2.ゲームのprojectのダウンロード
    * なすびちゃん内(\\150.89.234.253\teams\mst57)にある「New Unity Project」をダウンロードし任意の場所に保存する
    * 「Nwe Unity Project」を開き、New Unity Project/Assets内の「unity.unity」を実行する
    * 画面にunityのEdit(全体的にグレーな)画面が全画面表示で表示されるので表示を確認したら、
      右上の「×」を選択しUnityを終了する
  * 3.ARマーカーのダウンロード
    * https://drive.google.com/folderview?id=0BwYgz6rGg3gSaFZVY01OckdlRG8&usp=sharing
      上記のURL内にある「ARマーカー」をダウンロードし任意の場所に保存する
    * 「ARマーカー」を開き、中にある20枚の画像と対応表を印刷する
  * 4.ゲームの起動
    * Webカメラ(HD webcam C615)をパソコンに接続する
    * デスクトップ上の「Unity5.1.2f1(32-bit)」と書かれたアイコンを選択し、Unityを起動する
    * 起動するObjectを選択する画面が表示されるので、「New Unity Project」を選択する
    * 画面中央上部にある「・再生)」を選択する