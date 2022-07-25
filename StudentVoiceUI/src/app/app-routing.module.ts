import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AnswertosurveysComponent } from './features/student/answertosurveys/answertosurveys.component';
import { CreateaccountComponent } from './core/components/createaccount/createaccount.component';
import { ForgotyourpasswordComponent } from './core/components/forgotyourpassword/forgotyourpassword.component';
import { LandingscreenComponent } from './core/components/landingscreen/landingscreen.component';
import { MyaccountComponent } from './core/components/myaccount/myaccount.component';
import { NewpasswordComponent } from './core/components/newpassword/newpassword.component';
import { PageNotFoundComponent } from './core/components/page-not-found/page-not-found.component';
import { RecoverpasswordComponent } from './core/components/recoverpassword/recoverpassword.component';
import { ReviewanswersComponent } from './features/student/reviewanswers/reviewanswers.component';
import { SettingsComponent } from './core/components/settings/settings.component';
import { StudentmainpageComponent } from './features/student/studentmainpage/studentmainpage.component';
import { SubmitquestionComponent } from './features/student/submitquestion/submitquestion.component';
import { StatisticsComponent } from './features/admin/statistics/statistics.component';
import { CreatesurveyComponent } from './features/admin/createsurvey/createsurvey.component';
import { EditsurveyComponent } from './features/admin/editsurvey/editsurvey.component';
import { ApprovequestionsComponent } from './features/admin/approvequestions/approvequestions.component';
import { AdminmainpageComponent } from './features/admin/adminmainpage/adminmainpage.component';
import { IconsGuard } from './shared/icons.guard';

const routes: Routes = [
  {
  path:'createaccount',
  component: CreateaccountComponent
},
{
  path:'',
  component: LandingscreenComponent
},{
path:'studentmainpage',
component:StudentmainpageComponent
},
{
  path:'forgotyourpassword',
  component: ForgotyourpasswordComponent
},
{
  path:'recoverpassword',
  component: RecoverpasswordComponent
},
{
  path:'newpassword',
  component: NewpasswordComponent
},
{
  path:'answertosurveys',
  component: AnswertosurveysComponent
},
{
  path:'settings',
  component: SettingsComponent
},
{
  path:'myaccount',
  component: MyaccountComponent
},
{
  path:'submitquestion',
  component: SubmitquestionComponent
},
{
  path:'reviewanswers',
  component: ReviewanswersComponent
},
{
  path:'statistics',
  component: StatisticsComponent
},
{
  path:'createsurvey',
  component: CreatesurveyComponent
},
{
  path:'editsurvey',
  component: EditsurveyComponent
},
{
  path:'adminmainpage',
  component: AdminmainpageComponent
},
{
  path:'approvequestions',
  component: ApprovequestionsComponent
},
{
  path:'**',
  component: PageNotFoundComponent
}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
