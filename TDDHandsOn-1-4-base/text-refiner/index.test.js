const sut = require("./index"); //sut= system under test(테스트 대상 시스템)


//테스트 케이스(중복 코드)
//---------------------------------------------------------------------------//
/*test('sut transforms "hello  world" to "hello world"', () => {
    const actual = sut("hello  world");
    expect(actual).toBe("hello world");
});

test('sut transforms "hello   world" to "hello world"',() => {
    const actual = sut("hello   world");
    expect(actual).toBe("hello world");
});

test('sut transforms"hello    world" to "hello world"',()=>{
    const actual = sut("hello    world");
    expect(actual).toBe("hello world");
});*/
//---------------------------------------------------------------------------//


//테스트 케이스(중복 코드 제거)
//---------------------------------------------------------------------------//
/*test('sut correctly works', () => {
    for (const source of ['hello  world', 'hello   world', 'hello    world']) {
        const actual = sut(source);
        expect(actual).toBe("hello world");
    }
});*/
//문제점1. 첫번째 케이스는 어떤 부분이 문제가 있는지를 확인시켜준다. (총3개의 경우가 있으니 확인 가능)
//         하지만 두번째 케이스는 배열안에서 어떤 값이 문제가 있는지 확인이 안된다.
//문제점2. 공백이 3개가 들어간 테스트 케이스가 실패하면, 4개일 경우에는 확인하지가 않는다. 즉, 끝까지 실행 불가능    
//     -> 첫번째 테스트 케이스인 중복 코드보다 피드백 품질이 낮아졌다. 그러므로 테스트 코드가 줄었다해서 좋은것은 아니다.      
//---------------------------------------------------------------------------//


//문제 해결
//---------------------------------------------------------------------------//
//위의 문제 두개를 해결 하기 위해 파라미터화 테스트(Parameterized Test)를 사용한다.
//테스트 코드를 실행할 때 동일한 테스트코드를 여러개의 테스트 데이터를 바꾸면서 테스트하는 것이다.
//---------------------------------------------------------------------------//


//테스트 케이스(Parameterized Test)

test.each`
source              | expected
${"hello  world"}   | ${"hello world"}
${"hello   world"}  | ${"hello world"}
${"hello    world"} | ${"hello world"}
`('sut transforms "$source" to "$expected"', ({source, expected }) => { //{source, expected}은 테이블 로우가 제공해주는 데이터 입력
    const actual = sut(source);
    expect(actual).toBe(expected);
});
