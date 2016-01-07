卒業研究(HMDを用いた拡張現実における手書き支援システム)
====

![graduate](https://github.com/kentx422/Resource/blob/master/img/graduate_intro.png?raw=true)
拡張現実を使って字を綺麗に書くためのシステム

## Description

ユーザは，拡張現実を用いた本システムを用いることで直感的に綺麗な字を書くことができるようになる．   
拡張現実は，HMDとモーションセンサ，ステレオカメラを用いて実現する． 
今回はHMDとしてOculus Rift，モーションセンサとしてLeap Motion，ステレオカメラとしてOvervisionを用いている．
  
拡張現実として表示する「手本となる文字」はモーションセンサで取得した腕を基準に表示位置を決め，ステレオカメラで取得した映像に重ねあわせてHMDに表示している．
この際，Unityを用いており，主にC#でプログラムの実装を行っている．

## Demo

[![write](http://img.youtube.com/vi/Op5xyvNrfpg/0.jpg)](https://www.youtube.com/watch?v=Op5xyvNrfpg)
画像をクリックするとYoutubeに飛びます

##Equipment

・ HMD(Head Mount Display)
・ モーションセンサ
・ ステレオカメラ
・ コンピュータ

## Usage

1. 機器を装着
2. 腕を認識
3. 表示されている手本となる文字画像を任意の位置に移動
4. 手本に合わせてなぞるように文字を筆記

## Author

松井健人
<kmatsui@mikilab.doshisha.ac.jp>
