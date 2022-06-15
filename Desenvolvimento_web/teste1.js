const alunos = [
    {    
        nome: 'João',
        nota: 5,
        turma: '1B',
    },
    {
        nome: 'Sofia',
        nota: 9,
        turma: '1B',
    },
    {
        nome: 'Paulo',
        nota: 6,
        turma: '2C',
    },
];

function alunosAprovados(arr, media) {
// Funçâo alunos aprovados (array )    
    let aprovados = [];

    for (let i = 0; i < arr.length; i++){
    //Enquanto i for menor que o tamnaho do nosso array inicial

        const {nota, nome} = arr[i];
        // Teremos estas duas constantes, nota e o nome
        // que vão ser = ao objeto
        // o objeto é o aluno atual no seguinte indice

        if (nota >= media) {
            aprovados.push(nome);
            //Push add o nome do aluno aprovado em aprovados
        }

        // Ou 
       
        /*
        if (arr[i].nota >= media) {
            //O aluno é representado por "aquele indice do array"
            //arr[i] o aluno neste indice
            //.nota -> Compara sua notra com "media", caso seja >=

            aprovados.push(arr[i].nome);
            //Aluno "naquele indice" tem seu nome add "push" o nome deste aluno em aprovados
        }
        */
    }
    
    return aprovados;
}

console.log(alunosAprovados(alunos, 5));