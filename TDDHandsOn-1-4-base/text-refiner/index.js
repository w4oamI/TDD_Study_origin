function refineText(s, options) {
  s=s
    .replace("    ", " ")
    .replace("\t"," ")
    .replace("  ", " ")
    .replace("  ", " ")
    .replace("  ", " ")
    .replace("mockist", "*******")
    .replace("purist", "******");

    if(options){
    for(const bannedWord of options.bannedWords){
        s = s.replace(bannedWord, "*".repeat(bannedWord.length));
    }
  }

    return s
}

module.exports = refineText;



//11~13번째 코드를 추가하였다. 해당 코드는 랜덤으로 발생되는 단어에 마스킹을 하려고 만든 코드이다.
//하지만 test를 실행해보면 위의 3~9번째 테스트로 성공했던 케이스가 모두 실패한다.
