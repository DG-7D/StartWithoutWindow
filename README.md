# StartWithoutWindow

CUI/GUIアプリケーションをウィンドウを表示せずに起動するアプリケーションです。バックグラウンドで動作させるアプリケーションを邪魔にならないようにできます。

## 使用法

```
StartWithoutWindow.exe "パス" 引数
```

- `パス` : 非表示で実行したい実行ファイルへのパスです。絶対パス、または**`StartWithoutWindow.exe`に対する**相対パスで指定できます。つまり、`StartWithoutWindow.exe`を目的の実行ファイルと同じ場所に置くことで、実行ファイル名のみの指定で済みます。空白が含まれる場合は`"`でくくるなどして一つの文字列としてください。
- `引数` : 元のアプリケーションに渡すときと全く同じ形で渡すことができます。つまり、全体を`"`で囲ったりする必要はありません。

## 使用例・PowerShellとの比較

スタートアップにショートカット登録を登録したりする際、PowerShellを使って

```
powershell.exe -Command "Start-Process -WindowStyle Hidden '\path\to\program.exe' 'arg1 arg2'"
```

と書いていたものは、目的の実行ファイルと同じディレクトリに`StartWithoutWindow.exe`を配置すると、

```
"\path\to\StartWithoutWindow.exe" program.exe arg1 arg2
```

と書けるようになります。

また、PowerShellでは一瞬PowerShell自体のウィンドウが表示されてしまいますが、`StartWithoutWindow.exe`は自身のウィンドウも表示しません。