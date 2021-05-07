function refineText(s, options) {
  s=s
    .replace("    ", " ")
    .replace("\t"," ")
    .replace("\t "," ")
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



//12~14번째 코드를 추가하였다. 해당 코드는 랜덤으로 발생되는 단어에 마스킹을 하려고 만든 코드이다.
//하지만 test를 실행해보면 위의 3~9번째 테스트로 성공했던 케이스가 모두 실패한다.
//11번째 코드를 추가하여 options가 지정되어 있을때만, 실행 하도록 한다면, 모두 성공한다.
//if에 options만 썼지만, bannedWords도 검사를 해야 더욱 안전한 코드가 된다.



//13줄 for문 설명
//javascript에는 for문, for in문, for of문이 존재한다.
//for of문은 반복할 수 있는 객체를 순회할 수 있도록 해주는 반복문이다.
//그럼 반복할 수 있는 객체는 무엇이 있을까? Array,map,Set,argument등이 있다.
//사용방법
//for(변수 of 객체){ 반복적으로 실행하고자 하는 실행문; }