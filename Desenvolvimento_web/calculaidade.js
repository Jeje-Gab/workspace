function calculaIdade(anos) {
    return `Daqui a ${anos} anos, ${this.nome} terá ${
        this.idade + anos
    } anos de idade.`;
}

const pessoa = {
    nome: "Maria",
    idade: 30
};

const pessoa2 = {
    nome: "Carol",
    idade: 10
};

// Utiliza-se call para especificar de qual "Objeto" vai receber os parametros
console.log(calculaIdade.call(pessoa2, 30));
// E 30 se trata do valor atribuido para anos

// A diferença é que se aplica o valor em [] em array
console.log(calculaIdade.apply(pessoa, [10]));