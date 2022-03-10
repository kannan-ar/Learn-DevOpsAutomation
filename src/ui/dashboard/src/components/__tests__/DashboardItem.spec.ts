import { shallowMount } from '@vue/test-utils'
import DashboardItem from '../DashboardItem.vue'

describe('DashboardItem.vue', () => {
  test('renders props.msg when passed', () => {
    const msg = 'Loading...'
    const wrapper = shallowMount(DashboardItem, {
      propsData: { msg }
    })
    expect(wrapper.text()).toMatch(msg)
  })
})