import { RouterModule, Routes } from '@angular/router';
import { ThemeComponent } from './components/theme/theme.component';
import { NgModule } from '@angular/core';
import { ListaDadosComponent } from './components/data-display/data-display.component';

export const routes: Routes = [
    {
        path: 'theme',
         component: ThemeComponent
    },
    {
        path: 'newcard',
         component: ListaDadosComponent
    }
];
@NgModule({
imports: [RouterModule.forRoot(routes)],
exports: [RouterModule]
})
export class AppRoutingModule { }