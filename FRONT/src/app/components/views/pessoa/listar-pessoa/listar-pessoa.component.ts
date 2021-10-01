import { Component, OnInit } from "@angular/core";
import { Pessoa } from "src/app/models/pessoa";
import { PessoaService } from "src/app/services/pessoa.service";

@Component({
    selector: "app-listar-pessoa",
    templateUrl: "./listar-pessoa.component.html",
    styleUrls: ["./listar-pessoa.component.css"],
})
export class ListarPessoaComponent implements OnInit {
    pessoa: Pessoa[] = [];

    constructor(private service: PessoaService) {}

    ngOnInit(): void {
        this.service.list().subscribe((pessoa) => {
            this.pessoa = pessoa;
            console.log(pessoa);
        });
    }
}