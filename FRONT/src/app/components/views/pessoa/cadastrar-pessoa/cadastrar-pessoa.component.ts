import { Pessoa } from '../../../../models/pessoa';
import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { Pessoa } from "src/app/models/pessoa";
import { PessoaService } from "src/app/services/pessoa.service";

@Component({
    selector: "app-cadastrar-pessoa",
    templateUrl: "./cadastrar-pessoa.component.html",
    styleUrls: ["./cadastrar-pessoa.component.css"],
})
export class CadastrarPesssoaComponent implements OnInit {
    id!: number;
    nome!: string;    
    cpf!: string;
    descricao!: string;
    criadoem!: string;
   

    constructor(private service: PessoaService, private router: Router) {}

    ngOnInit(): void {}

    create(): void {
        let pessoa: Pessoa = {
            nome: this.nome,
            cpf: this.cpf,
            descricao: this.descricao,
            criadoem: this.criadoem,
        };
        this.service.create(pessoa).subscribe((pessoa) => {
            this.router.navigate(["pessoa/listar"]);
        });
    }
}