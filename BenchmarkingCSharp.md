# BenchmarkingCSharp

sudo dotnet run BenchmarkingCSharp.csproj -c Release

# 1 Dictionary
10k Items Bench<br>
  GetValueByKey<br>
  GetValueByKeyWithLinq<br>
  GetValueByKeyWithTryGet<br>
  GetValueByKeyManual<br>
![](https://cdn.discordapp.com/attachments/922218550633046037/924654731958321152/Screen_Shot_2021-12-26_at_13.51.47.png)

# 2 String build / List
10k Items Bench<br>
    ConcatStringsUsingStringBuilder<br>
    ConcatStringsUsingGenericList<br>
![](https://cdn.discordapp.com/attachments/922218550633046037/924654732319006720/Screen_Shot_2021-12-26_at_14.00.48.png)

# 3 Hash Sha1 256 384 512 /  MD5
![](https://cdn.discordapp.com/attachments/922218550633046037/924654732570656788/Screen_Shot_2021-12-26_at_14.20.51.png)

# 4 Hardward response
SortedBranch<br>
UnsortedBranch<br>
SortedBranchless<br>
UnsortedBranchless<br>
![](https://cdn.discordapp.com/attachments/922218550633046037/924654731668897833/Screen_Shot_2021-12-26_at_14.22.38.png)