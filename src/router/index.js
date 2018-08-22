import Vue from 'vue'
import Router from 'vue-router'
import PeopleSearch from '@/components/PeopleSearch'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'PeopleSearch',
      component: PeopleSearch
    }
  ]
})
