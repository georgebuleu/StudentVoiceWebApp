import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatMenuModule} from '@angular/material/menu';
import { CommonModule } from '@angular/common';
import { MatRadioModule} from '@angular/material/radio';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { MatSelectModule} from '@angular/material/select';
import { MatFormFieldModule} from '@angular/material/form-field';
import { MatIconModule} from '@angular/material/icon';
import {MatDividerModule} from '@angular/material/divider';
import {MatListModule} from '@angular/material/list';
import {MatGridListModule} from '@angular/material/grid-list';
import {MatDialogModule, MatDialogRef} from '@angular/material/dialog';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatButtonToggleModule} from '@angular/material/button-toggle';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ForgotyourpasswordComponent } from './core/components/forgotyourpassword/forgotyourpassword.component';
import { RecoverpasswordComponent } from './core/components/recoverpassword/recoverpassword.component';
import { NewpasswordComponent } from './core/components/newpassword/newpassword.component';
import { CreatesurveyComponent } from './features/admin/createsurvey/createsurvey.component';
import { AnswertosurveysComponent } from './features/student/answertosurveys/answertosurveys.component';
import { SettingsComponent } from './core/components/settings/settings.component';
import { NavbarComponent } from './core/components/navbar/navbar.component';
import { MyaccountComponent } from './core/components/myaccount/myaccount.component';
import { ReviewanswersComponent } from './features/student/reviewanswers/reviewanswers.component';
import { PageNotFoundComponent } from './core/components/page-not-found/page-not-found.component';
import { FooterComponent } from './core/components/footer/footer.component';
import { LandingscreenComponent } from './core/components/landingscreen/landingscreen.component';
import { CreateaccountComponent } from './core/components/createaccount/createaccount.component';
import { StudentmainpageComponent } from './features/student/studentmainpage/studentmainpage.component';
import { StatisticsComponent } from './features/admin/statistics/statistics.component';
import { EditsurveyComponent } from './features/admin/editsurvey/editsurvey.component';
import { ApprovequestionsComponent } from './features/admin/approvequestions/approvequestions.component';
import { AdminmainpageComponent } from './features/admin/adminmainpage/adminmainpage.component';
import { SubmitquestionComponent } from './features/student/submitquestion/submitquestion.component';
import { DialogModule } from '@angular/cdk/dialog';
import { DialogSettingsComponent } from './core/components/dialog-settings/dialog-settings.component';
import { HttpClientModule } from '@angular/common/http';
import { JwtModule } from '@auth0/angular-jwt';

export function tokenGetter(){
  return localStorage.getItem("jwt");
}

@NgModule({
  declarations: [
    AppComponent,
    LandingscreenComponent,
    CreateaccountComponent,
    ForgotyourpasswordComponent,
    RecoverpasswordComponent,
    NewpasswordComponent,
    StudentmainpageComponent,
    CreatesurveyComponent,
    AnswertosurveysComponent,
    SettingsComponent,
    NavbarComponent,
    MyaccountComponent,
    ReviewanswersComponent,
    PageNotFoundComponent,
    FooterComponent,
    StatisticsComponent,
    EditsurveyComponent,
    ApprovequestionsComponent,
    AdminmainpageComponent,
    SubmitquestionComponent,
    DialogSettingsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FontAwesomeModule,
    BrowserAnimationsModule,
    CommonModule,
    RouterModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MatMenuModule,
    MatRadioModule,
    MatSelectModule,
    MatFormFieldModule,
    MatIconModule,
    MatDividerModule,
    MatListModule,
    MatGridListModule,
    MatDialogModule,
    DialogModule,
    HttpClientModule,
    MatButtonToggleModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
